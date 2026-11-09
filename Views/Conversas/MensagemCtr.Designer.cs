namespace chat
{
    partial class MensagemCtr
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // lblInfo
            //
            this.lblInfo.AutoSize = false;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.lblInfo.Location = new System.Drawing.Point(8, 6);
            this.lblInfo.Size = new System.Drawing.Size(120, 72);
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Text = "Nome:";
            //
            // txtTexto
            //
            this.txtTexto.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTexto.ForeColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.txtTexto.Location = new System.Drawing.Point(132, 6);
            this.txtTexto.Multiline = true;
            this.txtTexto.ReadOnly = true;
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto.Size = new System.Drawing.Size(330, 72);
            //
            // MensagemCtr
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "MensagemCtr";
            this.Size = new System.Drawing.Size(470, 84);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtTexto);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtTexto;
    }
}
