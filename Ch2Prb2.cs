/************************************************************/
/*                                                          */
/*  Course: CIS 350 - Data Structures                       */
/*                                                          */
/*  Project: Ch2Prb2.CSPrj                                  */
/*                                                          */
/*  Source Code: Ch2Prb2.CS                                 */
/*                                                          */
/*  Programmer: Megan Vest                                  */
/*                                                          */
/*  Purpose: Floor Covering calculator.                     */
/*  Illustrates the use of an ETextBox Validationg event    */
/*  handler accomplish  data validation easier.             */
/*                                                          */
/*  Classes: 1. Ch2Prb2Form: Form                           */
/*           2. Ch2Prb2App                                  */
/*                                                          */
/************************************************************/

using System;
using System.Windows.Forms;
using System.ComponentModel;
using LibEnums;
using LibETextBox;

/***************************************************************/
/*  Begin namespace Ch2Prb2                                    */
/***************************************************************/
namespace Ch2Prb2
{
  /***************************************************************/
  /*  1. Begin main form class Ch2Prb2Form: Form                 */
  /***************************************************************/
  public class Ch2Prb2Form : Form
  {
    private Label hardwoodAreaLabel;
    private Label carpetAreaLabel;
    private Label tileAreaLabel;
    private ETextBox tileAreaETextBox;
    private Label installationLabel;
    private Label installationDisplay;
    private Label netSaleLabel;
    private Button calcButton;
    private ETextBox tilePriceeTextBox;
    private ETextBox carpetPriceeTextBox;
    private ETextBox hardwoodPriceeTextBox;
    private ETextBox hardwoodAreaeTextBox;
    private ETextBox carpetAreaeTextBox;
    private Label hardwoodPricelabel;
    private Label carpetPricelabel;
    private Label tilePricelabel;
    private Label discountedSaleDisplay;
    private Label discountDisplay;
    private Label grossSaleDisplay;
    private Label taxDisplay;
    private Label netSaleDisplay;
    private Label grossSalelabel;
    private Label discountlabel;
    private Label discountedSalelabel;
    private Label taxlabel;
    private GroupBox installationTypegroupBox;
    private RadioButton regionradioButton;
    private RadioButton localradioButton;
    private RadioButton noneradioButton;
    private GroupBox transactionTypegroupBox;
    private CheckBox taxExemptcheckBox;
    private CheckBox cashcheckBox;
    private Button quitButton;

    public Ch2Prb2Form()
    {
      InitializeComponent();
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ch2Prb2Form));
      this.installationDisplay = new System.Windows.Forms.Label();
      this.quitButton = new System.Windows.Forms.Button();
      this.calcButton = new System.Windows.Forms.Button();
      this.netSaleLabel = new System.Windows.Forms.Label();
      this.installationLabel = new System.Windows.Forms.Label();
      this.tileAreaLabel = new System.Windows.Forms.Label();
      this.tileAreaETextBox = new LibETextBox.ETextBox();
      this.carpetAreaLabel = new System.Windows.Forms.Label();
      this.hardwoodAreaLabel = new System.Windows.Forms.Label();
      this.tilePriceeTextBox = new LibETextBox.ETextBox();
      this.carpetPriceeTextBox = new LibETextBox.ETextBox();
      this.hardwoodPriceeTextBox = new LibETextBox.ETextBox();
      this.hardwoodAreaeTextBox = new LibETextBox.ETextBox();
      this.carpetAreaeTextBox = new LibETextBox.ETextBox();
      this.hardwoodPricelabel = new System.Windows.Forms.Label();
      this.carpetPricelabel = new System.Windows.Forms.Label();
      this.tilePricelabel = new System.Windows.Forms.Label();
      this.discountedSaleDisplay = new System.Windows.Forms.Label();
      this.discountDisplay = new System.Windows.Forms.Label();
      this.grossSaleDisplay = new System.Windows.Forms.Label();
      this.taxDisplay = new System.Windows.Forms.Label();
      this.netSaleDisplay = new System.Windows.Forms.Label();
      this.grossSalelabel = new System.Windows.Forms.Label();
      this.discountlabel = new System.Windows.Forms.Label();
      this.discountedSalelabel = new System.Windows.Forms.Label();
      this.taxlabel = new System.Windows.Forms.Label();
      this.installationTypegroupBox = new System.Windows.Forms.GroupBox();
      this.regionradioButton = new System.Windows.Forms.RadioButton();
      this.localradioButton = new System.Windows.Forms.RadioButton();
      this.noneradioButton = new System.Windows.Forms.RadioButton();
      this.transactionTypegroupBox = new System.Windows.Forms.GroupBox();
      this.taxExemptcheckBox = new System.Windows.Forms.CheckBox();
      this.cashcheckBox = new System.Windows.Forms.CheckBox();
      this.installationTypegroupBox.SuspendLayout();
      this.transactionTypegroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // installationDisplay
      // 
      this.installationDisplay.BackColor = System.Drawing.SystemColors.Control;
      this.installationDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.installationDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.installationDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.installationDisplay.Location = new System.Drawing.Point(481, 708);
      this.installationDisplay.Name = "installationDisplay";
      this.installationDisplay.Size = new System.Drawing.Size(171, 53);
      this.installationDisplay.TabIndex = 6;
      this.installationDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // quitButton
      // 
      this.quitButton.CausesValidation = false;
      this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.quitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.quitButton.Location = new System.Drawing.Point(601, 784);
      this.quitButton.Name = "quitButton";
      this.quitButton.Size = new System.Drawing.Size(188, 55);
      this.quitButton.TabIndex = 14;
      this.quitButton.Text = "Quit";
      this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
      // 
      // calcButton
      // 
      this.calcButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.calcButton.Location = new System.Drawing.Point(386, 784);
      this.calcButton.Name = "calcButton";
      this.calcButton.Size = new System.Drawing.Size(188, 55);
      this.calcButton.TabIndex = 13;
      this.calcButton.Text = "Calculate";
      this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
      // 
      // netSaleLabel
      // 
      this.netSaleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.netSaleLabel.Location = new System.Drawing.Point(765, 658);
      this.netSaleLabel.Name = "netSaleLabel";
      this.netSaleLabel.Size = new System.Drawing.Size(193, 50);
      this.netSaleLabel.TabIndex = 9;
      this.netSaleLabel.Text = "Net Sale ($)";
      this.netSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // installationLabel
      // 
      this.installationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.installationLabel.Location = new System.Drawing.Point(474, 658);
      this.installationLabel.Name = "installationLabel";
      this.installationLabel.Size = new System.Drawing.Size(217, 50);
      this.installationLabel.TabIndex = 7;
      this.installationLabel.Text = "Installation ($)";
      this.installationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tileAreaLabel
      // 
      this.tileAreaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tileAreaLabel.Location = new System.Drawing.Point(807, 63);
      this.tileAreaLabel.Name = "tileAreaLabel";
      this.tileAreaLabel.Size = new System.Drawing.Size(249, 50);
      this.tileAreaLabel.TabIndex = 9;
      this.tileAreaLabel.Text = "Tile Area (sq ft)";
      this.tileAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tileAreaETextBox
      // 
      this.tileAreaETextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tileAreaETextBox.Location = new System.Drawing.Point(825, 116);
      this.tileAreaETextBox.MaxLength = 6;
      this.tileAreaETextBox.Name = "tileAreaETextBox";
      this.tileAreaETextBox.Size = new System.Drawing.Size(210, 47);
      this.tileAreaETextBox.TabIndex = 10;
      this.tileAreaETextBox.Text = "0.00";
      this.tileAreaETextBox.TextChanged += new System.EventHandler(this.tileAreaETextBox_TextChanged);
      this.tileAreaETextBox.Validating += new System.ComponentModel.CancelEventHandler(this.tileAreaETextBox_Validating);
      this.tileAreaETextBox.Validated += new System.EventHandler(this.tileAreaETextBox_Validated);
      // 
      // carpetAreaLabel
      // 
      this.carpetAreaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.carpetAreaLabel.Location = new System.Drawing.Point(403, 45);
      this.carpetAreaLabel.Name = "carpetAreaLabel";
      this.carpetAreaLabel.Size = new System.Drawing.Size(362, 50);
      this.carpetAreaLabel.TabIndex = 5;
      this.carpetAreaLabel.Text = "Carpet Area (sq yards)";
      this.carpetAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // hardwoodAreaLabel
      // 
      this.hardwoodAreaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.hardwoodAreaLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.hardwoodAreaLabel.Location = new System.Drawing.Point(47, 45);
      this.hardwoodAreaLabel.Name = "hardwoodAreaLabel";
      this.hardwoodAreaLabel.Size = new System.Drawing.Size(350, 50);
      this.hardwoodAreaLabel.TabIndex = 1;
      this.hardwoodAreaLabel.Text = "Hardwood Area (sq ft)";
      this.hardwoodAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tilePriceeTextBox
      // 
      this.tilePriceeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tilePriceeTextBox.Location = new System.Drawing.Point(825, 219);
      this.tilePriceeTextBox.MaxLength = 6;
      this.tilePriceeTextBox.Name = "tilePriceeTextBox";
      this.tilePriceeTextBox.Size = new System.Drawing.Size(210, 47);
      this.tilePriceeTextBox.TabIndex = 12;
      this.tilePriceeTextBox.Text = "0.00";
      this.tilePriceeTextBox.TextChanged += new System.EventHandler(this.tilePriceeTextBox_TextChanged);
      this.tilePriceeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.tilePriceeTextBox_Validating);
      this.tilePriceeTextBox.Validated += new System.EventHandler(this.tilePriceeTextBox_Validated);
      // 
      // carpetPriceeTextBox
      // 
      this.carpetPriceeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.carpetPriceeTextBox.Location = new System.Drawing.Point(481, 219);
      this.carpetPriceeTextBox.MaxLength = 6;
      this.carpetPriceeTextBox.Name = "carpetPriceeTextBox";
      this.carpetPriceeTextBox.Size = new System.Drawing.Size(210, 47);
      this.carpetPriceeTextBox.TabIndex = 8;
      this.carpetPriceeTextBox.Text = "0.00";
      this.carpetPriceeTextBox.TextChanged += new System.EventHandler(this.carpetPriceeTextBox_TextChanged);
      this.carpetPriceeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.carpetPriceeTextBox_Validating);
      this.carpetPriceeTextBox.Validated += new System.EventHandler(this.carpetPriceeTextBox_Validated);
      // 
      // hardwoodPriceeTextBox
      // 
      this.hardwoodPriceeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.hardwoodPriceeTextBox.Location = new System.Drawing.Point(115, 219);
      this.hardwoodPriceeTextBox.MaxLength = 6;
      this.hardwoodPriceeTextBox.Name = "hardwoodPriceeTextBox";
      this.hardwoodPriceeTextBox.Size = new System.Drawing.Size(210, 47);
      this.hardwoodPriceeTextBox.TabIndex = 4;
      this.hardwoodPriceeTextBox.Text = "0.00";
      this.hardwoodPriceeTextBox.TextChanged += new System.EventHandler(this.hardwoodPriceeTextBox_TextChanged);
      this.hardwoodPriceeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.hardwoodPriceeTextBox_Validating);
      this.hardwoodPriceeTextBox.Validated += new System.EventHandler(this.hardwoodPriceeTextBox_Validated);
      // 
      // hardwoodAreaeTextBox
      // 
      this.hardwoodAreaeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.hardwoodAreaeTextBox.Location = new System.Drawing.Point(115, 116);
      this.hardwoodAreaeTextBox.MaxLength = 6;
      this.hardwoodAreaeTextBox.Name = "hardwoodAreaeTextBox";
      this.hardwoodAreaeTextBox.Size = new System.Drawing.Size(210, 47);
      this.hardwoodAreaeTextBox.TabIndex = 2;
      this.hardwoodAreaeTextBox.Text = "0.00";
      this.hardwoodAreaeTextBox.TextChanged += new System.EventHandler(this.hardwoodAreaeTextBox_TextChanged);
      this.hardwoodAreaeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.hardwoodAreaeTextBox_Validating);
      this.hardwoodAreaeTextBox.Validated += new System.EventHandler(this.hardwoodAreaeTextBox_Validated);
      // 
      // carpetAreaeTextBox
      // 
      this.carpetAreaeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.carpetAreaeTextBox.Location = new System.Drawing.Point(481, 116);
      this.carpetAreaeTextBox.MaxLength = 6;
      this.carpetAreaeTextBox.Name = "carpetAreaeTextBox";
      this.carpetAreaeTextBox.Size = new System.Drawing.Size(210, 47);
      this.carpetAreaeTextBox.TabIndex = 6;
      this.carpetAreaeTextBox.Text = "0.00";
      this.carpetAreaeTextBox.TextChanged += new System.EventHandler(this.carpetAreaeTextBox_TextChanged);
      this.carpetAreaeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.carpetAreaeTextBox_Validating);
      this.carpetAreaeTextBox.Validated += new System.EventHandler(this.carpetAreaeTextBox_Validated);
      // 
      // hardwoodPricelabel
      // 
      this.hardwoodPricelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.hardwoodPricelabel.Location = new System.Drawing.Point(35, 166);
      this.hardwoodPricelabel.Name = "hardwoodPricelabel";
      this.hardwoodPricelabel.Size = new System.Drawing.Size(362, 50);
      this.hardwoodPricelabel.TabIndex = 3;
      this.hardwoodPricelabel.Text = "Hardwood Price ($/sqft)";
      this.hardwoodPricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // carpetPricelabel
      // 
      this.carpetPricelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.carpetPricelabel.Location = new System.Drawing.Point(410, 166);
      this.carpetPricelabel.Name = "carpetPricelabel";
      this.carpetPricelabel.Size = new System.Drawing.Size(355, 50);
      this.carpetPricelabel.TabIndex = 7;
      this.carpetPricelabel.Text = "Carpet Price ($/sq yard)";
      this.carpetPricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tilePricelabel
      // 
      this.tilePricelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tilePricelabel.Location = new System.Drawing.Point(807, 166);
      this.tilePricelabel.Name = "tilePricelabel";
      this.tilePricelabel.Size = new System.Drawing.Size(249, 50);
      this.tilePricelabel.TabIndex = 11;
      this.tilePricelabel.Text = "Tile Price ($/sq ft)";
      this.tilePricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // discountedSaleDisplay
      // 
      this.discountedSaleDisplay.BackColor = System.Drawing.SystemColors.Control;
      this.discountedSaleDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.discountedSaleDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.discountedSaleDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.discountedSaleDisplay.Location = new System.Drawing.Point(772, 584);
      this.discountedSaleDisplay.Name = "discountedSaleDisplay";
      this.discountedSaleDisplay.Size = new System.Drawing.Size(171, 53);
      this.discountedSaleDisplay.TabIndex = 22;
      this.discountedSaleDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // discountDisplay
      // 
      this.discountDisplay.BackColor = System.Drawing.SystemColors.Control;
      this.discountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.discountDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.discountDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.discountDisplay.Location = new System.Drawing.Point(481, 584);
      this.discountDisplay.Name = "discountDisplay";
      this.discountDisplay.Size = new System.Drawing.Size(171, 53);
      this.discountDisplay.TabIndex = 23;
      this.discountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // grossSaleDisplay
      // 
      this.grossSaleDisplay.BackColor = System.Drawing.SystemColors.Control;
      this.grossSaleDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.grossSaleDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grossSaleDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.grossSaleDisplay.Location = new System.Drawing.Point(187, 584);
      this.grossSaleDisplay.Name = "grossSaleDisplay";
      this.grossSaleDisplay.Size = new System.Drawing.Size(171, 53);
      this.grossSaleDisplay.TabIndex = 24;
      this.grossSaleDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // taxDisplay
      // 
      this.taxDisplay.BackColor = System.Drawing.SystemColors.Control;
      this.taxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.taxDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.taxDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.taxDisplay.Location = new System.Drawing.Point(187, 708);
      this.taxDisplay.Name = "taxDisplay";
      this.taxDisplay.Size = new System.Drawing.Size(171, 53);
      this.taxDisplay.TabIndex = 25;
      this.taxDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // netSaleDisplay
      // 
      this.netSaleDisplay.BackColor = System.Drawing.SystemColors.Control;
      this.netSaleDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.netSaleDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.netSaleDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.netSaleDisplay.Location = new System.Drawing.Point(772, 708);
      this.netSaleDisplay.Name = "netSaleDisplay";
      this.netSaleDisplay.Size = new System.Drawing.Size(171, 53);
      this.netSaleDisplay.TabIndex = 26;
      this.netSaleDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // grossSalelabel
      // 
      this.grossSalelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grossSalelabel.Location = new System.Drawing.Point(171, 534);
      this.grossSalelabel.Name = "grossSalelabel";
      this.grossSalelabel.Size = new System.Drawing.Size(217, 50);
      this.grossSalelabel.TabIndex = 27;
      this.grossSalelabel.Text = "Gross Sale ($)";
      this.grossSalelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // discountlabel
      // 
      this.discountlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.discountlabel.Location = new System.Drawing.Point(474, 534);
      this.discountlabel.Name = "discountlabel";
      this.discountlabel.Size = new System.Drawing.Size(217, 50);
      this.discountlabel.TabIndex = 28;
      this.discountlabel.Text = "Discount ($)";
      this.discountlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // discountedSalelabel
      // 
      this.discountedSalelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.discountedSalelabel.Location = new System.Drawing.Point(714, 534);
      this.discountedSalelabel.Name = "discountedSalelabel";
      this.discountedSalelabel.Size = new System.Drawing.Size(302, 50);
      this.discountedSalelabel.TabIndex = 29;
      this.discountedSalelabel.Text = "Discounted Sale ($)";
      this.discountedSalelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // taxlabel
      // 
      this.taxlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.taxlabel.Location = new System.Drawing.Point(171, 658);
      this.taxlabel.Name = "taxlabel";
      this.taxlabel.Size = new System.Drawing.Size(217, 50);
      this.taxlabel.TabIndex = 30;
      this.taxlabel.Text = "Tax ($)";
      this.taxlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // installationTypegroupBox
      // 
      this.installationTypegroupBox.Controls.Add(this.regionradioButton);
      this.installationTypegroupBox.Controls.Add(this.localradioButton);
      this.installationTypegroupBox.Controls.Add(this.noneradioButton);
      this.installationTypegroupBox.Location = new System.Drawing.Point(274, 282);
      this.installationTypegroupBox.Name = "installationTypegroupBox";
      this.installationTypegroupBox.Size = new System.Drawing.Size(261, 233);
      this.installationTypegroupBox.TabIndex = 15;
      this.installationTypegroupBox.TabStop = false;
      this.installationTypegroupBox.Text = "Installation Type";
      // 
      // regionradioButton
      // 
      this.regionradioButton.AutoSize = true;
      this.regionradioButton.Location = new System.Drawing.Point(3, 172);
      this.regionradioButton.Name = "regionradioButton";
      this.regionradioButton.Size = new System.Drawing.Size(151, 45);
      this.regionradioButton.TabIndex = 2;
      this.regionradioButton.Text = "Region";
      this.regionradioButton.UseVisualStyleBackColor = true;
      // 
      // localradioButton
      // 
      this.localradioButton.AutoSize = true;
      this.localradioButton.Checked = true;
      this.localradioButton.Location = new System.Drawing.Point(3, 121);
      this.localradioButton.Name = "localradioButton";
      this.localradioButton.Size = new System.Drawing.Size(126, 45);
      this.localradioButton.TabIndex = 1;
      this.localradioButton.TabStop = true;
      this.localradioButton.Text = "Local";
      this.localradioButton.UseVisualStyleBackColor = true;
      // 
      // noneradioButton
      // 
      this.noneradioButton.AutoSize = true;
      this.noneradioButton.Location = new System.Drawing.Point(3, 70);
      this.noneradioButton.Name = "noneradioButton";
      this.noneradioButton.Size = new System.Drawing.Size(130, 45);
      this.noneradioButton.TabIndex = 2;
      this.noneradioButton.Text = "None";
      this.noneradioButton.UseVisualStyleBackColor = true;
      // 
      // transactionTypegroupBox
      // 
      this.transactionTypegroupBox.Controls.Add(this.taxExemptcheckBox);
      this.transactionTypegroupBox.Controls.Add(this.cashcheckBox);
      this.transactionTypegroupBox.Location = new System.Drawing.Point(601, 282);
      this.transactionTypegroupBox.Name = "transactionTypegroupBox";
      this.transactionTypegroupBox.Size = new System.Drawing.Size(270, 233);
      this.transactionTypegroupBox.TabIndex = 16;
      this.transactionTypegroupBox.TabStop = false;
      this.transactionTypegroupBox.Text = "Transaction Type";
      // 
      // taxExemptcheckBox
      // 
      this.taxExemptcheckBox.AutoSize = true;
      this.taxExemptcheckBox.Location = new System.Drawing.Point(6, 142);
      this.taxExemptcheckBox.Name = "taxExemptcheckBox";
      this.taxExemptcheckBox.Size = new System.Drawing.Size(212, 45);
      this.taxExemptcheckBox.TabIndex = 1;
      this.taxExemptcheckBox.Text = "Tax Exempt";
      this.taxExemptcheckBox.UseVisualStyleBackColor = true;
      // 
      // cashcheckBox
      // 
      this.cashcheckBox.AutoSize = true;
      this.cashcheckBox.Location = new System.Drawing.Point(6, 70);
      this.cashcheckBox.Name = "cashcheckBox";
      this.cashcheckBox.Size = new System.Drawing.Size(121, 45);
      this.cashcheckBox.TabIndex = 0;
      this.cashcheckBox.Text = "Cash";
      this.cashcheckBox.UseVisualStyleBackColor = true;
      // 
      // Ch2Prb2Form
      // 
      this.AcceptButton = this.calcButton;
      this.AutoScaleBaseSize = new System.Drawing.Size(15, 40);
      this.CancelButton = this.quitButton;
      this.CausesValidation = false;
      this.ClientSize = new System.Drawing.Size(1098, 1023);
      this.Controls.Add(this.transactionTypegroupBox);
      this.Controls.Add(this.installationTypegroupBox);
      this.Controls.Add(this.taxlabel);
      this.Controls.Add(this.discountedSalelabel);
      this.Controls.Add(this.discountlabel);
      this.Controls.Add(this.grossSalelabel);
      this.Controls.Add(this.netSaleDisplay);
      this.Controls.Add(this.taxDisplay);
      this.Controls.Add(this.grossSaleDisplay);
      this.Controls.Add(this.discountDisplay);
      this.Controls.Add(this.discountedSaleDisplay);
      this.Controls.Add(this.tilePricelabel);
      this.Controls.Add(this.carpetPricelabel);
      this.Controls.Add(this.hardwoodPricelabel);
      this.Controls.Add(this.carpetAreaeTextBox);
      this.Controls.Add(this.hardwoodAreaeTextBox);
      this.Controls.Add(this.hardwoodPriceeTextBox);
      this.Controls.Add(this.carpetPriceeTextBox);
      this.Controls.Add(this.tilePriceeTextBox);
      this.Controls.Add(this.installationDisplay);
      this.Controls.Add(this.quitButton);
      this.Controls.Add(this.calcButton);
      this.Controls.Add(this.netSaleLabel);
      this.Controls.Add(this.installationLabel);
      this.Controls.Add(this.tileAreaLabel);
      this.Controls.Add(this.tileAreaETextBox);
      this.Controls.Add(this.carpetAreaLabel);
      this.Controls.Add(this.hardwoodAreaLabel);
      this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Ch2Prb2Form";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Floor Covering Cost Calculator (Megan Vest)";
      this.Load += new System.EventHandler(this.Ch2Prb2Form_Load);
      this.installationTypegroupBox.ResumeLayout(false);
      this.installationTypegroupBox.PerformLayout();
      this.transactionTypegroupBox.ResumeLayout(false);
      this.transactionTypegroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    /********************************************************/
    /*  Event Handlers                                      */
    /********************************************************/
    private void calcButton_Click(object sender, System.EventArgs e)
    {
      double hardwoodArea, carpetArea, tileArea, hardwoodPrice, carpetPrice,
        tilePrice, hardInstallationValue = 0.0, carpetInstallationValue = 0.0, tileInstallationValue = 0.0,
        installationValue = 0.0, netValue, taxValue, grossSaleValue, discountValue = 0.0,
        discountedSaleValue, hardwoodValue, carpetValue, tileValue;

      if (hardwoodAreaeTextBox.ReadDouble(out hardwoodArea, BoundsEnum.Both, 0.0, 100.0))
      if (hardwoodPriceeTextBox.ReadDouble(out hardwoodPrice, BoundsEnum.Both, 0.0, 100.0))
      if (carpetAreaeTextBox.ReadDouble(out carpetArea, BoundsEnum.Both, 0.0, 100.0))
      if (carpetPriceeTextBox.ReadDouble(out carpetPrice, BoundsEnum.Both, 0.0, 100.0))
      if (tileAreaETextBox.ReadDouble(out tileArea, BoundsEnum.Both, 0.0, 100.0))
      if (tilePriceeTextBox.ReadDouble(out tilePrice, BoundsEnum.Both, 0.0, 100.0))
         {
          hardwoodArea = double.Parse(hardwoodAreaeTextBox.Text);
          carpetArea = double.Parse(carpetAreaeTextBox.Text);
          tileArea = double.Parse(tileAreaETextBox.Text);
          hardwoodPrice = double.Parse(hardwoodPriceeTextBox.Text);
          carpetPrice = double.Parse(carpetPriceeTextBox.Text);
          tilePrice = double.Parse(tilePriceeTextBox.Text);

          hardwoodAreaeTextBox.SelectAll();
          carpetAreaeTextBox.SelectAll();
          tileAreaETextBox.SelectAll();
          hardwoodAreaeTextBox.Select();
          carpetAreaeTextBox.Select();
          tileAreaETextBox.Select();

          hardwoodValue = hardwoodArea * hardwoodPrice;
          carpetValue = carpetArea * carpetPrice;
          tileValue = tileArea * tilePrice;
          grossSaleValue = Math.Round(hardwoodValue + carpetValue + tileValue, 2);
          discountedSaleValue = grossSaleValue - discountValue;
         
          
          if (cashcheckBox.Checked)
           discountValue = Math.Round(grossSaleValue * .02, 2);
          else if (taxExemptcheckBox.Checked)
           taxValue = 0.0;
          else
           discountValue = 0.00;
           taxValue = .0725 * grossSaleValue;
           netValue = Math.Round(discountedSaleValue + taxValue + installationValue, 2);
           if (localradioButton.Checked)
            {
             if (hardwoodArea != 0)
             hardInstallationValue = Math.Round(.75 * hardwoodArea, 2);
             else if (carpetArea != 0)
             carpetInstallationValue = Math.Round(.75 * carpetArea, 2);
             else if (tileArea != 0)
             tileInstallationValue = Math.Round(.75 * tileArea, 2);
             else
             installationValue = 0.00;
            }
           else if (regionradioButton.Checked)
            {
             if (hardwoodArea != 0)
             installationValue = 50 + (hardwoodArea * .75);
             else if (carpetArea != 0)
             installationValue = 50 + (carpetArea * .75);
             else if (tileArea != 0)
             installationValue = 50 + (tileArea * .75);
             else
             installationValue = 0.0;
            }
           else
           installationValue = 0.0;
                  installationValue = Math.Round(hardInstallationValue + carpetInstallationValue + tileInstallationValue, 2);

                  grossSaleDisplay.Text = grossSaleValue.ToString("n2");
                  discountDisplay.Text = discountValue.ToString("n2");
                  discountedSaleDisplay.Text = discountedSaleValue.ToString("n2");
                  taxDisplay.Text = taxValue.ToString("n2");
                  installationDisplay.Text = installationValue.ToString("n2");
                  netSaleDisplay.Text = netValue.ToString("n2");
          }
    }

    private void quitButton_Click(object sender, System.EventArgs e)
    {
      Application.Exit();
    }

    private void hardwoodAreaeTextBox_TextChanged(object sender, System.EventArgs e)
    {
      grossSaleDisplay.Text = "";
      discountDisplay.Text = "";
      discountedSaleDisplay.Text = "";
      taxDisplay.Text = "";
      installationDisplay.Text = "";
      netSaleDisplay.Text = "";
    }

    private void hardwoodPriceeTextBox_TextChanged(object sender, System.EventArgs e)
    {
      grossSaleDisplay.Text = "";
      discountDisplay.Text = "";
      discountedSaleDisplay.Text = "";
      taxDisplay.Text = "";
      installationDisplay.Text = "";
      netSaleDisplay.Text = "";
    }

    private void carpetAreaeTextBox_TextChanged(object sender, System.EventArgs e)
    {
      grossSaleDisplay.Text = "";
      discountDisplay.Text = "";
      discountedSaleDisplay.Text = "";
      taxDisplay.Text = "";
      installationDisplay.Text = "";
      netSaleDisplay.Text = "";
    }

    private void carpetPriceeTextBox_TextChanged(object sender, System.EventArgs e)
    {
      grossSaleDisplay.Text = "";
      discountDisplay.Text = "";
      discountedSaleDisplay.Text = "";
      taxDisplay.Text = "";
      installationDisplay.Text = "";
      netSaleDisplay.Text = "";
    }

    private void tileAreaETextBox_TextChanged(object sender, System.EventArgs e)
    {
      grossSaleDisplay.Text = "";
      discountDisplay.Text = "";
      discountedSaleDisplay.Text = "";
      taxDisplay.Text = "";
      installationDisplay.Text = "";
      netSaleDisplay.Text = "";
    }

    private void tilePriceeTextBox_TextChanged(object sender, System.EventArgs e)
    {
      grossSaleDisplay.Text = "";
      discountDisplay.Text = "";
      discountedSaleDisplay.Text = "";
      taxDisplay.Text = "";
      installationDisplay.Text = "";
      netSaleDisplay.Text = "";
    }

    private void hardwoodAreaeTextBox_Validating(object sender, CancelEventArgs e)
    {
      bool valueOk = false;
      double score;
      ETextBox hardwoodAreaeTextBox = (ETextBox)sender;

      if (hardwoodAreaeTextBox.ReadDouble(out score, BoundsEnum.Both, 0.0, 100.0))
        valueOk = true;
      e.Cancel = !valueOk;
    }

    private void hardwoodPriceeTextBox_Validating(object sender, CancelEventArgs e)
    {
      bool valueOk = false;
      double score;
      ETextBox hardwoodPriceeTextBox = (ETextBox)sender;

      if (hardwoodPriceeTextBox.ReadDouble(out score, BoundsEnum.Both, 0.0, 100.0))
        valueOk = true;
      e.Cancel = !valueOk;
    }

    private void carpetAreaeTextBox_Validating(object sender, CancelEventArgs e)
    {
      bool valueOk = false;
      double score;
      ETextBox carpetAreaeTextBox = (ETextBox)sender;

      if (carpetAreaeTextBox.ReadDouble(out score, BoundsEnum.Both, 0.0, 100.0))
        valueOk = true;
      e.Cancel = !valueOk;
    }

    private void carpetPriceeTextBox_Validating(object sender, CancelEventArgs e)
    {
      bool valueOk = false;
      double score;
      ETextBox carpetPriceeTextBox = (ETextBox)sender;

      if (carpetPriceeTextBox.ReadDouble(out score, BoundsEnum.Both, 0.0, 100.0))
        valueOk = true;
      e.Cancel = !valueOk;
    }

    private void tileAreaETextBox_Validating(object sender, CancelEventArgs e)
    {
      bool valueOk = false;
      double score;
      ETextBox tileAreaETextBox = (ETextBox)sender;

      if (tileAreaETextBox.ReadDouble(out score, BoundsEnum.Both, 0.0, 100.0))
        valueOk = true;
      e.Cancel = !valueOk;
    }

    private void tilePriceeTextBox_Validating(object sender, CancelEventArgs e)
    {
      bool valueOk = false;
      double score;
      ETextBox tilePriceeTextBox = (ETextBox)sender;

      if (tilePriceeTextBox.ReadDouble(out score, BoundsEnum.Both, 0.0, 100.0))
        valueOk = true;
      e.Cancel = !valueOk;
    }

    private void hardwoodAreaeTextBox_Validated(object sender, EventArgs e)
    {
      ETextBox hardwoodAreaeTextBox = (ETextBox)sender;

      hardwoodAreaeTextBox.Text = Double.Parse(hardwoodAreaeTextBox.Text).ToString("f");
    }

    private void hardwoodPriceeTextBox_Validated(object sender, EventArgs e)
    {
      ETextBox hardwoodPriceeTextBox = (ETextBox)sender;

      hardwoodPriceeTextBox.Text = Double.Parse(hardwoodPriceeTextBox.Text).ToString("f");
    }

    private void carpetAreaeTextBox_Validated(object sender, EventArgs e)
    {
      ETextBox carpetAreaeTextBox = (ETextBox)sender;

      carpetAreaeTextBox.Text = Double.Parse(carpetAreaeTextBox.Text).ToString("f");
    }

    private void carpetPriceeTextBox_Validated(object sender, EventArgs e)
    {
      ETextBox carpetPriceeTextBox = (ETextBox)sender;

      carpetPriceeTextBox.Text = Double.Parse(carpetPriceeTextBox.Text).ToString("f");
    }

    private void tileAreaETextBox_Validated(object sender, EventArgs e)
    {
      ETextBox tileAreaETextBox = (ETextBox)sender;

      tileAreaETextBox.Text = Double.Parse(tileAreaETextBox.Text).ToString("f");
    }

    private void tilePriceeTextBox_Validated(object sender, EventArgs e)
    {
      ETextBox tilePriceeTextBox = (ETextBox)sender;

      tilePriceeTextBox.Text = Double.Parse(tilePriceeTextBox.Text).ToString("f");
    }

    // Prevent ETextBox validating if Esc key pressed
    protected override bool ProcessDialogKey(Keys keyData)
    {
      bool returnValue;

      if (keyData == Keys.Escape)
      {
        this.AutoValidate = AutoValidate.Disable;
        CancelButton.PerformClick();
        this.AutoValidate = AutoValidate.Inherit;
        returnValue = true;
      }
      else
        returnValue = base.ProcessDialogKey(keyData);
      return returnValue;
    }

    // Prevent ETextBox validating if form's red X close button clicked
    protected override void WndProc(ref Message m)
    {
      if (m.Msg == 0x10)
        this.AutoValidate = AutoValidate.Disable;
      base.WndProc(ref m);
    }

    private void Ch2Prb2Form_Load(object sender, EventArgs e)
    {

    }
  } // End main form class Ch2Prb2Form: Form

  /***************************************************************/
  /*  2. Begin application class Ch2Prb2App                      */
  /***************************************************************/
  public class Ch2Prb2App
  {
    static void Main()
    {
      Application.Run(new Ch2Prb2Form());
    }
  } // End application class Ch2Prb2App

} // End namespace Ch2Prb2
