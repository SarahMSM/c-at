namespace chat
{
    partial class FrmListas
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
            btnContatos = new Button();
            btnNova = new Button();
            painel = new FlowLayoutPanel();
            tmrAtualizar = new System.Windows.Forms.Timer(components);
            pnlTopo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(18, 18, 18);
            pnlTopo.Controls.Add(btnContatos);
            pnlTopo.Controls.Add(btnNova);
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(440, 56);
            pnlTopo.TabIndex = 0;
            // 
            // btnContatos
            // 
            btnContatos.BackColor = Color.BlueViolet;
            btnContatos.Cursor = Cursors.Hand;
            btnContatos.FlatAppearance.BorderSize = 0;
            btnContatos.FlatStyle = FlatStyle.Flat;
            btnContatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnContatos.ForeColor = Color.White;
            btnContatos.Location = new Point(12, 10);
            btnContatos.Name = "btnContatos";
            btnContatos.Size = new Size(130, 36);
            btnContatos.TabIndex = 0;
            btnContatos.Text = "Contatos";
            btnContatos.UseVisualStyleBackColor = false;
            btnContatos.Click += btnContatos_Click;
            // 
            // btnNova
            // 
            btnNova.BackColor = Color.SteelBlue;
            btnNova.Cursor = Cursors.Hand;
            btnNova.FlatAppearance.BorderSize = 0;
            btnNova.FlatStyle = FlatStyle.Flat;
            btnNova.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNova.ForeColor = Color.FromArgb(18, 18, 18);
            btnNova.Location = new Point(280, 10);
            btnNova.Name = "btnNova";
            btnNova.Size = new Size(148, 36);
            btnNova.TabIndex = 1;
            btnNova.Text = "Nova Conversa";
            btnNova.UseVisualStyleBackColor = false;
            btnNova.Click += btnNova_Click;
            // 
            // painel
            // 
            painel.AutoScroll = true;
            painel.BackColor = Color.White;
            painel.FlowDirection = FlowDirection.TopDown;
            painel.Location = new Point(0, 56);
            painel.Name = "painel";
            painel.Padding = new Padding(8);
            painel.Size = new Size(440, 524);
            painel.TabIndex = 1;
            painel.WrapContents = false;
            // 
            // tmrAtualizar
            // 
            tmrAtualizar.Enabled = true;
            tmrAtualizar.Interval = 30000;
            tmrAtualizar.Tick += tmrAtualizar_Tick;
            // 
            // FrmListas
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(107, 17, 40);
            ClientSize = new Size(440, 580);
            Controls.Add(pnlTopo);
            Controls.Add(painel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmListas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C#at - Conversas";
            pnlTopo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.FlowLayoutPanel painel;
        private System.Windows.Forms.Timer tmrAtualizar;
    }
}
