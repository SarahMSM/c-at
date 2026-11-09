namespace chat
{
    partial class FrmBuscarContato
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            btnFiltrar = new Button();
            lista = new ListView();
            colNome = new ColumnHeader();
            colCodigo = new ColumnHeader();
            btnAdicionar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.Black;
            lblNome.Location = new Point(15, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(60, 24);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.ForeColor = Color.FromArgb(18, 18, 18);
            txtNome.Location = new Point(80, 15);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(290, 30);
            txtNome.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.BlueViolet;
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(380, 12);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(100, 32);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // lista
            // 
            lista.BackColor = Color.White;
            lista.BorderStyle = BorderStyle.FixedSingle;
            lista.Columns.AddRange(new ColumnHeader[] { colNome, colCodigo });
            lista.ForeColor = Color.FromArgb(18, 18, 18);
            lista.FullRowSelect = true;
            lista.GridLines = true;
            lista.Location = new Point(15, 65);
            lista.Name = "lista";
            lista.Size = new Size(470, 280);
            lista.TabIndex = 3;
            lista.UseCompatibleStateImageBehavior = false;
            lista.View = View.Details;
            // 
            // colNome
            // 
            colNome.Text = "NOME";
            colNome.Width = 280;
            // 
            // colCodigo
            // 
            colCodigo.Text = "CÓDIGO";
            colCodigo.Width = 170;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.SteelBlue;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdicionar.ForeColor = Color.FromArgb(18, 18, 18);
            btnAdicionar.Location = new Point(15, 360);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(470, 42);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // FrmBuscarContato
            // 
            AcceptButton = btnFiltrar;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(500, 440);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(btnFiltrar);
            Controls.Add(lista);
            Controls.Add(btnAdicionar);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmBuscarContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C#at - Buscar contato";
            Load += FrmBuscarContato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colCodigo;
        private System.Windows.Forms.Button btnAdicionar;
    }
}
