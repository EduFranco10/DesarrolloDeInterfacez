namespace AgendaContactsMySQL.views
{
    partial class UpdateContact
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
            label2 = new Label();
            label3 = new Label();
            textNewName = new TextBox();
            textPhoneActual = new TextBox();
            btnUpdateContact = new Button();
            btnClean = new Button();
            label4 = new Label();
            textNewPhone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 40);
            label1.Name = "label1";
            label1.Size = new Size(479, 62);
            label1.TabIndex = 0;
            label1.Text = "Actualizar Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(146, 137);
            label2.Name = "label2";
            label2.Size = new Size(188, 35);
            label2.TabIndex = 1;
            label2.Text = "Nombre Nuevo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(146, 390);
            label3.Name = "label3";
            label3.Size = new Size(186, 35);
            label3.TabIndex = 2;
            label3.Text = "Télefono Actual";
            // 
            // textNewName
            // 
            textNewName.Location = new Point(150, 173);
            textNewName.Name = "textNewName";
            textNewName.Size = new Size(508, 27);
            textNewName.TabIndex = 3;
            // 
            // textPhoneActual
            // 
            textPhoneActual.Location = new Point(150, 426);
            textPhoneActual.Name = "textPhoneActual";
            textPhoneActual.Size = new Size(508, 27);
            textPhoneActual.TabIndex = 4;
            // 
            // btnUpdateContact
            // 
            btnUpdateContact.BackColor = SystemColors.ActiveCaption;
            btnUpdateContact.Font = new Font("Segoe UI", 13F);
            btnUpdateContact.Location = new Point(150, 479);
            btnUpdateContact.Name = "btnUpdateContact";
            btnUpdateContact.Size = new Size(129, 43);
            btnUpdateContact.TabIndex = 5;
            btnUpdateContact.Text = "Actualizar";
            btnUpdateContact.UseVisualStyleBackColor = false;
            btnUpdateContact.Click += btnUpdateContact_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.IndianRed;
            btnClean.Font = new Font("Segoe UI", 13F);
            btnClean.Location = new Point(326, 479);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(114, 43);
            btnClean.TabIndex = 6;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(146, 261);
            label4.Name = "label4";
            label4.Size = new Size(190, 35);
            label4.TabIndex = 7;
            label4.Text = "Télefono Nuevo";
            // 
            // textNewPhone
            // 
            textNewPhone.Location = new Point(150, 297);
            textNewPhone.Name = "textNewPhone";
            textNewPhone.Size = new Size(508, 27);
            textNewPhone.TabIndex = 8;
            // 
            // UpdateContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 652);
            Controls.Add(textNewPhone);
            Controls.Add(label4);
            Controls.Add(btnClean);
            Controls.Add(btnUpdateContact);
            Controls.Add(textPhoneActual);
            Controls.Add(textNewName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateContact";
            Text = "UpdateContact";
            Load += UpdateContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textNewName;
        private TextBox textPhoneActual;
        private Button btnUpdateContact;
        private Button btnClean;
        private Label label4;
        private TextBox textNewPhone;
    }
}