namespace GerenciadordeTarefas
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
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            btnEsqueciSenha = new LinkLabel();
            txtSenha = new TextBox();
            txtNomeUsuario = new TextBox();
            btnEntrar = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Location = new Point(-2, -2);
            panel4.Name = "panel4";
            panel4.Size = new Size(528, 31);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Teal;
            panel5.Location = new Point(-2, 430);
            panel5.Name = "panel5";
            panel5.Size = new Size(528, 31);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.Location = new Point(494, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(32, 414);
            panel6.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.Location = new Point(-2, 24);
            panel7.Name = "panel7";
            panel7.Size = new Size(32, 414);
            panel7.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnEsqueciSenha);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtNomeUsuario);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(8, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 276);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.ForeColor = Color.White;
            button2.Location = new Point(33, 233);
            button2.Name = "button2";
            button2.Size = new Size(224, 31);
            button2.TabIndex = 6;
            button2.Text = "Criar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnCriarConta_Click;
            // 
            // btnEsqueciSenha
            // 
            btnEsqueciSenha.AutoSize = true;
            btnEsqueciSenha.Location = new Point(139, 160);
            btnEsqueciSenha.Name = "btnEsqueciSenha";
            btnEsqueciSenha.Size = new Size(118, 15);
            btnEsqueciSenha.TabIndex = 4;
            btnEsqueciSenha.TabStop = true;
            btnEsqueciSenha.Text = "Esqueci minha senha";
            btnEsqueciSenha.Click += btnEsqueciSenha_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(33, 134);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(224, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(33, 105);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.PlaceholderText = "Usuario";
            txtNomeUsuario.Size = new Size(224, 23);
            txtNomeUsuario.TabIndex = 2;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Teal;
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(33, 196);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(224, 31);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(55, 295);
            button1.Name = "button1";
            button1.Size = new Size(133, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Focus_tasks__1__removebg_preview1;
            pictureBox1.Location = new Point(0, -66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(109, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(307, 293);
            panel2.TabIndex = 6;
            // 
            // Login
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(78, 196, 245);
            ClientSize = new Size(525, 461);
            Controls.Add(panel2);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.Manual;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel1;
        private Button button2;
        private LinkLabel btnEsqueciSenha;
        private TextBox txtSenha;
        private TextBox txtNomeUsuario;
        private Button btnEntrar;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}