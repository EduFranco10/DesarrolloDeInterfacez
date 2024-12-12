namespace AgendaContactsMySQL
{
    partial class AddContact
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
            textName = new TextBox();
            btnAddContact = new Button();
            label3 = new Label();
            label2 = new Label();
            textPhone = new TextBox();
            btnClean = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 24);
            label1.Name = "label1";
            label1.Size = new Size(435, 62);
            label1.TabIndex = 0;
            label1.Text = "Agregar Contacto";
            // 
            // textName
            // 
            textName.Location = new Point(96, 157);
            textName.Name = "textName";
            textName.Size = new Size(461, 27);
            textName.TabIndex = 2;
            // 
            // btnAddContact
            // 
            btnAddContact.BackColor = SystemColors.ActiveCaption;
            btnAddContact.Font = new Font("Segoe UI", 13F);
            btnAddContact.Location = new Point(96, 341);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(139, 42);
            btnAddContact.TabIndex = 3;
            btnAddContact.Text = "Agregar";
            btnAddContact.UseVisualStyleBackColor = false;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(96, 119);
            label3.Name = "label3";
            label3.Size = new Size(108, 35);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(96, 242);
            label2.Name = "label2";
            label2.Size = new Size(110, 35);
            label2.TabIndex = 5;
            label2.Text = "Télefono";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(96, 278);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(461, 27);
            textPhone.TabIndex = 6;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.IndianRed;
            btnClean.Font = new Font("Segoe UI", 13F);
            btnClean.Location = new Point(281, 341);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(140, 42);
            btnClean.TabIndex = 7;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // AddContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(649, 474);
            Controls.Add(btnClean);
            Controls.Add(textPhone);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnAddContact);
            Controls.Add(textName);
            Controls.Add(label1);
            Name = "AddContact";
            Text = "AddContact";
            Load += AddContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private Button btnAddContact;
        private Label label3;
        private Label label2;
        private TextBox textPhone;
        private Button btnClean;
    }
}