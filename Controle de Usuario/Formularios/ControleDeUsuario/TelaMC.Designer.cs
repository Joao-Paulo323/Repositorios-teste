namespace Controle_de_chamados.Formularios.ControleDeUsuario
{
    partial class TelaMC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMC));
            tlpMainMc = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnIVoltar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            lblCliente = new Label();
            label1 = new Label();
            panel4 = new Panel();
            lblCCN = new Label();
            lblAndN = new Label();
            lblTTN = new Label();
            lblCC = new Label();
            lblAnd = new Label();
            lblTT = new Label();
            tlpMainMc.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainMc
            // 
            tlpMainMc.ColumnCount = 1;
            tlpMainMc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainMc.Controls.Add(panel1, 0, 0);
            tlpMainMc.Controls.Add(tableLayoutPanel1, 0, 1);
            tlpMainMc.Dock = DockStyle.Fill;
            tlpMainMc.Location = new Point(0, 0);
            tlpMainMc.Name = "tlpMainMc";
            tlpMainMc.RowCount = 2;
            tlpMainMc.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9066429F));
            tlpMainMc.RowStyles.Add(new RowStyle(SizeType.Percent, 89.09335F));
            tlpMainMc.Size = new Size(599, 450);
            tlpMainMc.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 148, 136);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnIVoltar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 43);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(13, 148, 136);
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(473, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnIVoltar
            // 
            btnIVoltar.BackColor = Color.FromArgb(13, 148, 136);
            btnIVoltar.Dock = DockStyle.Left;
            btnIVoltar.FlatStyle = FlatStyle.Flat;
            btnIVoltar.ForeColor = Color.SeaGreen;
            btnIVoltar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnIVoltar.IconColor = Color.White;
            btnIVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIVoltar.IconSize = 35;
            btnIVoltar.Location = new Point(0, 0);
            btnIVoltar.Name = "btnIVoltar";
            btnIVoltar.Size = new Size(65, 43);
            btnIVoltar.TabIndex = 0;
            btnIVoltar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(51, 65, 85);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 3);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.866242F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 97.13376F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 228F));
            tableLayoutPanel1.Size = new Size(593, 395);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(23, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(547, 223);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 41, 59);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(23, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 36);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 65, 85);
            panel3.Controls.Add(lblCliente);
            panel3.Location = new Point(430, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(103, 22);
            panel3.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.FlatStyle = FlatStyle.Flat;
            lblCliente.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.FromArgb(45, 212, 191);
            lblCliente.Location = new Point(3, 4);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(98, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Aréa do Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 212, 191);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(166, 22);
            label1.TabIndex = 0;
            label1.Text = "Meus Chamados";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 41, 59);
            panel4.Controls.Add(lblCCN);
            panel4.Controls.Add(lblAndN);
            panel4.Controls.Add(lblTTN);
            panel4.Controls.Add(lblCC);
            panel4.Controls.Add(lblAnd);
            panel4.Controls.Add(lblTT);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(23, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(547, 77);
            panel4.TabIndex = 2;
            // 
            // lblCCN
            // 
            lblCCN.AutoSize = true;
            lblCCN.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCCN.ForeColor = Color.FromArgb(192, 0, 0);
            lblCCN.Location = new Point(463, 37);
            lblCCN.Name = "lblCCN";
            lblCCN.Size = new Size(32, 22);
            lblCCN.TabIndex = 5;
            lblCCN.Text = "03";
            // 
            // lblAndN
            // 
            lblAndN.AutoSize = true;
            lblAndN.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAndN.ForeColor = Color.Goldenrod;
            lblAndN.Location = new Point(254, 37);
            lblAndN.Name = "lblAndN";
            lblAndN.Size = new Size(32, 22);
            lblAndN.TabIndex = 4;
            lblAndN.Text = "02";
            // 
            // lblTTN
            // 
            lblTTN.AutoSize = true;
            lblTTN.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTTN.ForeColor = Color.ForestGreen;
            lblTTN.Location = new Point(42, 37);
            lblTTN.Name = "lblTTN";
            lblTTN.Size = new Size(32, 22);
            lblTTN.TabIndex = 3;
            lblTTN.Text = "01";
            // 
            // lblCC
            // 
            lblCC.AutoSize = true;
            lblCC.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCC.ForeColor = Color.FromArgb(45, 212, 191);
            lblCC.Location = new Point(433, 5);
            lblCC.Name = "lblCC";
            lblCC.Size = new Size(88, 19);
            lblCC.TabIndex = 2;
            lblCC.Text = "Concluído";
            // 
            // lblAnd
            // 
            lblAnd.AutoSize = true;
            lblAnd.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnd.ForeColor = Color.FromArgb(45, 212, 191);
            lblAnd.Location = new Point(211, 5);
            lblAnd.Name = "lblAnd";
            lblAnd.Size = new Size(125, 19);
            lblAnd.TabIndex = 1;
            lblAnd.Text = "Em Andamento";
            // 
            // lblTT
            // 
            lblTT.AutoSize = true;
            lblTT.BackColor = Color.Transparent;
            lblTT.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTT.ForeColor = Color.FromArgb(45, 212, 191);
            lblTT.Location = new Point(32, 5);
            lblTT.Name = "lblTT";
            lblTT.Size = new Size(46, 19);
            lblTT.TabIndex = 0;
            lblTT.Text = "Total";
            // 
            // TelaMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMainMc);
            Name = "TelaMC";
            Size = new Size(599, 450);
            tlpMainMc.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainMc;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnIVoltar;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblCliente;
        private Label label1;
        private Panel panel4;
        private Label lblTT;
        private Label lblCC;
        private Label lblAnd;
        private Label lblCCN;
        private Label lblAndN;
        private Label lblTTN;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}
