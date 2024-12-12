namespace AgendaContactsMySQL
{
    partial class Form1
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
            label1 = new Label();
            btnWindowAddContact = new Button();
            btnWindowSearchContact = new Button();
            btnWindowUpdateContact = new Button();
            btnWindowDeleteContact = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI Black", 44F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(82, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(967, 116);
            label1.TabIndex = 0;
            label1.Text = "Agenda de Contactos";
            label1.Click += label1_Click;
            // 
            // btnWindowAddContact
            // 
            btnWindowAddContact.BackColor = Color.RoyalBlue;
            btnWindowAddContact.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWindowAddContact.ForeColor = Color.White;
            btnWindowAddContact.Location = new Point(208, 410);
            btnWindowAddContact.Margin = new Padding(4);
            btnWindowAddContact.Name = "btnWindowAddContact";
            btnWindowAddContact.Size = new Size(716, 75);
            btnWindowAddContact.TabIndex = 1;
            btnWindowAddContact.Text = "Agregar Contacto";
            btnWindowAddContact.UseVisualStyleBackColor = false;
            btnWindowAddContact.Click += btnWindowAddContact_Click;
            // 
            // btnWindowSearchContact
            // 
            btnWindowSearchContact.BackColor = Color.RoyalBlue;
            btnWindowSearchContact.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWindowSearchContact.ForeColor = Color.White;
            btnWindowSearchContact.Location = new Point(208, 261);
            btnWindowSearchContact.Margin = new Padding(4);
            btnWindowSearchContact.Name = "btnWindowSearchContact";
            btnWindowSearchContact.Size = new Size(716, 75);
            btnWindowSearchContact.TabIndex = 2;
            btnWindowSearchContact.Text = "Buscar Contacto";
            btnWindowSearchContact.UseVisualStyleBackColor = false;
            btnWindowSearchContact.Click += btnWindowSearchContact_Click;
            // 
            // btnWindowUpdateContact
            // 
            btnWindowUpdateContact.BackColor = Color.RoyalBlue;
            btnWindowUpdateContact.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWindowUpdateContact.ForeColor = Color.White;
            btnWindowUpdateContact.Location = new Point(208, 559);
            btnWindowUpdateContact.Margin = new Padding(4);
            btnWindowUpdateContact.Name = "btnWindowUpdateContact";
            btnWindowUpdateContact.Size = new Size(716, 75);
            btnWindowUpdateContact.TabIndex = 3;
            btnWindowUpdateContact.Text = "Actualizar Contacto";
            btnWindowUpdateContact.UseVisualStyleBackColor = false;
            btnWindowUpdateContact.Click += btnWindowUpdateContact_Click;
            // 
            // btnWindowDeleteContact
            // 
            btnWindowDeleteContact.BackColor = Color.RoyalBlue;
            btnWindowDeleteContact.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWindowDeleteContact.ForeColor = Color.White;
            btnWindowDeleteContact.Location = new Point(208, 708);
            btnWindowDeleteContact.Margin = new Padding(4);
            btnWindowDeleteContact.Name = "btnWindowDeleteContact";
            btnWindowDeleteContact.Size = new Size(716, 75);
            btnWindowDeleteContact.TabIndex = 4;
            btnWindowDeleteContact.Text = "Eliminar Contacto";
            btnWindowDeleteContact.UseVisualStyleBackColor = false;
            btnWindowDeleteContact.Click += btnWindowDeleteContact_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1099, 871);
            Controls.Add(btnWindowDeleteContact);
            Controls.Add(btnWindowUpdateContact);
            Controls.Add(btnWindowSearchContact);
            Controls.Add(btnWindowAddContact);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnWindowAddContact;
        private Button btnWindowSearchContact;
        private Button btnWindowUpdateContact;
        private Button btnWindowDeleteContact;
    }
}
