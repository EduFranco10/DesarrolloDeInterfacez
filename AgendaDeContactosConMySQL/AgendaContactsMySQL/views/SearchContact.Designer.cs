namespace AgendaContactsMySQL.views
{
    partial class SearchContact
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
            btnSearchContact = new Button();
            btnClean = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 54);
            label1.Name = "label1";
            label1.Size = new Size(401, 62);
            label1.TabIndex = 0;
            label1.Text = "Buscar Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(102, 159);
            label2.Name = "label2";
            label2.Size = new Size(108, 35);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(102, 269);
            label3.Name = "label3";
            label3.Size = new Size(110, 35);
            label3.TabIndex = 2;
            label3.Text = "Télefono";
            // 
            // textName
            // 
            textName.Location = new Point(109, 197);
            textName.Name = "textName";
            textName.Size = new Size(520, 27);
            textName.TabIndex = 3;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(109, 307);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(520, 27);
            textPhone.TabIndex = 4;
            textPhone.TextChanged += textPhone_TextChanged;
            // 
            // btnSearchContact
            // 
            btnSearchContact.BackColor = SystemColors.ActiveCaption;
            btnSearchContact.Font = new Font("Segoe UI", 13F);
            btnSearchContact.Location = new Point(109, 369);
            btnSearchContact.Name = "btnSearchContact";
            btnSearchContact.Size = new Size(113, 41);
            btnSearchContact.TabIndex = 5;
            btnSearchContact.Text = "Buscar";
            btnSearchContact.UseVisualStyleBackColor = false;
            btnSearchContact.Click += btnSearchContact_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.IndianRed;
            btnClean.Font = new Font("Segoe UI", 13F);
            btnClean.ForeColor = SystemColors.ActiveCaptionText;
            btnClean.Location = new Point(265, 369);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(111, 41);
            btnClean.TabIndex = 6;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // SearchContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(775, 551);
            Controls.Add(btnClean);
            Controls.Add(btnSearchContact);
            Controls.Add(textPhone);
            Controls.Add(textName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchContact";
            Text = "SearchContact";
            Load += SearchContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textName;
        private TextBox textPhone;
        private Button btnSearchContact;
        private Button btnClean;
    }
}