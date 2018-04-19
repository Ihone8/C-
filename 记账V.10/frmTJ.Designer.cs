namespace 记账V._10
{
    partial class frmTJ
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
            this.lstDothings = new System.Windows.Forms.ListBox();
            this.txtSR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstDothings
            // 
            this.lstDothings.FormattingEnabled = true;
            this.lstDothings.ItemHeight = 16;
            this.lstDothings.Location = new System.Drawing.Point(39, 34);
            this.lstDothings.Margin = new System.Windows.Forms.Padding(4);
            this.lstDothings.Name = "lstDothings";
            this.lstDothings.Size = new System.Drawing.Size(206, 404);
            this.lstDothings.TabIndex = 0;
            // 
            // txtSR
            // 
            this.txtSR.Location = new System.Drawing.Point(332, 68);
            this.txtSR.Name = "txtSR";
            this.txtSR.Size = new System.Drawing.Size(266, 26);
            this.txtSR.TabIndex = 1;
            this.txtSR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // frmTJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 457);
            this.Controls.Add(this.txtSR);
            this.Controls.Add(this.lstDothings);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTJ";
            this.Text = "统计图练习";
            this.Load += new System.EventHandler(this.frmTJ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDothings;
        private System.Windows.Forms.TextBox txtSR;

    }
}