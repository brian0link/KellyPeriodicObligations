namespace KellyPeriodicObligations
{
	partial class Form1
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
			this.tbBaseAmount = new System.Windows.Forms.TextBox();
			this.lBaseAmount = new System.Windows.Forms.Label();
			this.lRateOfReturn = new System.Windows.Forms.Label();
			this.tbRateOfReturn = new System.Windows.Forms.TextBox();
			this.lWinPercentage = new System.Windows.Forms.Label();
			this.tbWinPercent = new System.Windows.Forms.TextBox();
			this.lDebug = new System.Windows.Forms.Label();
			this.butCalculate = new System.Windows.Forms.Button();
			this.lTaxPercent = new System.Windows.Forms.Label();
			this.lTithePercent = new System.Windows.Forms.Label();
			this.lNetWeeksDue = new System.Windows.Forms.Label();
			this.lWeeksTilPay = new System.Windows.Forms.Label();
			this.tbTaxPercent = new System.Windows.Forms.TextBox();
			this.tbTithePercent = new System.Windows.Forms.TextBox();
			this.tbNetWeeksDue = new System.Windows.Forms.TextBox();
			this.tbWeeksTilPay = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbBaseAmount
			// 
			this.tbBaseAmount.Location = new System.Drawing.Point(165, 7);
			this.tbBaseAmount.Name = "tbBaseAmount";
			this.tbBaseAmount.Size = new System.Drawing.Size(100, 31);
			this.tbBaseAmount.TabIndex = 0;
			this.tbBaseAmount.Text = "500";
			// 
			// lBaseAmount
			// 
			this.lBaseAmount.AutoSize = true;
			this.lBaseAmount.Location = new System.Drawing.Point(13, 13);
			this.lBaseAmount.Name = "lBaseAmount";
			this.lBaseAmount.Size = new System.Drawing.Size(146, 25);
			this.lBaseAmount.TabIndex = 1;
			this.lBaseAmount.Text = "Base Amount:";
			// 
			// lRateOfReturn
			// 
			this.lRateOfReturn.AutoSize = true;
			this.lRateOfReturn.Location = new System.Drawing.Point(272, 13);
			this.lRateOfReturn.Name = "lRateOfReturn";
			this.lRateOfReturn.Size = new System.Drawing.Size(157, 25);
			this.lRateOfReturn.TabIndex = 2;
			this.lRateOfReturn.Text = "Rate of Return:";
			// 
			// tbRateOfReturn
			// 
			this.tbRateOfReturn.Location = new System.Drawing.Point(436, 7);
			this.tbRateOfReturn.Name = "tbRateOfReturn";
			this.tbRateOfReturn.Size = new System.Drawing.Size(100, 31);
			this.tbRateOfReturn.TabIndex = 3;
			this.tbRateOfReturn.Text = "1.3";
			// 
			// lWinPercentage
			// 
			this.lWinPercentage.AutoSize = true;
			this.lWinPercentage.Location = new System.Drawing.Point(543, 7);
			this.lWinPercentage.Name = "lWinPercentage";
			this.lWinPercentage.Size = new System.Drawing.Size(80, 25);
			this.lWinPercentage.TabIndex = 4;
			this.lWinPercentage.Text = "Win %:";
			// 
			// tbWinPercent
			// 
			this.tbWinPercent.Location = new System.Drawing.Point(630, 7);
			this.tbWinPercent.Name = "tbWinPercent";
			this.tbWinPercent.Size = new System.Drawing.Size(100, 31);
			this.tbWinPercent.TabIndex = 5;
			this.tbWinPercent.Text = "0.75";
			// 
			// lDebug
			// 
			this.lDebug.AutoSize = true;
			this.lDebug.Location = new System.Drawing.Point(326, 150);
			this.lDebug.Name = "lDebug";
			this.lDebug.Size = new System.Drawing.Size(75, 25);
			this.lDebug.TabIndex = 6;
			this.lDebug.Text = "Debug";
			// 
			// butCalculate
			// 
			this.butCalculate.Location = new System.Drawing.Point(727, 150);
			this.butCalculate.Name = "butCalculate";
			this.butCalculate.Size = new System.Drawing.Size(118, 67);
			this.butCalculate.TabIndex = 7;
			this.butCalculate.Text = "Calculate";
			this.butCalculate.UseVisualStyleBackColor = true;
			this.butCalculate.Click += new System.EventHandler(this.butCalculate_Click);
			// 
			// lTaxPercent
			// 
			this.lTaxPercent.AutoSize = true;
			this.lTaxPercent.Location = new System.Drawing.Point(12, 57);
			this.lTaxPercent.Name = "lTaxPercent";
			this.lTaxPercent.Size = new System.Drawing.Size(79, 25);
			this.lTaxPercent.TabIndex = 8;
			this.lTaxPercent.Text = "Tax %:";
			// 
			// lTithePercent
			// 
			this.lTithePercent.AutoSize = true;
			this.lTithePercent.Location = new System.Drawing.Point(277, 60);
			this.lTithePercent.Name = "lTithePercent";
			this.lTithePercent.Size = new System.Drawing.Size(91, 25);
			this.lTithePercent.TabIndex = 9;
			this.lTithePercent.Text = "Tithe %:";
			// 
			// lNetWeeksDue
			// 
			this.lNetWeeksDue.AutoSize = true;
			this.lNetWeeksDue.Location = new System.Drawing.Point(14, 92);
			this.lNetWeeksDue.Name = "lNetWeeksDue";
			this.lNetWeeksDue.Size = new System.Drawing.Size(168, 25);
			this.lNetWeeksDue.TabIndex = 10;
			this.lNetWeeksDue.Text = "Net Weeks Due:";
			// 
			// lWeeksTilPay
			// 
			this.lWeeksTilPay.AutoSize = true;
			this.lWeeksTilPay.Location = new System.Drawing.Point(294, 95);
			this.lWeeksTilPay.Name = "lWeeksTilPay";
			this.lWeeksTilPay.Size = new System.Drawing.Size(150, 25);
			this.lWeeksTilPay.TabIndex = 11;
			this.lWeeksTilPay.Text = "Weeks Til Pay";
			// 
			// tbTaxPercent
			// 
			this.tbTaxPercent.Location = new System.Drawing.Point(95, 50);
			this.tbTaxPercent.Name = "tbTaxPercent";
			this.tbTaxPercent.Size = new System.Drawing.Size(100, 31);
			this.tbTaxPercent.TabIndex = 12;
			this.tbTaxPercent.Text = ".272";
			// 
			// tbTithePercent
			// 
			this.tbTithePercent.Location = new System.Drawing.Point(374, 54);
			this.tbTithePercent.Name = "tbTithePercent";
			this.tbTithePercent.Size = new System.Drawing.Size(100, 31);
			this.tbTithePercent.TabIndex = 13;
			this.tbTithePercent.Text = ".1";
			// 
			// tbNetWeeksDue
			// 
			this.tbNetWeeksDue.Location = new System.Drawing.Point(188, 89);
			this.tbNetWeeksDue.Name = "tbNetWeeksDue";
			this.tbNetWeeksDue.Size = new System.Drawing.Size(100, 31);
			this.tbNetWeeksDue.TabIndex = 14;
			this.tbNetWeeksDue.Text = "52";
			// 
			// tbWeeksTilPay
			// 
			this.tbWeeksTilPay.Location = new System.Drawing.Point(450, 95);
			this.tbWeeksTilPay.Name = "tbWeeksTilPay";
			this.tbWeeksTilPay.Size = new System.Drawing.Size(100, 31);
			this.tbWeeksTilPay.TabIndex = 15;
			this.tbWeeksTilPay.Text = "52";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 229);
			this.Controls.Add(this.tbWeeksTilPay);
			this.Controls.Add(this.tbNetWeeksDue);
			this.Controls.Add(this.tbTithePercent);
			this.Controls.Add(this.tbTaxPercent);
			this.Controls.Add(this.lWeeksTilPay);
			this.Controls.Add(this.lNetWeeksDue);
			this.Controls.Add(this.lTithePercent);
			this.Controls.Add(this.lTaxPercent);
			this.Controls.Add(this.butCalculate);
			this.Controls.Add(this.lDebug);
			this.Controls.Add(this.tbWinPercent);
			this.Controls.Add(this.lWinPercentage);
			this.Controls.Add(this.tbRateOfReturn);
			this.Controls.Add(this.lRateOfReturn);
			this.Controls.Add(this.lBaseAmount);
			this.Controls.Add(this.tbBaseAmount);
			this.Name = "Form1";
			this.Text = "Kelly Investing";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbBaseAmount;
		private System.Windows.Forms.Label lBaseAmount;
		private System.Windows.Forms.Label lRateOfReturn;
		private System.Windows.Forms.TextBox tbRateOfReturn;
		private System.Windows.Forms.Label lWinPercentage;
		private System.Windows.Forms.TextBox tbWinPercent;
		private System.Windows.Forms.Label lDebug;
		private System.Windows.Forms.Button butCalculate;
		private System.Windows.Forms.Label lTaxPercent;
		private System.Windows.Forms.Label lTithePercent;
		private System.Windows.Forms.Label lNetWeeksDue;
		private System.Windows.Forms.Label lWeeksTilPay;
		private System.Windows.Forms.TextBox tbTaxPercent;
		private System.Windows.Forms.TextBox tbTithePercent;
		private System.Windows.Forms.TextBox tbNetWeeksDue;
		private System.Windows.Forms.TextBox tbWeeksTilPay;
	}
}

