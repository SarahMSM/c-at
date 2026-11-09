namespace chat
{
    partial class FrmConversa
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
            components = new System.ComponentModel.Container();
            pnlTopo = new Panel();
            lblTitulo = new Label();
            btnSair = new Button();
            painel = new FlowLayoutPanel();
            pnlRodape = new Panel();
            txtTexto = new TextBox();
            btnEnviar = new Button();
            tmrMensagens = new System.Windows.Forms.Timer(components);
            pnlTopo.SuspendLayout();
            pnlRodape.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(18, 18, 18);
            pnlTopo.Controls.Add(lblTitulo);
            pnlTopo.Controls.Add(btnSair);
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(520, 52);
            pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoEllipsis = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(12, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(380, 52);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Conversa";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(107, 17, 40);
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(410, 8);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(95, 36);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // painel
            // 
            painel.AutoScroll = true;
            painel.BackColor = Color.White;
            painel.FlowDirection = FlowDirection.TopDown;
            painel.Location = new Point(0, 52);
            painel.Name = "painel";
            painel.Padding = new Padding(6);
            painel.Size = new Size(520, 448);
            painel.TabIndex = 1;
            painel.WrapContents = false;
            // 
            // pnlRodape
            // 
            pnlRodape.BackColor = Color.GhostWhite;
            pnlRodape.Controls.Add(txtTexto);
            pnlRodape.Controls.Add(btnEnviar);
            pnlRodape.Location = new Point(0, 500);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(520, 140);
            pnlRodape.TabIndex = 2;
            // 
            // txtTexto
            // 
            txtTexto.BackColor = Color.White;
            txtTexto.BorderStyle = BorderStyle.FixedSingle;
            txtTexto.ForeColor = Color.FromArgb(18, 18, 18);
            txtTexto.Location = new Point(12, 12);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.ScrollBars = ScrollBars.Vertical;
            txtTexto.Size = new Size(390, 116);
            txtTexto.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.SteelBlue;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEnviar.ForeColor = Color.FromArgb(18, 18, 18);
            btnEnviar.Location = new Point(412, 12);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(95, 116);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // tmrMensagens
            // 
            tmrMensagens.Enabled = true;
            tmrMensagens.Interval = 1000;
            tmrMensagens.Tick += tmrMensagens_Tick;
            // 
            // FrmConversa
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(107, 17, 40);
            ClientSize = new Size(520, 640);
            Controls.Add(pnlTopo);
            Controls.Add(painel);
            Controls.Add(pnlRodape);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConversa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C#at - Conversa";
            pnlTopo.ResumeLayout(false);
            pnlRodape.ResumeLayout(false);
            pnlRodape.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.FlowLayoutPanel painel;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Timer tmrMensagens;
    }
}
