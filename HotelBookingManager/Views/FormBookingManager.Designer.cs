namespace HotelBookingManager.Views
{
    partial class FormBookingManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dateTimePickerNewCheckIn = new DateTimePicker();
            dateTimePickerNewCheckOut = new DateTimePicker();
            labelNewCheckOut = new Label();
            labelNewCheckIn = new Label();
            labelNewDates = new Label();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            listBoxBookings = new ListBox();
            labelOldDates = new Label();
            labelOldCheckIn = new Label();
            labelOldCheckOut = new Label();
            dateTimePickerOldCheckOut = new DateTimePicker();
            dateTimePickerOldCheckIn = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 1;
            label1.Text = "Välj bokning att ändra:";
            // 
            // dateTimePickerNewCheckIn
            // 
            dateTimePickerNewCheckIn.Location = new Point(505, 303);
            dateTimePickerNewCheckIn.MinDate = new DateTime(2024, 11, 14, 0, 0, 0, 0);
            dateTimePickerNewCheckIn.Name = "dateTimePickerNewCheckIn";
            dateTimePickerNewCheckIn.Size = new Size(252, 31);
            dateTimePickerNewCheckIn.TabIndex = 3;
            dateTimePickerNewCheckIn.Value = new DateTime(2024, 11, 14, 0, 0, 0, 0);
            // 
            // dateTimePickerNewCheckOut
            // 
            dateTimePickerNewCheckOut.Location = new Point(505, 357);
            dateTimePickerNewCheckOut.MinDate = new DateTime(2024, 11, 14, 0, 0, 0, 0);
            dateTimePickerNewCheckOut.Name = "dateTimePickerNewCheckOut";
            dateTimePickerNewCheckOut.Size = new Size(252, 31);
            dateTimePickerNewCheckOut.TabIndex = 5;
            dateTimePickerNewCheckOut.Value = new DateTime(2024, 11, 14, 0, 0, 0, 0);
            // 
            // labelNewCheckOut
            // 
            labelNewCheckOut.AutoSize = true;
            labelNewCheckOut.Location = new Point(386, 362);
            labelNewCheckOut.Name = "labelNewCheckOut";
            labelNewCheckOut.Size = new Size(113, 25);
            labelNewCheckOut.TabIndex = 7;
            labelNewCheckOut.Text = "Utcheckning:";
            // 
            // labelNewCheckIn
            // 
            labelNewCheckIn.AutoSize = true;
            labelNewCheckIn.Location = new Point(386, 308);
            labelNewCheckIn.Name = "labelNewCheckIn";
            labelNewCheckIn.Size = new Size(110, 25);
            labelNewCheckIn.TabIndex = 6;
            labelNewCheckIn.Text = "Incheckning:";
            // 
            // labelNewDates
            // 
            labelNewDates.AutoSize = true;
            labelNewDates.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewDates.Location = new Point(386, 255);
            labelNewDates.Name = "labelNewDates";
            labelNewDates.Size = new Size(168, 28);
            labelNewDates.TabIndex = 8;
            labelNewDates.Text = "Ange nya datum:";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(228, 299);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Ta bort";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(645, 430);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(112, 34);
            buttonUpdate.TabIndex = 10;
            buttonUpdate.Text = "Uppdatera";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // listBoxBookings
            // 
            listBoxBookings.FormattingEnabled = true;
            listBoxBookings.ItemHeight = 25;
            listBoxBookings.Location = new Point(25, 54);
            listBoxBookings.Name = "listBoxBookings";
            listBoxBookings.Size = new Size(315, 229);
            listBoxBookings.TabIndex = 11;
            // 
            // labelOldDates
            // 
            labelOldDates.AutoSize = true;
            labelOldDates.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOldDates.Location = new Point(386, 23);
            labelOldDates.Name = "labelOldDates";
            labelOldDates.Size = new Size(181, 28);
            labelOldDates.TabIndex = 12;
            labelOldDates.Text = "Nuvarande datum:";
            // 
            // labelOldCheckIn
            // 
            labelOldCheckIn.AutoSize = true;
            labelOldCheckIn.Location = new Point(386, 76);
            labelOldCheckIn.Name = "labelOldCheckIn";
            labelOldCheckIn.Size = new Size(110, 25);
            labelOldCheckIn.TabIndex = 13;
            labelOldCheckIn.Text = "Incheckning:";
            // 
            // labelOldCheckOut
            // 
            labelOldCheckOut.AutoSize = true;
            labelOldCheckOut.Location = new Point(386, 130);
            labelOldCheckOut.Name = "labelOldCheckOut";
            labelOldCheckOut.Size = new Size(113, 25);
            labelOldCheckOut.TabIndex = 14;
            labelOldCheckOut.Text = "Utcheckning:";
            // 
            // dateTimePickerOldCheckOut
            // 
            dateTimePickerOldCheckOut.Location = new Point(505, 125);
            dateTimePickerOldCheckOut.MinDate = new DateTime(2024, 11, 14, 0, 0, 0, 0);
            dateTimePickerOldCheckOut.Name = "dateTimePickerOldCheckOut";
            dateTimePickerOldCheckOut.Size = new Size(252, 31);
            dateTimePickerOldCheckOut.TabIndex = 16;
            dateTimePickerOldCheckOut.Value = new DateTime(2024, 11, 14, 0, 0, 0, 0);
            // 
            // dateTimePickerOldCheckIn
            // 
            dateTimePickerOldCheckIn.Location = new Point(505, 71);
            dateTimePickerOldCheckIn.MinDate = new DateTime(2024, 11, 14, 0, 0, 0, 0);
            dateTimePickerOldCheckIn.Name = "dateTimePickerOldCheckIn";
            dateTimePickerOldCheckIn.Size = new Size(252, 31);
            dateTimePickerOldCheckIn.TabIndex = 15;
            dateTimePickerOldCheckIn.Value = new DateTime(2024, 11, 14, 0, 0, 0, 0);
            // 
            // FormBookingManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 611);
            Controls.Add(dateTimePickerOldCheckOut);
            Controls.Add(dateTimePickerOldCheckIn);
            Controls.Add(labelOldCheckOut);
            Controls.Add(labelOldCheckIn);
            Controls.Add(labelOldDates);
            Controls.Add(listBoxBookings);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(labelNewDates);
            Controls.Add(labelNewCheckOut);
            Controls.Add(labelNewCheckIn);
            Controls.Add(dateTimePickerNewCheckOut);
            Controls.Add(dateTimePickerNewCheckIn);
            Controls.Add(label1);
            Name = "FormBookingManager";
            Text = "Hantera bokningar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DateTimePicker dateTimePickerNewCheckIn;
        private DateTimePicker dateTimePickerNewCheckOut;
        private Label labelNewCheckOut;
        private Label labelNewCheckIn;
        private Label labelNewDates;
        private Button buttonDelete;
        private Button buttonUpdate;
        private ListBox listBoxBookings;
        private Label labelOldDates;
        private Label labelOldCheckIn;
        private Label labelOldCheckOut;
        private DateTimePicker dateTimePickerOldCheckOut;
        private DateTimePicker dateTimePickerOldCheckIn;
    }
}