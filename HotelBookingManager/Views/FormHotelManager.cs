using HotelBookingManager.Repository.Entities;
using HotelBookingManager.Repository.Repos;
using HotelBookingManager.Views;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingManager
{
    public partial class FormHotelManager : Form
    {
        private readonly BookingRepo _bookingRepo;
        private readonly CustomerRepo _customerRepo;
        private readonly InvoiceRepo _invoiceRepo;
        private readonly RoomRepo _roomRepo;

        public FormHotelManager()
        {
            InitializeComponent();

            _bookingRepo = new BookingRepo();
            _customerRepo = new CustomerRepo();
            _invoiceRepo = new InvoiceRepo();
            _roomRepo = new RoomRepo();
        }

        private void FormHotelManager_Load(object sender, EventArgs e)
        {
            HideControls();
            DateStartValues();
            LoadBookings();
        }

        private void buttonSearchAvailable_Click(object sender, EventArgs e)
        {
            LoadAvailableRooms();
            LoadAvailableCustomers();
            ShowNewBookingControls();
        }

        private void buttonGetBookings_Click(object sender, EventArgs e)
        {
            LoadBookings();
            HideControls();
            buttonEditBooking.Visible = true;
            buttonCancelBooking.Visible = true;
        }

        private void buttonGetCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomers();
            HideControls();
        }

        private void buttonGetInvoices_Click(object sender, EventArgs e)
        {
            LoadInvoices();
            HideControls();
        }

        private void buttonManageCustomer_Click(object sender, EventArgs e)
        {
            FormCustomerManager formCustomerManager = new();

            formCustomerManager.Show();
        }

        private void buttonCancelBooking_Click(object sender, EventArgs e)
        {
            CancelBooking();
        }
        private void buttonRemoveOverdue_Click(object sender, EventArgs e)
        {
            CheckPaymentStatus();
        }

        private void buttonEditBooking_Click(object sender, EventArgs e)
        {
            ShowEditControls();
            EditBooking();
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            SaveBookingChanges();
        }

        private void buttonInsertBooking_Click(object sender, EventArgs e)
        {
            CreateBooking();
        }


        ///
        /// CRUD
        ///

        private void LoadAvailableRooms()
        {
            int guestAmount = (int)numericUpDownGuestAmount.Value;
            DateTime checkIn = dateTimePickerCheckIn.Value;
            DateTime checkOut = dateTimePickerCheckOut.Value;

            dataGridViewResult.DataSource = _roomRepo.GetAvailableRooms(guestAmount, checkIn, checkOut);
            dataGridViewResult.Columns["RoomID"].Visible = false;
        }

        private void LoadAvailableCustomers()
        {
            DateTime checkIn = dateTimePickerCheckIn.Value;
            DateTime checkOut = dateTimePickerCheckOut.Value;

            listBoxCustomers.DataSource = _customerRepo.GetAvailableCustomers(checkIn, checkOut);
            listBoxCustomers.DisplayMember = "CustomerName";
            listBoxCustomers.ValueMember = "CustomerID";
        }

        private void LoadBookings()
        {
            dataGridViewResult.DataSource = _bookingRepo.GetAllBookings();
            dataGridViewResult.Columns["Customer"].Visible = false;
            dataGridViewResult.Columns["Room"].Visible = false;
            dataGridViewResult.Columns["Invoice"].Visible = false;

            buttonEditBooking.Visible = true;
            buttonCancelBooking.Visible = true;
        }

        private void LoadCustomers()
        {
            dataGridViewResult.DataSource = _customerRepo.GetAllCustomers();
            dataGridViewResult.Columns["CustomerID"].Visible = false;
        }

        private void LoadInvoices()
        {
            dataGridViewResult.DataSource = _invoiceRepo.GetAllInvoices();
            dataGridViewResult.Columns["InvoiceID"].Visible = false;
            dataGridViewResult.Columns["Booking"].Visible = false;
        }

        private void CreateBooking()
        {
            if (dataGridViewResult.SelectedRows.Count == 0)
            {
                MessageBox.Show("Välj ett rum att boka.");
                return;
            }

            if (listBoxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Välj en gäst att stå på bokningen.");
                return;
            }

            Booking booking = new();

            booking.BookingDate = DateTime.Now;
            booking.CheckInDate = dateTimePickerCheckIn.Value;
            booking.CheckOutDate = dateTimePickerCheckOut.Value;
            booking.IsCancelled = false;
            booking.CustomerID = (int)listBoxCustomers.SelectedValue;
            booking.RoomID = (int)dataGridViewResult.SelectedRows[0].Cells["RoomID"].Value;

            if (dateTimePickerCheckIn.Value >= dateTimePickerCheckOut.Value)
            {
                MessageBox.Show("Datum för incheckning måste vara innan datum för utcheckning.");
                return;
            }

            _bookingRepo.InsertBooking(booking);
            MessageBox.Show("Bokning skapad!");

            CreateInvoice(booking);
            LoadBookings();
        }

        private void CreateInvoice(Booking booking)
        {
            Room room = _roomRepo.GetRoom(booking.RoomID);

            if (room == null)
            {
                MessageBox.Show("Inget rum hittades.");
                return;
            }

            int numberOfNights = (booking.CheckOutDate - booking.CheckInDate).Days;

            if (numberOfNights <= 0)
            {
                MessageBox.Show("Ogiltiga vistelsedatum.");
                return;
            }

            int roomPrice = room.RoomType switch
            {
                "Enkelrum" => 200,
                "Dubbelrum" => 300,
                "Familjerum" => 400,
                _ => 0
            };

            if (roomPrice == 0)
            {
                MessageBox.Show("Rumstyp saknas.");
                return;
            }

            decimal totalAmount = numberOfNights * roomPrice;

            Invoice invoice = new();

            invoice.Amount = totalAmount;
            invoice.DueDate = booking.BookingDate.AddDays(10);
            invoice.IsPaid = false;
            invoice.BookingID = booking.BookingID;

            _invoiceRepo.InsertInvoice(invoice);
            MessageBox.Show("Faktura skapad!");
        }

        private void EditBooking()
        {
            if (dataGridViewResult.SelectedRows.Count == 0)
            {
                MessageBox.Show("Välj en bokning för att ändra uppgifter.");
                return;
            }

            DateTime selectedCheckIn = (DateTime)dataGridViewResult.SelectedRows[0].Cells["CheckInDate"].Value;
            DateTime selectedCheckOut = (DateTime)dataGridViewResult.SelectedRows[0].Cells["CheckOutDate"].Value;

            dateTimePickerNewCheckIn.MinDate = DateTimePicker.MinimumDateTime;
            dateTimePickerNewCheckIn.MaxDate = DateTimePicker.MaximumDateTime;
            dateTimePickerNewCheckOut.MinDate = DateTimePicker.MinimumDateTime;
            dateTimePickerNewCheckOut.MaxDate = DateTimePicker.MaximumDateTime;

            dateTimePickerNewCheckIn.MinDate = DateTime.Today;
            dateTimePickerNewCheckIn.MinDate = selectedCheckIn;
            dateTimePickerNewCheckIn.MaxDate = selectedCheckOut.AddDays(-1);
            dateTimePickerNewCheckOut.MinDate = selectedCheckIn.AddDays(1);
            dateTimePickerNewCheckOut.MaxDate = selectedCheckOut;

            dateTimePickerNewCheckIn.Value = selectedCheckIn;
            dateTimePickerNewCheckOut.Value = selectedCheckOut;
        }

        private void SaveBookingChanges()
        {
            if (dataGridViewResult.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ingen bokning vald.");
                return;
            }

            if (dateTimePickerNewCheckIn.Value >= dateTimePickerNewCheckOut.Value)
            {
                MessageBox.Show("Datum för incheckning måste vara innan datum för utcheckning.");
                return;
            }

            Booking booking = new();
            booking.BookingID = GetBookingID();
            booking.BookingDate = (DateTime)dataGridViewResult.SelectedRows[0].Cells["BookingDate"].Value;
            booking.CheckInDate = dateTimePickerNewCheckIn.Value;
            booking.CheckOutDate = dateTimePickerNewCheckOut.Value;
            booking.IsCancelled = (bool)dataGridViewResult.SelectedRows[0].Cells["IsCancelled"].Value;
            booking.CustomerID = (int)dataGridViewResult.SelectedRows[0].Cells["CustomerID"].Value;
            booking.RoomID = (int)dataGridViewResult.SelectedRows[0].Cells["RoomID"].Value;

            _bookingRepo.UpdateBooking(booking);
            MessageBox.Show("Bokningen har uppdaterats.");

            HideControls();
            LoadBookings();
        }

        private void CancelBooking()
        {
            if (dataGridViewResult.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ingen bokning vald.");
                return;
            }
            // IsCancelled = true 
            // Ta bort relaterad faktura (delete invoice)
            // Ta bort bokning från databasen (delete booking)

            int bookingId = GetBookingID();
            _invoiceRepo.DeleteInvoiceWithBookingID(bookingId);
            _bookingRepo.DeleteBooking(bookingId);
            MessageBox.Show("Bokning och medhörande faktura borttagna.");

            LoadBookings();
        }

        private void CheckPaymentStatus()
        {
            try
            {
                _invoiceRepo.DeleteOverdueInvoicesAndBookings();
                MessageBox.Show("Alla förfallna fakturor och bokningar borttagna.");

                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod {ex.Message}");
            }
        }

        ///
        /// ÖVRIGT
        /// 

        private int GetBookingID()
        {
            if (dataGridViewResult.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ingen bokning vald.");
                return -1;
            }

            int bookingID = (int)dataGridViewResult.SelectedRows[0].Cells["BookingID"].Value;
            return bookingID;
        }

        private void DateStartValues()
        {
            dateTimePickerCheckIn.MinDate = DateTime.Now.AddDays(11);
            dateTimePickerCheckOut.MinDate = DateTime.Now.AddDays(12);
        }

        private void HideControls()
        {
            labelChooseGuest.Visible = false;
            listBoxCustomers.Visible = false;
            buttonInsertBooking.Visible = false;
            buttonCancelBooking.Visible = false;
            buttonEditBooking.Visible = false;

            labelNewDates.Visible = false;
            labelNewCheckIn.Visible = false;
            labelNewCheckOut.Visible = false;
            dateTimePickerNewCheckIn.Visible = false;
            dateTimePickerNewCheckOut.Visible = false;
            buttonUpdateBooking.Visible = false;
        }

        private void ShowNewBookingControls()
        {
            buttonInsertBooking.Visible = true;
            labelChooseGuest.Visible = true;
            listBoxCustomers.Visible = true;
        }

        private void ShowEditControls()
        {
            labelNewDates.Visible = true;
            labelNewCheckIn.Visible = true;
            labelNewCheckOut.Visible = true;
            dateTimePickerNewCheckIn.Visible = true;
            dateTimePickerNewCheckOut.Visible = true;
            buttonUpdateBooking.Visible = true;
        }
    }
}
