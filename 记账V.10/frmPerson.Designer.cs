namespace 记账V._10
{
    partial class frmPerson
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgPerson = new System.Windows.Forms.DataGridView();
            this.cDothings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDothings = new System.Windows.Forms.TextBox();
            this.dtPersonSelectTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSumMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 21);
            this.textBox2.TabIndex = 1;
            // 
            // dgPerson
            // 
            this.dgPerson.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDothings,
            this.cPrice});
            this.dgPerson.Location = new System.Drawing.Point(2, 131);
            this.dgPerson.Name = "dgPerson";
            this.dgPerson.ReadOnly = true;
            this.dgPerson.RowTemplate.Height = 23;
            this.dgPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPerson.Size = new System.Drawing.Size(303, 308);
            this.dgPerson.TabIndex = 2;
            // 
            // cDothings
            // 
            this.cDothings.DataPropertyName = "Dothings";
            this.cDothings.HeaderText = "所做事情";
            this.cDothings.Name = "cDothings";
            this.cDothings.ReadOnly = true;
            this.cDothings.Width = 120;
            // 
            // cPrice
            // 
            this.cPrice.DataPropertyName = "Price";
            this.cPrice.HeaderText = "所花费金额";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            this.cPrice.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "所做的事情：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "所花费金额：";
            // 
            // txtDothings
            // 
            this.txtDothings.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDothings.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDothings.Location = new System.Drawing.Point(87, 14);
            this.txtDothings.Name = "txtDothings";
            this.txtDothings.Size = new System.Drawing.Size(200, 21);
            this.txtDothings.TabIndex = 1;
            // 
            // dtPersonSelectTime
            // 
            this.dtPersonSelectTime.Location = new System.Drawing.Point(88, 104);
            this.dtPersonSelectTime.Name = "dtPersonSelectTime";
            this.dtPersonSelectTime.Size = new System.Drawing.Size(200, 21);
            this.dtPersonSelectTime.TabIndex = 5;
            this.dtPersonSelectTime.ValueChanged += new System.EventHandler(this.dtPersonSelectTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "今日所做事情：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13F);
            this.label4.Location = new System.Drawing.Point(41, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "今日所花费：";
            // 
            // lblSumMoney
            // 
            this.lblSumMoney.AutoSize = true;
            this.lblSumMoney.Font = new System.Drawing.Font("宋体", 13F);
            this.lblSumMoney.Location = new System.Drawing.Point(158, 449);
            this.lblSumMoney.Name = "lblSumMoney";
            this.lblSumMoney.Size = new System.Drawing.Size(17, 18);
            this.lblSumMoney.TabIndex = 4;
            this.lblSumMoney.Text = "0";
            // 
            // frmPerson
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 475);
            this.Controls.Add(this.dtPersonSelectTime);
            this.Controls.Add(this.lblSumMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPerson);
            this.Controls.Add(this.txtDothings);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记账";
            this.Load += new System.EventHandler(this.frmPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDothings;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDothings;
        private System.Windows.Forms.DateTimePicker dtPersonSelectTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSumMoney;
    }
}

