namespace GerenciadordeTarefas
{
    partial class FormSearch
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtBusca = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Focus_tasks__1__removebg_preview;
            pictureBox1.Location = new Point(2, -61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.BlanchedAlmond;
            button1.Location = new Point(480, 45);
            button1.Name = "button1";
            button1.Size = new Size(93, 36);
            button1.TabIndex = 1;
            button1.Text = "Nova Tarefa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.White;
            txtBusca.Location = new Point(12, 101);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(267, 23);
            txtBusca.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(580, 248);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.ForeColor = Color.White;
            button2.Location = new Point(285, 93);
            button2.Name = "button2";
            button2.Size = new Size(64, 37);
            button2.TabIndex = 4;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnBuscaTarefa;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(78, 196, 245);
            ClientSize = new Size(615, 404);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(txtBusca);
            Controls.Add(pictureBox1);
            Name = "FormSearch";
            Text = "FormSearch";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtBusca;
        private DataGridView dataGridView1;
        private Button button2;
    }
}