
namespace CRMApplications
{
    partial class AddProductsForm
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
            this.productName = new System.Windows.Forms.TextBox();
            this.productDescription = new System.Windows.Forms.TextBox();
            this.productCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.MaskedTextBox();
            this.productNumber = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxProductExistence = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(135, 34);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(196, 20);
            this.productName.TabIndex = 0;
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(135, 80);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(196, 20);
            this.productDescription.TabIndex = 3;
            // 
            // productCreate
            // 
            this.productCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCreate.Location = new System.Drawing.Point(58, 300);
            this.productCreate.Name = "productCreate";
            this.productCreate.Size = new System.Drawing.Size(93, 33);
            this.productCreate.TabIndex = 5;
            this.productCreate.Text = "Create";
            this.productCreate.UseVisualStyleBackColor = true;
            this.productCreate.Click += new System.EventHandler(this.productCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Existence";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(135, 126);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(196, 20);
            this.productPrice.TabIndex = 11;
            // 
            // productNumber
            // 
            this.productNumber.Location = new System.Drawing.Point(136, 174);
            this.productNumber.Name = "productNumber";
            this.productNumber.Size = new System.Drawing.Size(195, 20);
            this.productNumber.TabIndex = 12;
            // 
            // checkBoxProductExistence
            // 
            this.checkBoxProductExistence.AutoSize = true;
            this.checkBoxProductExistence.Location = new System.Drawing.Point(136, 220);
            this.checkBoxProductExistence.Name = "checkBoxProductExistence";
            this.checkBoxProductExistence.Size = new System.Drawing.Size(15, 14);
            this.checkBoxProductExistence.TabIndex = 13;
            this.checkBoxProductExistence.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(193, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxProductExistence);
            this.Controls.Add(this.productNumber);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productCreate);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.productName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductsForm";
            this.Text = "AddProductsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productDescription;
        private System.Windows.Forms.Button productCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox productPrice;
        private System.Windows.Forms.MaskedTextBox productNumber;
        private System.Windows.Forms.CheckBox checkBoxProductExistence;
        private System.Windows.Forms.Button button1;
    }
}