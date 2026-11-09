namespace chat
{
    partial class FrmLogin
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
            lblTitulo = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblPin = new Label();
            txtPin = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Riffic Free Medium", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.SteelBlue;
            lblTitulo.Location = new Point(94, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(156, 62);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "C#at";
            // 
            // lblCodigo
            // 
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.ForeColor = Color.Black;
            lblCodigo.Location = new Point(30, 129);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 24);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.ForeColor = Color.FromArgb(18, 18, 18);
            txtCodigo.Location = new Point(110, 125);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 30);
            txtCodigo.TabIndex = 3;
            // 
            // lblPin
            // 
            lblPin.BackColor = Color.Transparent;
            lblPin.ForeColor = Color.Black;
            lblPin.Location = new Point(30, 179);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(70, 24);
            lblPin.TabIndex = 4;
            lblPin.Text = "PIN:";
            // 
            // txtPin
            // 
            txtPin.BackColor = Color.White;
            txtPin.BorderStyle = BorderStyle.FixedSingle;
            txtPin.ForeColor = Color.FromArgb(18, 18, 18);
            txtPin.Location = new Point(110, 175);
            txtPin.MaxLength = 4;
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '●';
            txtPin.Size = new Size(200, 30);
            txtPin.TabIndex = 5;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.SteelBlue;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.FromArgb(18, 18, 18);
            btnEntrar.Location = new Point(30, 245);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(280, 42);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(340, 330);
            Controls.Add(lblTitulo);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblPin);
            Controls.Add(txtPin);
            Controls.Add(btnEntrar);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C#at - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnEntrar;
    }
}
