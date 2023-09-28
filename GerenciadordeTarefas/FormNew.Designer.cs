namespace GerenciadordeTarefas
{
    partial class FormNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNew));
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            radioButtonAlta = new RadioButton();
            radioButtonMedia = new RadioButton();
            radioButtonBaixa = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.WhiteSmoke;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnInserir;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Focus_tasks__1__removebg_preview;
            pictureBox1.Image = Properties.Resources.Focus_tasks__1__removebg_preview1;
            pictureBox1.InitialImage = Properties.Resources.Focus_tasks__1__removebg_preview;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.Click += BTNhome;
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.Name = "txtNome";
            // 
            // txtDescricao
            // 
            resources.ApplyResources(txtDescricao, "txtDescricao");
            txtDescricao.Name = "txtDescricao";
            // 
            // radioButtonAlta
            // 
            resources.ApplyResources(radioButtonAlta, "radioButtonAlta");
            radioButtonAlta.Name = "radioButtonAlta";
            radioButtonAlta.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedia
            // 
            resources.ApplyResources(radioButtonMedia, "radioButtonMedia");
            radioButtonMedia.Name = "radioButtonMedia";
            radioButtonMedia.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaixa
            // 
            resources.ApplyResources(radioButtonBaixa, "radioButtonBaixa");
            radioButtonBaixa.Name = "radioButtonBaixa";
            radioButtonBaixa.UseVisualStyleBackColor = true;
            // 
            // FormNew
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(78, 196, 245);
            Controls.Add(radioButtonBaixa);
            Controls.Add(radioButtonMedia);
            Controls.Add(radioButtonAlta);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormNew";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private RadioButton radioButtonAlta;
        private RadioButton radioButtonMedia;
        private RadioButton radioButtonBaixa;
    }
}