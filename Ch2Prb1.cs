/************************************************************/
/*                                                          */
/*  Course: CIS 350 - Data Structures                       */
/*                                                          */
/*  Project: Ch2Prb1.CSPrj                                  */
/*                                                          */
/*  Source Code: Ch2Prb1.CS                                 */
/*                                                          */
/*  Programmer: Megan Vest                                  */
/*                                                          */
/*  Purpose: Future value calculator.  Illustrates the use  */
/*  of the ETextBox class to make data validation easier.   */ 
/*                                                          */
/*  Classes: 1. Ch2Prb1Form: Form                           */
/*           2. Ch2Prb1App                                  */
/*                                                          */
/************************************************************/

using System;
using System.Windows.Forms;
using LibEnums;
using LibETextBox;

/***************************************************************/
/*  Begin namespace Ch2Prb1                                    */
/***************************************************************/ 
namespace Ch2Prb1
{
  /***************************************************************/
  /*  1. Begin main form class Ch2Prb1Form: Form                 */
  /***************************************************************/  
  public class Ch2Prb1Form: Form
  {
    private Label    monthlyInvestmentLabel;
    private ETextBox monthlyInvestmentETextBox;
    private Label    yearlyRateLabel;
    private ETextBox yearlyRateETextBox;
    private Label    yearsInputLabel;
    private ETextBox yearsInputETextBox;
    private Label    futureValueLabel;
    private Label    futureValueDisplay;
    private Button   calcButton;
    private Button   quitButton;
  
    public Ch2Prb1Form()
    {
      InitializeComponent();
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ch2Prb1Form));
      this.futureValueDisplay = new System.Windows.Forms.Label();
      this.quitButton = new System.Windows.Forms.Button();
      this.calcButton = new System.Windows.Forms.Button();
      this.futureValueLabel = new System.Windows.Forms.Label();
      this.yearsInputLabel = new System.Windows.Forms.Label();
      this.yearsInputETextBox = new LibETextBox.ETextBox();
      this.yearlyRateLabel = new System.Windows.Forms.Label();
      this.yearlyRateETextBox = new LibETextBox.ETextBox();
      this.monthlyInvestmentLabel = new System.Windows.Forms.Label();
      this.monthlyInvestmentETextBox = new LibETextBox.ETextBox();
      this.SuspendLayout();
      // 
      // futureValueDisplay
      // 
      this.futureValueDisplay.BackColor = System.Drawing.SystemColors.Control;
      this.futureValueDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.futureValueDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.futureValueDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.futureValueDisplay.Location = new System.Drawing.Point(372, 210);
      this.futureValueDisplay.Name = "futureValueDisplay";
      this.futureValueDisplay.Size = new System.Drawing.Size(203, 53);
      this.futureValueDisplay.TabIndex = 6;
      this.futureValueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // quitButton
      // 
      this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.quitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.quitButton.Location = new System.Drawing.Point(515, 292);
      this.quitButton.Name = "quitButton";
      this.quitButton.Size = new System.Drawing.Size(202, 55);
      this.quitButton.TabIndex = 11;
      this.quitButton.Text = "Quit";
      this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
      // 
      // calcButton
      // 
      this.calcButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.calcButton.Location = new System.Drawing.Point(288, 292);
      this.calcButton.Name = "calcButton";
      this.calcButton.Size = new System.Drawing.Size(208, 55);
      this.calcButton.TabIndex = 10;
      this.calcButton.Text = "Calculate";
      this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
      // 
      // futureValueLabel
      // 
      this.futureValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.futureValueLabel.Location = new System.Drawing.Point(370, 160);
      this.futureValueLabel.Name = "futureValueLabel";
      this.futureValueLabel.Size = new System.Drawing.Size(205, 50);
      this.futureValueLabel.TabIndex = 7;
      this.futureValueLabel.Text = "Future Value";
      this.futureValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // yearsInputLabel
      // 
      this.yearsInputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.yearsInputLabel.Location = new System.Drawing.Point(603, 45);
      this.yearsInputLabel.Name = "yearsInputLabel";
      this.yearsInputLabel.Size = new System.Drawing.Size(124, 50);
      this.yearsInputLabel.TabIndex = 5;
      this.yearsInputLabel.Text = "Years";
      this.yearsInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // yearsInputETextBox
      // 
      this.yearsInputETextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.yearsInputETextBox.Location = new System.Drawing.Point(579, 100);
      this.yearsInputETextBox.MaxLength = 6;
      this.yearsInputETextBox.Name = "yearsInputETextBox";
      this.yearsInputETextBox.Size = new System.Drawing.Size(183, 47);
      this.yearsInputETextBox.TabIndex = 4;
      this.yearsInputETextBox.Text = "0";
      this.yearsInputETextBox.TextChanged += new System.EventHandler(this.scoreETextBox_TextChanged);
      // 
      // yearlyRateLabel
      // 
      this.yearlyRateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.yearlyRateLabel.Location = new System.Drawing.Point(405, 9);
      this.yearlyRateLabel.Name = "yearlyRateLabel";
      this.yearlyRateLabel.Size = new System.Drawing.Size(126, 86);
      this.yearlyRateLabel.TabIndex = 3;
      this.yearlyRateLabel.Text = "Yearly Rate";
      this.yearlyRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // yearlyRateETextBox
      // 
      this.yearlyRateETextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.yearlyRateETextBox.Location = new System.Drawing.Point(382, 100);
      this.yearlyRateETextBox.MaxLength = 6;
      this.yearlyRateETextBox.Name = "yearlyRateETextBox";
      this.yearlyRateETextBox.Size = new System.Drawing.Size(176, 47);
      this.yearlyRateETextBox.TabIndex = 2;
      this.yearlyRateETextBox.Text = "0.0";
      this.yearlyRateETextBox.TextChanged += new System.EventHandler(this.scoreETextBox_TextChanged);
      // 
      // monthlyInvestmentLabel
      // 
      this.monthlyInvestmentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.monthlyInvestmentLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.monthlyInvestmentLabel.Location = new System.Drawing.Point(177, 9);
      this.monthlyInvestmentLabel.Name = "monthlyInvestmentLabel";
      this.monthlyInvestmentLabel.Size = new System.Drawing.Size(174, 86);
      this.monthlyInvestmentLabel.TabIndex = 1;
      this.monthlyInvestmentLabel.Text = "Monthly Investment";
      this.monthlyInvestmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.monthlyInvestmentLabel.Click += new System.EventHandler(this.monthlyInvestmentLabel_Click);
      // 
      // monthlyInvestmentETextBox
      // 
      this.monthlyInvestmentETextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.monthlyInvestmentETextBox.Location = new System.Drawing.Point(178, 100);
      this.monthlyInvestmentETextBox.MaxLength = 6;
      this.monthlyInvestmentETextBox.Name = "monthlyInvestmentETextBox";
      this.monthlyInvestmentETextBox.Size = new System.Drawing.Size(184, 47);
      this.monthlyInvestmentETextBox.TabIndex = 0;
      this.monthlyInvestmentETextBox.Text = "0.0";
      this.monthlyInvestmentETextBox.TextChanged += new System.EventHandler(this.scoreETextBox_TextChanged);
      // 
      // Ch2Prb1Form
      // 
      this.AcceptButton = this.calcButton;
      this.AutoScaleBaseSize = new System.Drawing.Size(15, 40);
      this.CancelButton = this.quitButton;
      this.ClientSize = new System.Drawing.Size(958, 446);
      this.Controls.Add(this.futureValueDisplay);
      this.Controls.Add(this.quitButton);
      this.Controls.Add(this.calcButton);
      this.Controls.Add(this.futureValueLabel);
      this.Controls.Add(this.yearsInputLabel);
      this.Controls.Add(this.yearsInputETextBox);
      this.Controls.Add(this.yearlyRateLabel);
      this.Controls.Add(this.yearlyRateETextBox);
      this.Controls.Add(this.monthlyInvestmentLabel);
      this.Controls.Add(this.monthlyInvestmentETextBox);
      this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Ch2Prb1Form";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ch2Prb1: Future Value Calculator (Megan Vest)";
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    /********************************************************/
    /*  Event Handlers                                      */
    /********************************************************/
    private void calcButton_Click(object sender, System.EventArgs e)
    {
      double  monthlyInvestment, yearlyRate, yearsInput, futureValue;

      if (monthlyInvestmentETextBox.ReadDouble(out monthlyInvestment, BoundsEnum.Both, 0.0, 100.0)) 
      if (yearlyRateETextBox.ReadDouble(out yearlyRate, BoundsEnum.Both, 0.0, 100.0))
      if (yearsInputETextBox.ReadDouble(out yearsInput, BoundsEnum.Both, 0.0, 100.0))  
      {
        futureValue = Math.Round(monthlyInvestment * (Math.Pow((1.0 + yearlyRate / 12.0), (yearsInput * 12)) - 1.0) / (yearlyRate / 12.0) * (1.0 + yearlyRate / 12.0), 2);
        monthlyInvestmentETextBox.Text = monthlyInvestment.ToString("0.00");
        yearlyRateETextBox.Text = yearlyRate.ToString("0.000");
        yearsInputETextBox.Text = yearsInput.ToString("0");
        futureValueDisplay.Text     = futureValue.ToString("n");
        monthlyInvestmentETextBox.SelectAll();
        monthlyInvestmentETextBox.Select();
      }  
    }

    private void quitButton_Click(object sender, System.EventArgs e)
    {
      Application.Exit();
    }

    private void scoreETextBox_TextChanged(object sender, System.EventArgs e)
    {
      futureValueDisplay.Text   = "";
    }

    private void monthlyInvestmentLabel_Click(object sender, EventArgs e)
    {

    }
  } // End main form class Ch2Prb1Form: Form

  /***************************************************************/
  /*  2. Begin application class Ch2Prb1App                      */
  /***************************************************************/
  public class Ch2Prb1App
  {
    static void Main()
    {
      Application.Run(new Ch2Prb1Form());
    }
  } // End application class Ch2Prb1App

} // End namespace Ch2Prb1
