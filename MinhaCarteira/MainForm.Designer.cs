namespace MinhaCarteira
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnMovimentacoes = new Button();
            lblHora = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnPessoas = new Button();
            panelFilhos = new Panel();
            PanelTop = new Panel();
            gbpBotoes = new Panel();
            btnDelete = new Button();
            btnEditar = new Button();
            btnAdd = new Button();
            txtCurrentTime = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelFilhos.SuspendLayout();
            PanelTop.SuspendLayout();
            gbpBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // btnMovimentacoes
            // 
            btnMovimentacoes.FlatAppearance.BorderSize = 0;
            btnMovimentacoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnMovimentacoes.FlatStyle = FlatStyle.Flat;
            btnMovimentacoes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMovimentacoes.ForeColor = Color.White;
            btnMovimentacoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovimentacoes.Location = new Point(7, 99);
            btnMovimentacoes.Margin = new Padding(4, 3, 4, 3);
            btnMovimentacoes.Name = "btnMovimentacoes";
            btnMovimentacoes.Size = new Size(225, 37);
            btnMovimentacoes.TabIndex = 17;
            btnMovimentacoes.Text = "Movimentações";
            btnMovimentacoes.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.FromArgb(255, 128, 0);
            lblHora.Location = new Point(2226, 15);
            lblHora.Margin = new Padding(4, 0, 4, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(218, 25);
            lblHora.TabIndex = 1;
            lblHora.Text = "20/10/2020 11:58:09";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(7, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuário Logado:";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1110, 810);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(6, 1133);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(227, 37);
            button3.TabIndex = 11;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(211, 33);
            label2.TabIndex = 42;
            label2.Text = "Minha Carteira";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(btnMovimentacoes);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnPessoas);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 869);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(7, 869);
            panel2.TabIndex = 12;
            // 
            // btnPessoas
            // 
            btnPessoas.FlatAppearance.BorderSize = 0;
            btnPessoas.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnPessoas.FlatStyle = FlatStyle.Flat;
            btnPessoas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPessoas.ForeColor = Color.White;
            btnPessoas.ImageAlign = ContentAlignment.MiddleLeft;
            btnPessoas.Location = new Point(7, 62);
            btnPessoas.Margin = new Padding(4, 3, 4, 3);
            btnPessoas.Name = "btnPessoas";
            btnPessoas.Size = new Size(224, 37);
            btnPessoas.TabIndex = 9;
            btnPessoas.Text = "Colaboradores";
            btnPessoas.UseVisualStyleBackColor = true;
            // 
            // panelFilhos
            // 
            panelFilhos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFilhos.BackColor = Color.White;
            panelFilhos.BackgroundImageLayout = ImageLayout.Center;
            panelFilhos.Controls.Add(pictureBox1);
            panelFilhos.Location = new Point(232, 59);
            panelFilhos.Margin = new Padding(4, 3, 4, 3);
            panelFilhos.Name = "panelFilhos";
            panelFilhos.Size = new Size(1110, 810);
            panelFilhos.TabIndex = 5;
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.WhiteSmoke;
            PanelTop.Controls.Add(gbpBotoes);
            PanelTop.Controls.Add(txtCurrentTime);
            PanelTop.Controls.Add(label4);
            PanelTop.Controls.Add(lblHora);
            PanelTop.Controls.Add(label1);
            PanelTop.Dock = DockStyle.Fill;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Margin = new Padding(4, 3, 4, 3);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1342, 869);
            PanelTop.TabIndex = 4;
            // 
            // gbpBotoes
            // 
            gbpBotoes.Anchor = AnchorStyles.Top;
            gbpBotoes.Controls.Add(btnDelete);
            gbpBotoes.Controls.Add(btnEditar);
            gbpBotoes.Controls.Add(btnAdd);
            gbpBotoes.Location = new Point(681, 6);
            gbpBotoes.Margin = new Padding(4, 3, 4, 3);
            gbpBotoes.Name = "gbpBotoes";
            gbpBotoes.Size = new Size(156, 47);
            gbpBotoes.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.cancel24;
            btnDelete.Location = new Point(106, 3);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(42, 38);
            btnDelete.TabIndex = 4;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(57, 3);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(42, 38);
            btnEditar.TabIndex = 3;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(8, 3);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(42, 38);
            btnAdd.TabIndex = 2;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtCurrentTime
            // 
            txtCurrentTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCurrentTime.AutoSize = true;
            txtCurrentTime.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCurrentTime.ForeColor = Color.FromArgb(255, 128, 0);
            txtCurrentTime.Location = new Point(1120, 18);
            txtCurrentTime.Margin = new Padding(4, 0, 4, 0);
            txtCurrentTime.Name = "txtCurrentTime";
            txtCurrentTime.Size = new Size(218, 25);
            txtCurrentTime.TabIndex = 7;
            txtCurrentTime.Text = "20/10/2020 11:58:09";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(241, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 6;
            label4.Text = "Bem vindo";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 869);
            Controls.Add(panel1);
            Controls.Add(panelFilhos);
            Controls.Add(PanelTop);
            Name = "MainForm";
            Text = "Produtos e Categorias";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFilhos.ResumeLayout(false);
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            gbpBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Button btnMovimentacoes;
        private Label lblHora;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        public Button btnPessoas;
        private Panel panelFilhos;
        private Panel PanelTop;
        public Panel gbpBotoes;
        public Button btnDelete;
        public Button btnEditar;
        public Button btnAdd;
        private Label txtCurrentTime;
        private Label label4;
    }
}
