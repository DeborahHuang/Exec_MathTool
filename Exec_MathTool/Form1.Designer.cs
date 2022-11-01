namespace Exec_MathTool
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.cboBox1 = new System.Windows.Forms.ComboBox();
			this.btnCal = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cboBox1
			// 
			this.cboBox1.FormattingEnabled = true;
			this.cboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
			this.cboBox1.Location = new System.Drawing.Point(39, 54);
			this.cboBox1.Name = "cboBox1";
			this.cboBox1.Size = new System.Drawing.Size(128, 23);
			this.cboBox1.TabIndex = 0;
			this.cboBox1.SelectedIndexChanged += new System.EventHandler(this.cboBox1_SelectedIndexChanged);
			// 
			// btnCal
			// 
			this.btnCal.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCal.Location = new System.Drawing.Point(204, 43);
			this.btnCal.Name = "btnCal";
			this.btnCal.Size = new System.Drawing.Size(104, 40);
			this.btnCal.TabIndex = 1;
			this.btnCal.Text = "計算結果";
			this.btnCal.UseVisualStyleBackColor = true;
			this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblResult.Location = new System.Drawing.Point(36, 125);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(69, 25);
			this.lblResult.TabIndex = 2;
			this.lblResult.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 451);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnCal);
			this.Controls.Add(this.cboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "單一乘法表";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboBox1;
		private System.Windows.Forms.Button btnCal;
		private System.Windows.Forms.Label lblResult;
	}
}

