namespace HotelBookingManager
{
    partial class FormHotelManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelGuestAmount = new Label();
            numericUpDownGuestAmount = new NumericUpDown();
            dateTimePickerCheckIn = new DateTimePicker();
            labelCheckIn = new Label();
            labelCheckOut = new Label();
            dateTimePickerCheckOut = new DateTimePicker();
            buttonSearchAvailable = new Button();
            dataGridViewResult = new DataGridView();
            labelSearchAvailableRooms = new Label();
            buttonGetCustomers = new Button();
            buttonGetInvoices = new Button();
            buttonGetBookings = new Button();
            buttonInsertBooking = new Button();
            labelChooseGuest = new Label();
            buttonManageCustomer = new Button();
            labelGetList = new Label();
            labelManage = new Label();
            listBoxCustomers = new ListBox();
            buttonEditBooking = new Button();
            labelNewCheckOut = new Label();
            dateTimePickerNewCheckOut = new DateTimePicker();
            labelNewCheckIn = new Label();
            dateTimePickerNewCheckIn = new DateTimePicker();
            labelNewDates = new Label();
            buttonUpdateBooking = new Button();
            buttonCancelBooking = new Button();
            buttonRemoveOverdue = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGuestAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // labelGuestAmount
            // 
            labelGuestAmount.AutoSize = true;
            labelGuestAmount.Location = new Point(813, 64);
            labelGuestAmount.Name = "labelGuestAmount";
            labelGuestAmount.Size = new Size(111, 25);
            labelGuestAmount.TabIndex = 0;
            labelGuestAmount.Text = "Antal gäster:";
            // 
            // numericUpDownGuestAmount
            // 
            numericUpDownGuestAmount.Location = new Point(930, 62);
            numericUpDownGuestAmount.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownGuestAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownGuestAmount.Name = "numericUpDownGuestAmount";
            numericUpDownGuestAmount.Size = new Size(54, 31);
            numericUpDownGuestAmount.TabIndex = 1;
            numericUpDownGuestAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(139, 59);
            dateTimePickerCheckIn.MinDate = new DateTime(2024, 11, 20, 0, 0, 0, 0);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(252, 31);
            dateTimePickerCheckIn.TabIndex = 2;
            dateTimePickerCheckIn.Value = new DateTime(2024, 11, 20, 0, 0, 0, 0);
            // 
            // labelCheckIn
            // 
            labelCheckIn.AutoSize = true;
            labelCheckIn.Location = new Point(23, 64);
            labelCheckIn.Name = "labelCheckIn";
            labelCheckIn.Size = new Size(110, 25);
            labelCheckIn.TabIndex = 3;
            labelCheckIn.Text = "Incheckning:";
            // 
            // labelCheckOut
            // 
            labelCheckOut.AutoSize = true;
            labelCheckOut.Location = new Point(418, 64);
            labelCheckOut.Name = "labelCheckOut";
            labelCheckOut.Size = new Size(113, 25);
            labelCheckOut.TabIndex = 5;
            labelCheckOut.Text = "Utcheckning:";
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(537, 59);
            dateTimePickerCheckOut.MinDate = new DateTime(2024, 11, 21, 0, 0, 0, 0);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(252, 31);
            dateTimePickerCheckOut.TabIndex = 4;
            dateTimePickerCheckOut.Value = new DateTime(2024, 11, 21, 0, 0, 0, 0);
            // 
            // buttonSearchAvailable
            // 
            buttonSearchAvailable.Font = new Font("Segoe UI", 9F);
            buttonSearchAvailable.Location = new Point(1011, 59);
            buttonSearchAvailable.Name = "buttonSearchAvailable";
            buttonSearchAvailable.Size = new Size(136, 34);
            buttonSearchAvailable.TabIndex = 6;
            buttonSearchAvailable.Text = "Sök ledigt";
            buttonSearchAvailable.UseVisualStyleBackColor = true;
            buttonSearchAvailable.Click += buttonSearchAvailable_Click;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(23, 190);
            dataGridViewResult.MultiSelect = false;
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersWidth = 62;
            dataGridViewResult.Size = new Size(1124, 316);
            dataGridViewResult.TabIndex = 7;
            // 
            // labelSearchAvailableRooms
            // 
            labelSearchAvailableRooms.AutoSize = true;
            labelSearchAvailableRooms.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearchAvailableRooms.Location = new Point(23, 18);
            labelSearchAvailableRooms.Name = "labelSearchAvailableRooms";
            labelSearchAvailableRooms.Size = new Size(217, 30);
            labelSearchAvailableRooms.TabIndex = 8;
            labelSearchAvailableRooms.Text = "Sök efter lediga rum";
            // 
            // buttonGetCustomers
            // 
            buttonGetCustomers.Location = new Point(288, 150);
            buttonGetCustomers.Name = "buttonGetCustomers";
            buttonGetCustomers.Size = new Size(134, 34);
            buttonGetCustomers.TabIndex = 9;
            buttonGetCustomers.Text = "Kunder";
            buttonGetCustomers.UseVisualStyleBackColor = true;
            buttonGetCustomers.Click += buttonGetCustomers_Click;
            // 
            // buttonGetInvoices
            // 
            buttonGetInvoices.Location = new Point(426, 150);
            buttonGetInvoices.Name = "buttonGetInvoices";
            buttonGetInvoices.Size = new Size(136, 34);
            buttonGetInvoices.TabIndex = 10;
            buttonGetInvoices.Text = "Fakturor";
            buttonGetInvoices.UseVisualStyleBackColor = true;
            buttonGetInvoices.Click += buttonGetInvoices_Click;
            // 
            // buttonGetBookings
            // 
            buttonGetBookings.Location = new Point(148, 150);
            buttonGetBookings.Name = "buttonGetBookings";
            buttonGetBookings.Size = new Size(134, 34);
            buttonGetBookings.TabIndex = 11;
            buttonGetBookings.Text = "Bokningar";
            buttonGetBookings.UseVisualStyleBackColor = true;
            buttonGetBookings.Click += buttonGetBookings_Click;
            // 
            // buttonInsertBooking
            // 
            buttonInsertBooking.Location = new Point(1004, 523);
            buttonInsertBooking.Name = "buttonInsertBooking";
            buttonInsertBooking.Size = new Size(143, 34);
            buttonInsertBooking.TabIndex = 13;
            buttonInsertBooking.Text = "Boka rum";
            buttonInsertBooking.UseVisualStyleBackColor = true;
            buttonInsertBooking.Click += buttonInsertBooking_Click;
            // 
            // labelChooseGuest
            // 
            labelChooseGuest.AutoSize = true;
            labelChooseGuest.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChooseGuest.Location = new Point(23, 523);
            labelChooseGuest.Name = "labelChooseGuest";
            labelChooseGuest.Size = new Size(207, 28);
            labelChooseGuest.TabIndex = 15;
            labelChooseGuest.Text = "Välj gäst för bokning:";
            // 
            // buttonManageCustomer
            // 
            buttonManageCustomer.Location = new Point(1011, 150);
            buttonManageCustomer.Name = "buttonManageCustomer";
            buttonManageCustomer.Size = new Size(136, 34);
            buttonManageCustomer.TabIndex = 16;
            buttonManageCustomer.Text = "Kund";
            buttonManageCustomer.UseVisualStyleBackColor = true;
            buttonManageCustomer.Click += buttonManageCustomer_Click;
            // 
            // labelGetList
            // 
            labelGetList.AutoSize = true;
            labelGetList.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGetList.Location = new Point(23, 152);
            labelGetList.Name = "labelGetList";
            labelGetList.Size = new Size(119, 28);
            labelGetList.TabIndex = 17;
            labelGetList.Text = "Hämta lista:";
            // 
            // labelManage
            // 
            labelManage.AutoSize = true;
            labelManage.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManage.Location = new Point(909, 152);
            labelManage.Name = "labelManage";
            labelManage.Size = new Size(89, 28);
            labelManage.TabIndex = 19;
            labelManage.Text = "Hantera:";
            // 
            // listBoxCustomers
            // 
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.ItemHeight = 25;
            listBoxCustomers.Location = new Point(23, 563);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(399, 204);
            listBoxCustomers.TabIndex = 20;
            // 
            // buttonEditBooking
            // 
            buttonEditBooking.Location = new Point(855, 523);
            buttonEditBooking.Name = "buttonEditBooking";
            buttonEditBooking.Size = new Size(143, 34);
            buttonEditBooking.TabIndex = 21;
            buttonEditBooking.Text = "Ändra bokning";
            buttonEditBooking.UseVisualStyleBackColor = true;
            buttonEditBooking.Click += buttonEditBooking_Click;
            // 
            // labelNewCheckOut
            // 
            labelNewCheckOut.AutoSize = true;
            labelNewCheckOut.Location = new Point(449, 652);
            labelNewCheckOut.Name = "labelNewCheckOut";
            labelNewCheckOut.Size = new Size(113, 25);
            labelNewCheckOut.TabIndex = 25;
            labelNewCheckOut.Text = "Utcheckning:";
            // 
            // dateTimePickerNewCheckOut
            // 
            dateTimePickerNewCheckOut.Location = new Point(568, 647);
            dateTimePickerNewCheckOut.MinDate = new DateTime(2024, 11, 21, 0, 0, 0, 0);
            dateTimePickerNewCheckOut.Name = "dateTimePickerNewCheckOut";
            dateTimePickerNewCheckOut.Size = new Size(252, 31);
            dateTimePickerNewCheckOut.TabIndex = 24;
            dateTimePickerNewCheckOut.Value = new DateTime(2024, 11, 21, 0, 0, 0, 0);
            // 
            // labelNewCheckIn
            // 
            labelNewCheckIn.AutoSize = true;
            labelNewCheckIn.Location = new Point(449, 605);
            labelNewCheckIn.Name = "labelNewCheckIn";
            labelNewCheckIn.Size = new Size(110, 25);
            labelNewCheckIn.TabIndex = 23;
            labelNewCheckIn.Text = "Incheckning:";
            // 
            // dateTimePickerNewCheckIn
            // 
            dateTimePickerNewCheckIn.Location = new Point(568, 600);
            dateTimePickerNewCheckIn.MinDate = new DateTime(2024, 11, 20, 0, 0, 0, 0);
            dateTimePickerNewCheckIn.Name = "dateTimePickerNewCheckIn";
            dateTimePickerNewCheckIn.Size = new Size(252, 31);
            dateTimePickerNewCheckIn.TabIndex = 22;
            dateTimePickerNewCheckIn.Value = new DateTime(2024, 11, 20, 0, 0, 0, 0);
            // 
            // labelNewDates
            // 
            labelNewDates.AutoSize = true;
            labelNewDates.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewDates.Location = new Point(449, 554);
            labelNewDates.Name = "labelNewDates";
            labelNewDates.Size = new Size(168, 28);
            labelNewDates.TabIndex = 26;
            labelNewDates.Text = "Ange nya datum:";
            // 
            // buttonUpdateBooking
            // 
            buttonUpdateBooking.Location = new Point(677, 700);
            buttonUpdateBooking.Name = "buttonUpdateBooking";
            buttonUpdateBooking.Size = new Size(143, 34);
            buttonUpdateBooking.TabIndex = 27;
            buttonUpdateBooking.Text = "Uppdatera";
            buttonUpdateBooking.UseVisualStyleBackColor = true;
            buttonUpdateBooking.Visible = false;
            buttonUpdateBooking.Click += buttonUpdateBooking_Click;
            // 
            // buttonCancelBooking
            // 
            buttonCancelBooking.Location = new Point(706, 523);
            buttonCancelBooking.Name = "buttonCancelBooking";
            buttonCancelBooking.Size = new Size(143, 34);
            buttonCancelBooking.TabIndex = 28;
            buttonCancelBooking.Text = "Avboka";
            buttonCancelBooking.UseVisualStyleBackColor = true;
            buttonCancelBooking.Click += buttonCancelBooking_Click;
            // 
            // buttonRemoveOverdue
            // 
            buttonRemoveOverdue.Location = new Point(686, 152);
            buttonRemoveOverdue.Name = "buttonRemoveOverdue";
            buttonRemoveOverdue.Size = new Size(163, 34);
            buttonRemoveOverdue.TabIndex = 29;
            buttonRemoveOverdue.Text = "Avboka förfallna";
            buttonRemoveOverdue.UseVisualStyleBackColor = true;
            buttonRemoveOverdue.Click += buttonRemoveOverdue_Click;
            // 
            // FormHotelManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 796);
            Controls.Add(buttonRemoveOverdue);
            Controls.Add(buttonCancelBooking);
            Controls.Add(buttonUpdateBooking);
            Controls.Add(labelNewDates);
            Controls.Add(labelNewCheckOut);
            Controls.Add(dateTimePickerNewCheckOut);
            Controls.Add(labelNewCheckIn);
            Controls.Add(dateTimePickerNewCheckIn);
            Controls.Add(buttonEditBooking);
            Controls.Add(listBoxCustomers);
            Controls.Add(labelManage);
            Controls.Add(labelGetList);
            Controls.Add(buttonManageCustomer);
            Controls.Add(labelChooseGuest);
            Controls.Add(buttonInsertBooking);
            Controls.Add(buttonGetBookings);
            Controls.Add(buttonGetInvoices);
            Controls.Add(buttonGetCustomers);
            Controls.Add(labelSearchAvailableRooms);
            Controls.Add(dataGridViewResult);
            Controls.Add(buttonSearchAvailable);
            Controls.Add(labelCheckOut);
            Controls.Add(dateTimePickerCheckOut);
            Controls.Add(labelCheckIn);
            Controls.Add(dateTimePickerCheckIn);
            Controls.Add(numericUpDownGuestAmount);
            Controls.Add(labelGuestAmount);
            Name = "FormHotelManager";
            Text = "Hantera bokningar";
            Load += FormHotelManager_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownGuestAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGuestAmount;
        private NumericUpDown numericUpDownGuestAmount;
        private DateTimePicker dateTimePickerCheckIn;
        private Label labelCheckIn;
        private Label labelCheckOut;
        private DateTimePicker dateTimePickerCheckOut;
        private Button buttonSearchAvailable;
        private DataGridView dataGridViewResult;
        private Label labelSearchAvailableRooms;
        private Button buttonGetCustomers;
        private Button buttonGetInvoices;
        private Button buttonGetBookings;
        private Button buttonInsertBooking;
        private Label labelChooseGuest;
        private Button buttonManageCustomer;
        private Label labelGetList;
        private Label labelManage;
        private ListBox listBoxCustomers;
        private Button buttonEditBooking;
        private Label labelNewCheckOut;
        private DateTimePicker dateTimePickerNewCheckOut;
        private Label labelNewCheckIn;
        private DateTimePicker dateTimePickerNewCheckIn;
        private Label labelNewDates;
        private Button buttonUpdateBooking;
        private Button buttonCancelBooking;
        private Button buttonRemoveOverdue;
    }
}
