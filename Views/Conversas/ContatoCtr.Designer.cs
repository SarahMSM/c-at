namespace chat
{
    partial class ContatoCtr
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
            this.components = new System.ComponentModel.Container();
            this.pnlBorda = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.pnlBorda.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlBorda
            //
            this.pnlBorda.BackColor = System.Drawing.Color.FromArgb(212, 160, 23);
            this.pnlBorda.Location = new System.Drawing.Point(0, 0);
            this.pnlBorda.Size = new System.Drawing.Size(6, 50);
            //
            // lblNome
            //
            this.lblNome.AutoSize = false;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.lblNome.Location = new System.Drawing.Point(14, 0);
            this.lblNome.Size = new System.Drawing.Size(250, 50);
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNome.AutoEllipsis = true;
            this.lblNome.Text = "Contato";
            //
            // btnApagar
            //
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(107, 17, 40);
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(280, 10);
            this.btnApagar.Size = new System.Drawing.Size(90, 30);
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            //
            // ContatoCtr
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ContatoCtr";
            this.Size = new System.Drawing.Size(380, 50);
            this.Controls.Add(this.pnlBorda);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnApagar);
            this.pnlBorda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlBorda;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnApagar;
    }
}
