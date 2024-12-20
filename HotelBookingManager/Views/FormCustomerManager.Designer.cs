namespace HotelBookingManager.Views
{
    partial class FormCustomerManager
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
            buttonNewCustomer = new Button();
            listBoxCustomers = new ListBox();
            labelName = new Label();
            labelEmail = new Label();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            buttonInsert = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // buttonNewCustomer
            // 
            buttonNewCustomer.Location = new Point(21, 30);
            buttonNewCustomer.Name = "buttonNewCustomer";
            buttonNewCustomer.Size = new Size(119, 37);
            buttonNewCustomer.TabIndex = 0;
            buttonNewCustomer.Text = "Ny kund";
            buttonNewCustomer.UseVisualStyleBackColor = true;
            buttonNewCustomer.Click += buttonNewCustomer_Click;
            // 
            // listBoxCustomers
            // 
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.ItemHeight = 25;
            listBoxCustomers.Location = new Point(21, 73);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(310, 254);
            listBoxCustomers.TabIndex = 2;
            listBoxCustomers.SelectedIndexChanged += listBoxCustomers_SelectedIndexChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(395, 73);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 25);
            labelName.TabIndex = 3;
            labelName.Text = "Namn:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(395, 188);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(395, 101);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(319, 31);
            textBoxName.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(395, 216);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(319, 31);
            textBoxEmail.TabIndex = 6;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(484, 293);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(112, 34);
            buttonInsert.TabIndex = 7;
            buttonInsert.Text = "Lägg till";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(602, 293);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(112, 34);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "Uppdatera";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(219, 333);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Ta bort";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormCustomerManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 386);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonInsert);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(listBoxCustomers);
            Controls.Add(buttonNewCustomer);
            Name = "FormCustomerManager";
            Text = "Hantera kunder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNewCustomer;
        private ListBox listBoxCustomers;
        private Label labelName;
        private Label labelEmail;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Button buttonInsert;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}