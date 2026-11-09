namespace chat
{
    partial class FrmListar
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
            btnEditar = new Button();
            btnRemover = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.BackColor = Color.Transparent;
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
            btnFiltrar.Location = new Point(385, 12);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(105, 32);
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
            lista.MultiSelect = false;
            lista.Name = "lista";
            lista.Size = new Size(490, 300);
            lista.TabIndex = 3;
            lista.UseCompatibleStateImageBehavior = false;
            lista.View = View.Details;
            // 
            // colNome
            // 
            colNome.Text = "NOME";
            colNome.Width = 300;
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
            btnAdicionar.Location = new Point(15, 385);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(155, 42);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.BlueViolet;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(182, 385);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 42);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(18, 18, 18);
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(350, 385);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(155, 42);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // FrmListar
            // 
            AcceptButton = btnFiltrar;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(520, 480);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(btnFiltrar);
            Controls.Add(lista);
            Controls.Add(btnAdicionar);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C#at - Contatos";
            Load += FrmListar_Load;
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
    }
}
