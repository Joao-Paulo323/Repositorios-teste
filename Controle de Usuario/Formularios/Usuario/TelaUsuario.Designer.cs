namespace Controle_de_chamados.Formularios.Usuario
{
    partial class TelaUsuario
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
            tlpMainUser = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tlpMainUser
            // 
            tlpMainUser.BackColor = Color.FromArgb(51, 65, 85);
            tlpMainUser.ColumnCount = 2;
            tlpMainUser.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 201F));
            tlpMainUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainUser.Dock = DockStyle.Fill;
            tlpMainUser.Location = new Point(0, 0);
            tlpMainUser.Name = "tlpMainUser";
            tlpMainUser.RowCount = 1;
            tlpMainUser.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainUser.Size = new Size(800, 450);
            tlpMainUser.TabIndex = 0;
            tlpMainUser.Paint += tlpMainUser_Paint;
            // 
            // TelaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpMainUser);
            Name = "TelaUsuario";
            Text = "TelaUsuario";
            Load += TelaUsuario_Load;
            ResumeLayout(false);
        }

        #endregion


        private TableLayoutPanel tlpMainUser;
    }
}