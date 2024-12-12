namespace AgendaContactsMySQL.views
{
    partial class Registro
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textUser = new TextBox();
            textPassword = new TextBox();
            textRepetirPassword = new TextBox();
            btnCrearCuenta = new Button();
            btnMostrarPassword = new Button();
            btnMostrarPasswordRepetido = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 39);
            label1.Name = "label1";
            label1.Size = new Size(454, 89);
            label1.TabIndex = 0;
            label1.Text = "Crear cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(220, 160);
            label2.Name = "label2";
            label2.Size = new Size(129, 46);
            label2.TabIndex = 1;
            label2.Text = "usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(220, 310);
            label3.Name = "label3";
            label3.Size = new Size(184, 46);
            label3.TabIndex = 2;
            label3.Text = "contraseña";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(220, 456);
            label4.Name = "label4";
            label4.Size = new Size(293, 46);
            label4.TabIndex = 3;
            label4.Text = "repetir contraseña";
            // 
            // textUser
            // 
            textUser.Location = new Point(220, 206);
            textUser.Name = "textUser";
            textUser.Size = new Size(477, 27);
            textUser.TabIndex = 4;
            textUser.TextChanged += textUser_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(220, 357);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(477, 27);
            textPassword.TabIndex = 5;
            textPassword.UseSystemPasswordChar = true;
            // 
            // textRepetirPassword
            // 
            textRepetirPassword.Location = new Point(220, 502);
            textRepetirPassword.Name = "textRepetirPassword";
            textRepetirPassword.Size = new Size(477, 27);
            textRepetirPassword.TabIndex = 6;
            textRepetirPassword.UseSystemPasswordChar = true;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.MistyRose;
            btnCrearCuenta.Location = new Point(220, 572);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(117, 39);
            btnCrearCuenta.TabIndex = 7;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnMostrarPassword
            // 
            btnMostrarPassword.BackColor = Color.MistyRose;
            btnMostrarPassword.Location = new Point(702, 345);
            btnMostrarPassword.Name = "btnMostrarPassword";
            btnMostrarPassword.Size = new Size(117, 39);
            btnMostrarPassword.TabIndex = 8;
            btnMostrarPassword.Text = "Mostrar";
            btnMostrarPassword.UseVisualStyleBackColor = false;
            btnMostrarPassword.Click += btnMostrarPassword_Click;
            // 
            // btnMostrarPasswordRepetido
            // 
            btnMostrarPasswordRepetido.BackColor = Color.MistyRose;
            btnMostrarPasswordRepetido.Location = new Point(702, 490);
            btnMostrarPasswordRepetido.Name = "btnMostrarPasswordRepetido";
            btnMostrarPasswordRepetido.Size = new Size(117, 39);
            btnMostrarPasswordRepetido.TabIndex = 9;
            btnMostrarPasswordRepetido.Text = "Mostrar";
            btnMostrarPasswordRepetido.UseVisualStyleBackColor = false;
            btnMostrarPasswordRepetido.Click += btnMostrarPasswordRepetido_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Location = new Point(428, 572);
            button1.Name = "button1";
            button1.Size = new Size(174, 39);
            button1.TabIndex = 10;
            button1.Text = "Limpiar campos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(945, 705);
            Controls.Add(button1);
            Controls.Add(btnMostrarPasswordRepetido);
            Controls.Add(btnMostrarPassword);
            Controls.Add(btnCrearCuenta);
            Controls.Add(textRepetirPassword);
            Controls.Add(textPassword);
            Controls.Add(textUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textUser;
        private TextBox textPassword;
        private TextBox textRepetirPassword;
        private Button btnCrearCuenta;
        private Button btnMostrarPassword;
        private Button btnMostrarPasswordRepetido;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
    }
}