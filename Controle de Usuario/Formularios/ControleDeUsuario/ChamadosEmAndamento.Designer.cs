namespace Controle_de_chamados.Formularios.ControleDeUsuario
{
    partial class ChamadosEmAndamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamadosEmAndamento));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnIVoltar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            label7 = new Label();
            panel6 = new Panel();
            label5 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            lblAguardando = new Label();
            panel4 = new Panel();
            lblAnd = new Label();
            label2 = new Label();
            label6 = new Label();
            dgvCAndamento = new DataGridView();
            txtPesquisa = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCAndamento).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.666667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.3333359F));
            tableLayoutPanel1.Size = new Size(599, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 148, 136);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnIVoltar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 42);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(13, 148, 136);
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(473, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
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
            btnIVoltar.Size = new Size(65, 42);
            btnIVoltar.TabIndex = 0;
            btnIVoltar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(51, 65, 85);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.76707F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.4658661F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.767065F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 51);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.686272F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80.6316452F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.682081F));
            tableLayoutPanel2.Size = new Size(593, 396);
            tableLayoutPanel2.TabIndex = 3;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(30, 41, 59);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.1982574F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.8017426F));
            tableLayoutPanel3.Controls.Add(panel2, 0, 1);
            tableLayoutPanel3.Controls.Add(panel3, 0, 3);
            tableLayoutPanel3.Controls.Add(label6, 0, 2);
            tableLayoutPanel3.Controls.Add(dgvCAndamento, 0, 5);
            tableLayoutPanel3.Controls.Add(txtPesquisa, 0, 4);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(66, 41);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.0879126F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 87.91209F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.Size = new Size(459, 313);
            tableLayoutPanel3.TabIndex = 0;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 29);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 4);
            label1.Name = "label1";
            label1.Size = new Size(252, 22);
            label1.TabIndex = 0;
            label1.Text = "Chamados em andamento";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(13, 148, 136);
            iconPictureBox1.Dock = DockStyle.Left;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Headphones;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 29;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 29);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 72);
            panel3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 55);
            label7.Name = "label7";
            label7.Size = new Size(124, 16);
            label7.TabIndex = 3;
            label7.Text = "Pesquisar Chamado";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(51, 65, 85);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(339, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(103, 47);
            panel6.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 31);
            label5.Name = "label5";
            label5.Size = new Size(51, 14);
            label5.TabIndex = 4;
            label5.Text = "Urgentes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(37, 9);
            label4.Name = "label4";
            label4.Size = new Size(27, 19);
            label4.TabIndex = 3;
            label4.Text = "03";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(51, 65, 85);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblAguardando);
            panel5.Location = new Point(177, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(103, 47);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 31);
            label3.Name = "label3";
            label3.Size = new Size(67, 14);
            label3.TabIndex = 2;
            label3.Text = "Aguardando";
            // 
            // lblAguardando
            // 
            lblAguardando.AutoSize = true;
            lblAguardando.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAguardando.ForeColor = Color.Goldenrod;
            lblAguardando.Location = new Point(37, 9);
            lblAguardando.Name = "lblAguardando";
            lblAguardando.Size = new Size(27, 19);
            lblAguardando.TabIndex = 2;
            lblAguardando.Text = "02";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 65, 85);
            panel4.Controls.Add(lblAnd);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(15, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(103, 47);
            panel4.TabIndex = 0;
            // 
            // lblAnd
            // 
            lblAnd.AutoSize = true;
            lblAnd.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnd.ForeColor = Color.ForestGreen;
            lblAnd.Location = new Point(39, 9);
            lblAnd.Name = "lblAnd";
            lblAnd.Size = new Size(27, 19);
            lblAnd.TabIndex = 1;
            lblAnd.Text = "01";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 31);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 0;
            label2.Text = "Em andamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 39);
            label6.Name = "label6";
            label6.Size = new Size(146, 14);
            label6.TabIndex = 4;
            label6.Text = "Gerencie seus Atendimentos";
            // 
            // dgvCAndamento
            // 
            dgvCAndamento.BackgroundColor = Color.White;
            dgvCAndamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCAndamento.Dock = DockStyle.Fill;
            dgvCAndamento.Location = new Point(3, 172);
            dgvCAndamento.Name = "dgvCAndamento";
            dgvCAndamento.Size = new Size(453, 127);
            dgvCAndamento.TabIndex = 5;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(3, 139);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(289, 23);
            txtPesquisa.TabIndex = 6;
            // 
            // ChamadosEmAndamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ChamadosEmAndamento";
            Size = new Size(599, 450);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCAndamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnIVoltar;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblAguardando;
        private Label lblAnd;
        private Label label2;
        private Label label6;
        private DataGridView dgvCAndamento;
        private Label label7;
        private TextBox txtPesquisa;
        private PictureBox pictureBox1;
    }
}
