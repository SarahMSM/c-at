namespace chat
{
    partial class ConversaCtr
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.pnlBorda.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlBorda
            //
            this.pnlBorda.BackColor = System.Drawing.Color.FromArgb(30, 77, 43);
            this.pnlBorda.Location = new System.Drawing.Point(0, 0);
            this.pnlBorda.Size = new System.Drawing.Size(6, 60);
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.lblTitulo.Location = new System.Drawing.Point(14, 0);
            this.lblTitulo.Size = new System.Drawing.Size(215, 60);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Text = "Conversa";
            //
            // btnVer
            //
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(30, 77, 43);
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(235, 15);
            this.btnVer.Size = new System.Drawing.Size(80, 30);
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            //
            // btnApagar
            //
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(107, 17, 40);
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(322, 15);
            this.btnApagar.Size = new System.Drawing.Size(80, 30);
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            //
            // ConversaCtr
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ConversaCtr";
            this.Size = new System.Drawing.Size(410, 60);
            this.Controls.Add(this.pnlBorda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnApagar);
            this.pnlBorda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlBorda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnApagar;
    }
}
