namespace AgendaContactsMySQL.views
{
    partial class Login
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
            textUser = new TextBox();
            textPassword = new TextBox();
            btnLogin = new Button();
            btnRegistro = new Button();
            btnLimpiarCampos = new Button();
            btnMostrarPassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 33F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 83);
            label1.Name = "label1";
            label1.Size = new Size(391, 74);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesión";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(124, 203);
            label2.Name = "label2";
            label2.Size = new Size(129, 46);
            label2.TabIndex = 1;
            label2.Text = "usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(124, 325);
            label3.Name = "label3";
            label3.Size = new Size(184, 46);
            label3.TabIndex = 2;
            label3.Text = "contraseña";
            // 
            // textUser
            // 
            textUser.Location = new Point(124, 250);
            textUser.Name = "textUser";
            textUser.Size = new Size(514, 27);
            textUser.TabIndex = 3;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(124, 371);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(514, 27);
            textPassword.TabIndex = 4;
            textPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MistyRose;
            btnLogin.Font = new Font("Segoe UI", 13F);
            btnLogin.Location = new Point(124, 421);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(103, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.MistyRose;
            btnRegistro.Font = new Font("Segoe UI", 13F);
            btnRegistro.Location = new Point(313, 421);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(139, 39);
            btnRegistro.TabIndex = 6;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.MistyRose;
            btnLimpiarCampos.Font = new Font("Segoe UI", 13F);
            btnLimpiarCampos.Location = new Point(521, 421);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(117, 39);
            btnLimpiarCampos.TabIndex = 7;
            btnLimpiarCampos.Text = "Limpiar";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnMostrarPassword
            // 
            btnMostrarPassword.BackColor = Color.MistyRose;
            btnMostrarPassword.Font = new Font("Segoe UI", 13F);
            btnMostrarPassword.Location = new Point(644, 362);
            btnMostrarPassword.Name = "btnMostrarPassword";
            btnMostrarPassword.Size = new Size(103, 39);
            btnMostrarPassword.TabIndex = 8;
            btnMostrarPassword.Text = "Mostrar";
            btnMostrarPassword.UseVisualStyleBackColor = false;
            btnMostrarPassword.Click += btnMostrarPassword_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(956, 700);
            Controls.Add(btnMostrarPassword);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(btnRegistro);
            Controls.Add(btnLogin);
            Controls.Add(textPassword);
            Controls.Add(textUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textUser;
        private TextBox textPassword;
        private Button btnLogin;
        private Button btnRegistro;
        private Button btnLimpiarCampos;
        private Button btnMostrarPassword;
    }
}