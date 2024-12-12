namespace AgendaContactsMySQL.views
{
    partial class DeleteContact
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
            textName = new TextBox();
            textPhone = new TextBox();
            btnDeleteContact = new Button();
            btnClean = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 31);
            label1.Name = "label1";
            label1.Size = new Size(436, 62);
            label1.TabIndex = 0;
            label1.Text = "Eliminar Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(81, 125);
            label2.Name = "label2";
            label2.Size = new Size(108, 35);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(81, 226);
            label3.Name = "label3";
            label3.Size = new Size(110, 35);
            label3.TabIndex = 2;
            label3.Text = "Télefono";
            // 
            // textName
            // 
            textName.BackColor = SystemColors.Window;
            textName.Location = new Point(81, 161);
            textName.Name = "textName";
            textName.Size = new Size(500, 27);
            textName.TabIndex = 3;
            // 
            // textPhone
            // 
            textPhone.BackColor = SystemColors.Window;
            textPhone.Location = new Point(81, 262);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(500, 27);
            textPhone.TabIndex = 4;
            // 
            // btnDeleteContact
            // 
            btnDeleteContact.BackColor = SystemColors.ActiveCaption;
            btnDeleteContact.Font = new Font("Segoe UI", 13F);
            btnDeleteContact.Location = new Point(82, 322);
            btnDeleteContact.Name = "btnDeleteContact";
            btnDeleteContact.Size = new Size(109, 40);
            btnDeleteContact.TabIndex = 5;
            btnDeleteContact.Text = "Eliminar";
            btnDeleteContact.UseVisualStyleBackColor = false;
            btnDeleteContact.Click += btnDeleteContact_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.IndianRed;
            btnClean.Font = new Font("Segoe UI", 13F);
            btnClean.Location = new Point(229, 322);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(109, 40);
            btnClean.TabIndex = 6;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // DeleteContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(642, 442);
            Controls.Add(btnClean);
            Controls.Add(btnDeleteContact);
            Controls.Add(textPhone);
            Controls.Add(textName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteContact";
            Text = "DeleteContact";
            Load += DeleteContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textName;
        private TextBox textPhone;
        private Button btnDeleteContact;
        private Button btnClean;
    }
}