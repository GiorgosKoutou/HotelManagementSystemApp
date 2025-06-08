using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.ModelServices
{
    public class ReservationService
    {
        private Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction;
        private readonly DataAccessLibrary.Context.HpmsDbContext context;

        private int index = 0;
        private double totalPrice = 0.0;
        private string? customerInfo = string.Empty;
        private string? roomNumber = string.Empty;
        private bool isCheckIn = false;
        private bool isCheckOut = false; 
        private bool isNew = false;

        private BindingSource reservationSource = new();
        private BindingSource roomSource = new();

        public double TotalPrice { get => totalPrice; }
        public string RoomNumber { get => roomNumber!; }
        public string CustomerInfo { get => customerInfo!; set => customerInfo = value; }

        public BindingSource ReservationSource { get => reservationSource;}
        public BindingSource RoomSource { get => roomSource; }

        public ReservationService(DataAccessLibrary.Context.HpmsDbContext context)
        {
            reservationSource.DataSource = context.Reservations.ToList();
            this.context = context;
        }

        public void SearchReservationForBook(DateTimePicker from, DateTimePicker to,NumericUpDown peopleNumber)
        {
            int numberOfPeople = Convert.ToInt32(peopleNumber.Value);
            var reservedRooms = context.Reservations.Where(r => (r.ReservationDateFrom.Date <= from.Value.Date &&
                                                                 r.ReservationDateTo.Date >= from.Value.Date) ||
                                                                 (r.ReservationDateTo.Date >= to.Value.Date &&
                                                                 r.ReservationDateTo.Date <= to.Value.Date))
                                                    .Select(r => r.Room.Id).ToList();
            var rooms = context.Rooms.Where(r => r.BedNumber >= numberOfPeople).Include(i => i.RoomTypeCategory).ToList();
            var freeRooms = rooms.Where(r => !reservedRooms.Contains(r.Id)).ToList();


            if (!freeRooms.Any())
            {
                MessageBox.Show("");
                return;
            }

            roomSource.DataSource = freeRooms;
        }

        public void SearchCheckInOut(DateTimePicker from, ComboBox box)
        {
            var reservation = context.Reservations.Where(r => r.ReservationDateFrom.Date == from.Value.Date &&
                                                                        r.Customer == box.SelectedItem)
                                                    .Include(ir => ir.Room).Include(ic => ic.Customer).ToList();

            reservationSource.DataSource = reservation;

        }

        public void SaveReservation()
        {
            try
            {
                transaction = context.Database.BeginTransaction();
                var currentRecord = (DataAccessLibrary.Models.Reservation)reservationSource.Current;
                var entry = context.Entry(currentRecord);

                if (entry.State == EntityState.Detached)
                {
                    var room = context.Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

                    if (isNew)
                    {
                        var newCustomer = AddNewCustomer();
                        currentRecord.Customer = newCustomer;
                    }

                    currentRecord.Room = room!;

                    context.Add(currentRecord);
                    MessageBox.Show("Reservation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (entry.State == EntityState.Unchanged)
                {
                    var room = context.Rooms.FirstOrDefault( r => r.RoomNumber == roomNumber);
                    if(isCheckIn)
                        currentRecord.CheckInDate = DateTime.Now;
                    if(isCheckOut)
                        currentRecord.CheckOutDate = DateTime.Now;

                    currentRecord.ReservationPrice = totalPrice;
                    currentRecord.Room = room!;
                    context.Update(currentRecord);
                    MessageBox.Show("Reservation updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                context.SaveChanges();
                transaction.Commit();
            }
            catch (DbUpdateException e)
            {

                string errorMessage = e.InnerException!.Message;
                MessageBox.Show($"Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction?.Rollback();
            }
            
        }

        

        private DataAccessLibrary.Models.Customer AddNewCustomer()
        {
            DataAccessLibrary.Models.Customer newCustomer = new();

            string[] splitInfo = customerInfo!.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            if(splitInfo.Length == 2)
            {
                newCustomer.FirstName = splitInfo[0];
                newCustomer.LastName = splitInfo[1];

                return newCustomer;
            }
            if (splitInfo.Length == 3)
            {
                newCustomer.FirstName = splitInfo[0];
                newCustomer.LastName = splitInfo[1];
                newCustomer.Tin = splitInfo[2];

                return newCustomer;
            }

            if (splitInfo.Length == 0)
                MessageBox.Show("Please fill in Customer's Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            return null!; 
        }
        public void GetCustomerCheckBox(CheckBox box)
        {
            if(box.Checked)
                isNew = true;
        }
        public void GetCheckInOut(CheckBox checkIn, CheckBox checkOut)
        {
            if(checkIn.Checked)
                isCheckIn = true;

            if(checkOut.Checked)
                isCheckOut = true;
        }

        public void SetTotalPrice(double roomPrice)
        {
            var dateFrom = ((DataAccessLibrary.Models.Reservation)reservationSource[index]).ReservationDateFrom.Day;
            var dateTo = ((DataAccessLibrary.Models.Reservation)reservationSource[index]).ReservationDateTo.Day;

            totalPrice = (dateFrom - dateTo) * roomPrice;
        }

        public void SetCustomerComboBox(ComboBox box)
        {
            List<DataAccessLibrary.Models.Customer> customer = [];

            if (!string.IsNullOrEmpty(box.Text))
            {
                customer = [.. context.Customers.Where(c => c.FirstName!.Contains(box.Text) ||
                                                        c.LastName!.Contains(box.Text))];
            }
            box.DataSource = customer;
        }

        public void SetIndex(int _index)
        {
            index = _index;
        }

        public void SetRoomNumber<TModel>(BindingSource source) where TModel : class
        {
            var type = typeof(TModel);

            if (type == typeof(DataAccessLibrary.Models.Reservation))
                roomNumber = ((DataAccessLibrary.Models.Reservation)source[index]).RoomNumber;

            if(type ==  typeof(DataAccessLibrary.Models.Room))
                roomNumber = ((DataAccessLibrary.Models.Room)source[index]).RoomNumber;
        }

    }
}
