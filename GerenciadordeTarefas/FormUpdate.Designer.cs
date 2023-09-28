namespace GerenciadordeTarefas
{
    partial class FormUpdate
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
            button1 = new Button();
            label4 = new Label();
            TextBoxDescricao = new TextBox();
            label3 = new Label();
            TextBoxNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            TextBoxDthr = new TextBox();
            radioButtonAlta = new RadioButton();
            radioButtonMedia = new RadioButton();
            radioButtonBaixa = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Location = new Point(456, 342);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 23;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonExcluir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 319);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 21;
            label4.Text = "Prioridade:";
            // 
            // TextBoxDescricao
            // 
            TextBoxDescricao.BackColor = Color.White;
            TextBoxDescricao.Location = new Point(25, 200);
            TextBoxDescricao.Multiline = true;
            TextBoxDescricao.Name = "TextBoxDescricao";
            TextBoxDescricao.Size = new Size(587, 116);
            TextBoxDescricao.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 172);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 19;
            label3.Text = "Descrição:";
            // 
            // TextBoxNome
            // 
            TextBoxNome.BackColor = Color.White;
            TextBoxNome.Location = new Point(25, 92);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(305, 23);
            TextBoxNome.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 17;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 12);
            label1.Name = "label1";
            label1.Size = new Size(103, 42);
            label1.TabIndex = 16;
            label1.Text = "Tarefa :";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Focus_tasks__1__removebg_preview;
            pictureBox1.Image = Properties.Resources.Focus_tasks__1__removebg_preview1;
            pictureBox1.InitialImage = Properties.Resources.Focus_tasks__1__removebg_preview;
            pictureBox1.Location = new Point(389, -13);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Location = new Point(365, 342);
            button2.Name = "button2";
            button2.Size = new Size(85, 31);
            button2.TabIndex = 25;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonSalvar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Location = new Point(537, 342);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 26;
            button3.Text = "Concluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonConcluir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 118);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 27;
            label5.Text = "Data De Criação:";
            // 
            // TextBoxDthr
            // 
            TextBoxDthr.BackColor = Color.White;
            TextBoxDthr.Location = new Point(25, 146);
            TextBoxDthr.Name = "TextBoxDthr";
            TextBoxDthr.Size = new Size(305, 23);
            TextBoxDthr.TabIndex = 28;
            // 
            // radioButtonAlta
            // 
            radioButtonAlta.AutoSize = true;
            radioButtonAlta.Location = new Point(25, 354);
            radioButtonAlta.Name = "radioButtonAlta";
            radioButtonAlta.Size = new Size(46, 19);
            radioButtonAlta.TabIndex = 29;
            radioButtonAlta.TabStop = true;
            radioButtonAlta.Text = "Alta";
            radioButtonAlta.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedia
            // 
            radioButtonMedia.AutoSize = true;
            radioButtonMedia.Location = new Point(77, 354);
            radioButtonMedia.Name = "radioButtonMedia";
            radioButtonMedia.Size = new Size(58, 19);
            radioButtonMedia.TabIndex = 30;
            radioButtonMedia.TabStop = true;
            radioButtonMedia.Text = "Média";
            radioButtonMedia.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaixa
            // 
            radioButtonBaixa.AutoSize = true;
            radioButtonBaixa.Location = new Point(141, 354);
            radioButtonBaixa.Name = "radioButtonBaixa";
            radioButtonBaixa.Size = new Size(53, 19);
            radioButtonBaixa.TabIndex = 31;
            radioButtonBaixa.TabStop = true;
            radioButtonBaixa.Text = "Baixa";
            radioButtonBaixa.UseVisualStyleBackColor = true;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(78, 196, 245);
            ClientSize = new Size(623, 395);
            Controls.Add(radioButtonBaixa);
            Controls.Add(radioButtonMedia);
            Controls.Add(radioButtonAlta);
            Controls.Add(TextBoxDthr);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(TextBoxDescricao);
            Controls.Add(label3);
            Controls.Add(TextBoxNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormUpdate";
            Text = "FormUpdate";
            Load += FormUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private TextBox TextBoxDescricao;
        private Label label3;
        private TextBox TextBoxNome;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox TextBoxDthr;
        private RadioButton radioButtonAlta;
        private RadioButton radioButtonMedia;
        private RadioButton radioButtonBaixa;
    }
}