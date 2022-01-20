
namespace CRMApplications
{
    partial class AddClientsForm
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
            this.clientName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.clientSurname = new System.Windows.Forms.Label();
            this.clientLastname = new System.Windows.Forms.Label();
            this.clientEmail = new System.Windows.Forms.Label();
            this.clientPhone = new System.Windows.Forms.Label();
            this.clientPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(134, 23);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(180, 20);
            this.clientName.TabIndex = 0;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(134, 195);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(180, 20);
            this.Email.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(134, 134);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(180, 20);
            this.LastName.TabIndex = 3;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(134, 77);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(180, 20);
            this.Surname.TabIndex = 4;
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(42, 301);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(86, 35);
            this.Create.TabIndex = 5;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(29, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // clientSurname
            // 
            this.clientSurname.AutoSize = true;
            this.clientSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientSurname.Location = new System.Drawing.Point(30, 80);
            this.clientSurname.Name = "clientSurname";
            this.clientSurname.Size = new System.Drawing.Size(65, 17);
            this.clientSurname.TabIndex = 7;
            this.clientSurname.Text = "Surname";
            // 
            // clientLastname
            // 
            this.clientLastname.AutoSize = true;
            this.clientLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLastname.Location = new System.Drawing.Point(30, 137);
            this.clientLastname.Name = "clientLastname";
            this.clientLastname.Size = new System.Drawing.Size(70, 17);
            this.clientLastname.TabIndex = 8;
            this.clientLastname.Text = "Lastname";
            // 
            // clientEmail
            // 
            this.clientEmail.AutoSize = true;
            this.clientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientEmail.Location = new System.Drawing.Point(29, 198);
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.Size = new System.Drawing.Size(42, 17);
            this.clientEmail.TabIndex = 9;
            this.clientEmail.Text = "Email";
            // 
            // clientPhone
            // 
            this.clientPhone.AutoSize = true;
            this.clientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientPhone.Location = new System.Drawing.Point(29, 255);
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.Size = new System.Drawing.Size(99, 17);
            this.clientPhone.TabIndex = 10;
            this.clientPhone.Text = "PhoneNumber";
            // 
            // clientPhoneNumber
            // 
            this.clientPhoneNumber.Location = new System.Drawing.Point(134, 252);
            this.clientPhoneNumber.Name = "clientPhoneNumber";
            this.clientPhoneNumber.Size = new System.Drawing.Size(180, 20);
            this.clientPhoneNumber.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(177, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientPhoneNumber);
            this.Controls.Add(this.clientPhone);
            this.Controls.Add(this.clientEmail);
            this.Controls.Add(this.clientLastname);
            this.Controls.Add(this.clientSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.clientName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClientsForm";
            this.Text = "AddClientsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label clientSurname;
        private System.Windows.Forms.Label clientLastname;
        private System.Windows.Forms.Label clientEmail;
        private System.Windows.Forms.Label clientPhone;
        private System.Windows.Forms.MaskedTextBox clientPhoneNumber;
        private System.Windows.Forms.Button button1;
    }
}