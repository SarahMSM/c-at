namespace chat
{
    partial class FrmCriar
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
            btnAdd = new Button();
            painel = new FlowLayoutPanel();
            btnCriar = new Button();
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
            txtNome.Size = new Size(320, 30);
            txtNome.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(18, 18, 18);
            btnAdd.Location = new Point(100, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(220, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar Contato";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // painel
            // 
            painel.AutoScroll = true;
            painel.BackColor = Color.Gainsboro;
            painel.FlowDirection = FlowDirection.TopDown;
            painel.Location = new Point(15, 115);
            painel.Name = "painel";
            painel.Size = new Size(390, 360);
            painel.TabIndex = 3;
            painel.WrapContents = false;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.BlueViolet;
            btnCriar.Cursor = Cursors.Hand;
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCriar.ForeColor = Color.White;
            btnCriar.Location = new Point(100, 490);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(220, 42);
            btnCriar.TabIndex = 4;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // FrmCriar
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(420, 560);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(btnAdd);
            Controls.Add(painel);
            Controls.Add(btnCriar);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCriar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C#at - Nova conversa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel painel;
        private System.Windows.Forms.Button btnCriar;
    }
}
