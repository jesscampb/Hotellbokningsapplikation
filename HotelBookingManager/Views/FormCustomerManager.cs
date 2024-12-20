using HotelBookingManager.Repository.Entities;
using HotelBookingManager.Repository.Repos;

namespace HotelBookingManager.Views
{
    public partial class FormCustomerManager : Form
    {
        private readonly BookingRepo _bookingRepo;
        private readonly CustomerRepo _customerRepo;

        public FormCustomerManager()
        {
            InitializeComponent();

            _bookingRepo = new BookingRepo();
            _customerRepo = new CustomerRepo();

            LoadCustomers();
        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            ClearFields();
            listBoxCustomers.SelectedIndex = -1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedCustomer();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            NewCustomer();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SaveCustomerChanges();
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex != -1)
            {
                int id = GetCustomerID();
                Customer customer = _customerRepo.GetCustomer(id);

                textBoxName.Text = customer.CustomerName;
                textBoxEmail.Text = customer.Email;
            }
            else
            {
                ClearFields();
            }
        }

        ///
        /// CRUD
        /// 

        private void LoadCustomers()
        {
            listBoxCustomers.DisplayMember = "CustomerName";
            listBoxCustomers.ValueMember = "CustomerID";
            listBoxCustomers.DataSource = _customerRepo.GetAllCustomers();
        }

        private void NewCustomer()
        {
            if (!AreFieldsValid()) return;

            Customer customer = new();

            customer.CustomerName = textBoxName.Text;
            customer.Email = textBoxEmail.Text;

            _customerRepo.InsertCustomer(customer);

            MessageBox.Show("Kund skapad.");

            ClearFields();
            LoadCustomers();
        }

        private void SaveCustomerChanges()
        {
            if (listBoxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Du måste välja en kund.");
                return;
            }

            if (!AreFieldsValid()) return;

            Customer customer = new();
            customer.CustomerID = GetCustomerID();
            customer.CustomerName = textBoxName.Text;
            customer.Email = textBoxEmail.Text;

            _customerRepo.UpdateCustomer(customer);
            MessageBox.Show("Ändringar sparade.");

            ClearFields();
            LoadCustomers();
        }

        private void DeleteSelectedCustomer()
        {
            int id = GetCustomerID();

            if (id == -1)
            {
                MessageBox.Show("Du måste välja en kund.");
                return;
            }

            if (_bookingRepo.HasBooking(id))
            {
                MessageBox.Show("Kunden har en aktuell bokning och kan ej tas bort.");
            }
            else
            {
                var confirmDeletion = MessageBox.Show("Är du säker på att du vill ta bort kunden?",
                    "Bekräfta", MessageBoxButtons.YesNo);
                if (confirmDeletion == DialogResult.Yes)
                {
                    _customerRepo.DeleteCustomer(id);
                    MessageBox.Show("Kund borttagen.");
                    LoadCustomers();
                }
            }
        }

        ///
        /// ÖVRIGT
        ///

        private int GetCustomerID()
        {
            if (listBoxCustomers.SelectedValue == null || (int)listBoxCustomers.SelectedValue < 1)
            {
                return -1;
            }

            return (int)listBoxCustomers.SelectedValue;
        }

        private void ClearFields()
        {
            textBoxName.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
        }

        private bool AreFieldsValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Alla fält måste vara ifyllda.");
                return false;
            }
            return true;
        }
    }
}
