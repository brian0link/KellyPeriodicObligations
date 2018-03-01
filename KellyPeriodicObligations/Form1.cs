using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace KellyPeriodicObligations
{
	public partial class Form1 : Form
	{
		public double dBaseAmount;
		public double dWinPercent;
		public double dRateOfReturn;
		public double dTaxPercent;
		public double dTithePercent;
		public int iNetWeeksDue;
		public int iWeeksTilPay;
		public double dTemp;
		public int iTemp;

		public Form1()
		{
			InitializeComponent();
		}

		private void butCalculate_Click(object sender, EventArgs e)
		{
			SetValues();
			PrintLines();
		}

		private void SetValues()
		{
			dBaseAmount = double.Parse(tbBaseAmount.Text);
			dWinPercent = double.Parse(tbWinPercent.Text);
			dRateOfReturn = double.Parse(tbRateOfReturn.Text);
			dTaxPercent = double.Parse(tbTaxPercent.Text);
			dTithePercent = double.Parse(tbTithePercent.Text);
			iNetWeeksDue = int.Parse(tbNetWeeksDue.Text);
			iWeeksTilPay = int.Parse(tbWeeksTilPay.Text);
		}

		private void PrintLines()
		{
			double KellyPercent = dWinPercent - ((1 - dWinPercent) / dRateOfReturn);

			double dInvest = Math.Round(dBaseAmount, 2);
			double dLastPaymentBase = Math.Round(dInvest, 2);
			double dReturn = Math.Round(dInvest * dRateOfReturn, 2);
			double dProfit = Math.Round(dReturn - dInvest, 2);
			double dLastPaymentProfit = Math.Round(dReturn - dLastPaymentBase, 2);
			double dTaxes = 0;
			double dTithe = 0;
			if (iWeeksTilPay == 0)
			{
				dLastPaymentProfit = Math.Round(dReturn - dLastPaymentBase, 2);
				dTaxes = Math.Round(dLastPaymentProfit * dTaxPercent, 2);
				dTithe = Math.Round((dLastPaymentProfit - dTaxes)*dTithePercent, 2);
				dLastPaymentBase = Math.Round(dInvest, 2);
			}
			double dRealProfit = Math.Round(dProfit - dTaxes - dTithe, 2);
			double dReinvest = Math.Round(dRealProfit * KellyPercent, 2);
			double dKeep = Math.Round(dRealProfit - dReinvest, 2);
			double dTotalKeep = Math.Round(dKeep, 2);
			double dTotalTax = Math.Round(dTaxes, 2);
			double dTotalTithe = Math.Round(dTithe, 2);
			double dPercentIncrease = Math.Round(100 * (dInvest - dBaseAmount) / dBaseAmount, 2);
			double dPercentProfit = Math.Round((100 * dProfit - dBaseAmount) / dBaseAmount, 2);
			double dPercentKeep = Math.Round((100 * dKeep - dBaseAmount) / dBaseAmount, 2);

			double iniWeeksTilPay = iWeeksTilPay;
			
			string path = @"C:\\projects\\KellyOutput.txt";

			// Check if file already exists. if yes, delete it. 
			if (File.Exists(path))
			{
				File.Delete(path);
			}

			if (!File.Exists(path))
			{
				// Create a file to write to.
				using (StreamWriter sw = File.CreateText(path))
				{
					sw.WriteLine("Invest:\tReturn:\tProfit:\tTaxes:\tTithe:\tReal Profit:\tReinvest:\tKeep:\t" +
						"Total Keep:\tTotal Tax:\tTotal Tithe:\t% Increase:\t% Profit:\t% Keep:");
					lDebug.Text = KellyPercent.ToString();

					for (int i = 0; i < 52; i++)
					{
						sw.WriteLine(dInvest + "\t" + dReturn + "\t" + dProfit + "\t" + dTaxes + "\t" + dTithe + "\t"
							+ dRealProfit + "\t" + dReinvest + "\t" + dKeep + "\t" + dTotalKeep + "\t" + dTotalTax + "\t" 
							+ dTotalTithe + "\t" + dPercentIncrease + "\t" + dPercentProfit + "\t" + dPercentKeep);
						if (iWeeksTilPay == 0)
						{
							sw.WriteLine("Owed Money Paid");
							iWeeksTilPay = iNetWeeksDue;
						}

						iWeeksTilPay--;
						dInvest += Math.Round(dReinvest, 2);
						dReturn = Math.Round(dInvest * dRateOfReturn, 2);
						dProfit = Math.Round(dReturn - dInvest, 2);
						dTaxes = 0;
						dTithe = 0;
						if (iWeeksTilPay == 0)
						{
							dLastPaymentProfit = Math.Round(dReturn - dLastPaymentBase, 2);
							dTaxes = Math.Round(dLastPaymentProfit * dTaxPercent, 2);
							dTithe = Math.Round( (dLastPaymentProfit - dTaxes)*dTithePercent, 2);
							dLastPaymentBase = Math.Round(dInvest, 2);
						}
						dRealProfit = Math.Round(dProfit - dTaxes - dTithe, 2);
						dReinvest = Math.Round(dRealProfit * KellyPercent, 2);
						dKeep = Math.Round(dRealProfit - dReinvest, 2);

						dTotalKeep += Math.Round(dKeep, 2);
						dTotalTax += Math.Round(dTaxes, 2);
						dTotalTithe += Math.Round(dTithe, 2);
						dPercentIncrease = Math.Round((100 * dInvest - dBaseAmount) / dBaseAmount, 2);
						dPercentProfit = Math.Round((100 * dProfit - dBaseAmount) / dBaseAmount, 2);
						dPercentKeep = Math.Round((100 * dTotalKeep - dBaseAmount) / dBaseAmount, 2);
					}
				}
			}
		}
	}
}
