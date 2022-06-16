/*********************************************************************/
/*                                                                   */
/*  Course: CIS 350 - Datastructures                                 */
/*                                                                   */
/*  Project: Ch3Prb1.CSPrj                                           */
/*                                                                   */
/*  Source File: Ch3Prb1.CS                                          */
/*                                                                   */
/*  Programmer: Megan Vest                                           */
/*                                                                   */
/*  Purpose: Employee list maintenance.  Demostrates a forms-based   */
/*           Windoes application that contains MenuStrip, ToolStrip  */
/*           and DataGridView controls.  Add is accomplished with a  */
/*           dialog box.  Update is implemented via cell editing.    */
/*                                                                   */
/*  Classes: 1. Ch3SPrb1Form: Form                                   */
/*           2. Ch3Prb1App                                           */
/*                                                                   */
/*********************************************************************/

using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using LibDate;
using LibEnums;
using LibETextBoxCell;
using LibETextBox;
using LibEList;
using LibEmployee2;

/**********************************************************/
/*  Begin partial namespace Ch3Smp3                       */
/**********************************************************/
namespace Ch3Smp3
{
  /**********************************************************/
  /*  1. Begin main form class Ch3Prb1Form: Form            */
  /**********************************************************/
  public class Ch3Prb1Form : Form
  {
    private const string DAT_FILE_NAME = "EmployeeDat.Csv";
    private const string RPT_FILE_NAME = "EmployeeRpt.Txt";

    public static string[] validTypes = {"Supervisor","Hourly","Piece",
                                          "Commission"};

    private MenuStrip mainMenu;
    private ToolStripMenuItem fileMenuItem;
    private ToolStripMenuItem createReportMenuItem;
    private ToolStripMenuItem createReportallMenuItem;
    private ToolStripMenuItem createReportsupervisorMenuItem;
    private ToolStripMenuItem createReporthourlyMenuItem;
    private ToolStripMenuItem createReportpieceMenuItem;
    private ToolStripMenuItem createReportcommissionMenuItem;
    private ToolStripMenuItem createReportSelectedMenuItem;
    private ToolStripMenuItem viewReportMenuItem;
    private ToolStripSeparator seperator1MenuItem;
    private ToolStripMenuItem exitMenuItem;
    private ToolStripMenuItem editMenuItem;
    private ToolStripMenuItem addMenuItem;
    private ToolStripMenuItem updateMenuItem;
    private ToolStripMenuItem deleteMenuItem;
    private ToolStripMenuItem helpMenuItem;
    private ToolStripMenuItem aboutMenuItem;
    private ContextMenuStrip dgvContextMenu;
    //private ContextMenuStrip           gridViewContextMenu;
    private ToolStripMenuItem addContextMenuItem;
    private ToolStripMenuItem updateContextMenuItem;
    private ToolStripMenuItem deleteContextMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem viewMenuItem;
    private ToolStripMenuItem refreshMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem refreshToolStripMenuItem;
    private ToolStripMenuItem refreshContextMenuItem;
    private ToolStripMenuItem viewAllMenuItem;
    private ToolStripMenuItem viewSupervisorMenuItem;
    private ToolStripMenuItem viewHourlyMenuItem;
    private ToolStripMenuItem viewPieceMenuItem;
    private ToolStripMenuItem viewCommissionMenuItem;
    private ToolStripMenuItem viewAllContextMenuItem;
    private ToolStripMenuItem viewSupervisorContextMenuItem;
    private ToolStripMenuItem viewHourlyContextMenuItem;
    private ToolStripMenuItem viewPieceContextMenuItem;
    private ToolStripMenuItem viewCommissionContextMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStrip navigatorToolStrip;
    private ToolStripButton navigatorMoveFirstItem;
    private ToolStripButton navigatorMovePreviousItem;
    private ToolStripTextBox navigatorPositionItem;
    private ToolStripLabel navigatorCountItem;
    private ToolStripButton navigatorMoveNextItem;
    private ToolStripButton navigatorMoveLastItem;
    private ToolStripButton navigatorAddNewItem;
    private ToolStripButton navigatorUpdateNewItem;
    private ToolStripButton navigatorDeleteItem;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripLabel navigatorFindLabelItem;
    private ToolStripTextBox navigatorFindTextBoxItem;
    private DataGridView dataGridView;
    private IContainer components;
    private bool suppressCellValidating;
    private EmployeeList.OrderEnum listOrder;
    private DataGridViewTextBoxColumn employeeIDCol;
    private DataGridViewTextBoxColumn nameCol;
    private DataGridViewTextBoxColumn hireDateCol;
    private DataGridViewTextBoxColumn typeCol;
    private DataGridViewTextBoxColumn earningsCol;
    private DataGridViewTextBoxColumn FICACol;
    private DataGridViewTextBoxColumn FedTaxCol;
    private DataGridViewTextBoxColumn StateTaxCol;
    private DataGridViewTextBoxColumn NetPayCol;
    private EmployeeList employeeList = new EmployeeList();

    public Ch3Prb1Form()
    {
      InitializeComponent();
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ch3Prb1Form));
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.employeeIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dgvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.updateContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.viewAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewSupervisorContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewHourlyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewPieceContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewCommissionContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.refreshContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.hireDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.earningsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FICACol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FedTaxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StateTaxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NetPayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createReportallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createReportsupervisorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createReporthourlyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createReportpieceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createReportcommissionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.seperator1MenuItem = new System.Windows.Forms.ToolStripSeparator();
      this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewSupervisorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewHourlyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewPieceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewCommissionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createReportSelectedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.navigatorToolStrip = new System.Windows.Forms.ToolStrip();
      this.navigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.navigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.navigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.navigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.navigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.navigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.navigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.navigatorUpdateNewItem = new System.Windows.Forms.ToolStripButton();
      this.navigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.navigatorFindLabelItem = new System.Windows.Forms.ToolStripLabel();
      this.navigatorFindTextBoxItem = new System.Windows.Forms.ToolStripTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.dgvContextMenu.SuspendLayout();
      this.mainMenu.SuspendLayout();
      this.navigatorToolStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView
      // 
      this.dataGridView.AllowUserToResizeColumns = false;
      this.dataGridView.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView.ColumnHeadersHeight = 30;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDCol,
            this.nameCol,
            this.hireDateCol,
            this.typeCol,
            this.earningsCol,
            this.FICACol,
            this.FedTaxCol,
            this.StateTaxCol,
            this.NetPayCol});
      this.dataGridView.ContextMenuStrip = this.dgvContextMenu;
      this.dataGridView.Location = new System.Drawing.Point(50, 160);
      this.dataGridView.Name = "dataGridView";
      dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
      this.dataGridView.RowHeadersWidth = 51;
      this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView.Size = new System.Drawing.Size(2268, 1083);
      this.dataGridView.TabIndex = 0;
      this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
      this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
      this.dataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellMouseEnter);
      this.dataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellMouseLeave);
      this.dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
      this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);
      this.dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowEnter);
      this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
      // 
      // employeeIDCol
      // 
      this.employeeIDCol.ContextMenuStrip = this.dgvContextMenu;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
      this.employeeIDCol.DefaultCellStyle = dataGridViewCellStyle2;
      this.employeeIDCol.HeaderText = "ID";
      this.employeeIDCol.Name = "employeeIDCol";
      this.employeeIDCol.ReadOnly = true;
      this.employeeIDCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.employeeIDCol.Width = 60;
      // 
      // dgvContextMenu
      // 
      this.dgvContextMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
      this.dgvContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContextMenuItem,
            this.updateContextMenuItem,
            this.deleteContextMenuItem,
            this.toolStripSeparator2,
            this.viewAllContextMenuItem,
            this.viewSupervisorContextMenuItem,
            this.viewHourlyContextMenuItem,
            this.viewPieceContextMenuItem,
            this.viewCommissionContextMenuItem,
            this.toolStripSeparator3,
            this.refreshContextMenuItem});
      this.dgvContextMenu.Name = "gridViewContextMenu";
      this.dgvContextMenu.Size = new System.Drawing.Size(261, 430);
      // 
      // addContextMenuItem
      // 
      this.addContextMenuItem.Name = "addContextMenuItem";
      this.addContextMenuItem.Size = new System.Drawing.Size(260, 46);
      this.addContextMenuItem.Text = "Add...";
      this.addContextMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
      // 
      // updateContextMenuItem
      // 
      this.updateContextMenuItem.Name = "updateContextMenuItem";
      this.updateContextMenuItem.Size = new System.Drawing.Size(260, 46);
      this.updateContextMenuItem.Text = "Update...";
      this.updateContextMenuItem.Click += new System.EventHandler(this.updateMenuItem_Click);
      // 
      // deleteContextMenuItem
      // 
      this.deleteContextMenuItem.Name = "deleteContextMenuItem";
      this.deleteContextMenuItem.Size = new System.Drawing.Size(260, 46);
      this.deleteContextMenuItem.Text = "Delete...";
      this.deleteContextMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
      // 
      // viewAllContextMenuItem
      // 
      this.viewAllContextMenuItem.Name = "viewAllContextMenuItem";
      this.viewAllContextMenuItem.Size = new System.Drawing.Size(260, 46);
      this.viewAllContextMenuItem.Text = "All";
      this.viewAllContextMenuItem.Click += new System.EventHandler(this.viewTypeMenuItem_Click);
      // 
      // viewSupervisorContextMenuItem
      // 
      this.viewSupervisorContextMenuItem.Name = "viewSupervisorContextMenuItem";
      this.viewSupervisorContextMenuItem.Size = new System.Drawing.Size(260, 46);
      this.viewSupervisorContextMenuItem.Text = "Supervisor";
      this.viewSupervisorContextMenuItem.Click += new System.EventHandler(this.viewTypeMenuItem_Click);
      // 
      // viewHourlyContextMenuItem
      // 
      this.viewHourlyContextMenuItem.Name = "viewHourlyContextMenuItem";
      this.viewHourlyContextMenuItem.Size = new System.Drawing.Size(260, 46);
      this.viewHourlyContextMenuItem.Text = "Hourly";
      this.viewHourlyContextMenuItem.Click += new System.EventHandler(this.viewTypeMenuItem_Click);
      // 
      // viewPieceContextMenuItem
      // 
      this.viewPieceContextMenuItem.Name = "viewPieceContextMenuItem";
      this.viewPieceContextMenuItem.Size = new System.Drawing.Size(260, 46);
      this.viewPieceContextMenuItem.Text = "Piece";
      this.viewPieceContextMenuItem.Click += new System.EventHandler(this.viewTypeMenuItem_Click);
      // 
      // viewCommissionContextMenuItem
      // 
      this.viewCommissionContextMenuItem.Name = "viewCommissionContextMenuItem";
      this.viewCommissionContextMenuItem.Size = new System.Drawing.Size(260, 46);
      this.viewCommissionContextMenuItem.Text = "Commission";
      this.viewCommissionContextMenuItem.Click += new System.EventHandler(this.viewTypeMenuItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(257, 6);
      // 
      // refreshContextMenuItem
      // 
      this.refreshContextMenuItem.Name = "refreshContextMenuItem";
      this.refreshContextMenuItem.Size = new System.Drawing.Size(260, 46);
      this.refreshContextMenuItem.Text = "Refresh";
      this.refreshContextMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
      // 
      // nameCol
      // 
      this.nameCol.ContextMenuStrip = this.dgvContextMenu;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.nameCol.DefaultCellStyle = dataGridViewCellStyle3;
      this.nameCol.HeaderText = "Name";
      this.nameCol.MaxInputLength = 25;
      this.nameCol.Name = "nameCol";
      this.nameCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.nameCol.Width = 150;
      // 
      // hireDateCol
      // 
      this.hireDateCol.ContextMenuStrip = this.dgvContextMenu;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.hireDateCol.DefaultCellStyle = dataGridViewCellStyle4;
      this.hireDateCol.HeaderText = "Hire Date";
      this.hireDateCol.MaxInputLength = 16;
      this.hireDateCol.Name = "hireDateCol";
      this.hireDateCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.hireDateCol.Width = 90;
      // 
      // typeCol
      // 
      this.typeCol.ContextMenuStrip = this.dgvContextMenu;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.typeCol.DefaultCellStyle = dataGridViewCellStyle5;
      this.typeCol.HeaderText = "Type";
      this.typeCol.Name = "typeCol";
      this.typeCol.ReadOnly = true;
      this.typeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.typeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.typeCol.Width = 65;
      // 
      // earningsCol
      // 
      this.earningsCol.ContextMenuStrip = this.dgvContextMenu;
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle6.Format = "N2";
      dataGridViewCellStyle6.NullValue = null;
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.earningsCol.DefaultCellStyle = dataGridViewCellStyle6;
      this.earningsCol.HeaderText = "Earnings";
      this.earningsCol.MaxInputLength = 6;
      this.earningsCol.Name = "earningsCol";
      this.earningsCol.ReadOnly = true;
      this.earningsCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.earningsCol.Width = 65;
      // 
      // FICACol
      // 
      this.FICACol.ContextMenuStrip = this.dgvContextMenu;
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.FICACol.DefaultCellStyle = dataGridViewCellStyle7;
      this.FICACol.HeaderText = "FICA";
      this.FICACol.MaxInputLength = 4;
      this.FICACol.Name = "FICACol";
      this.FICACol.ReadOnly = true;
      this.FICACol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.FICACol.Width = 60;
      // 
      // FedTaxCol
      // 
      this.FedTaxCol.ContextMenuStrip = this.dgvContextMenu;
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.FedTaxCol.DefaultCellStyle = dataGridViewCellStyle8;
      this.FedTaxCol.HeaderText = "Fed Tax";
      this.FedTaxCol.MaxInputLength = 4;
      this.FedTaxCol.Name = "FedTaxCol";
      this.FedTaxCol.ReadOnly = true;
      this.FedTaxCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.FedTaxCol.Width = 60;
      // 
      // StateTaxCol
      // 
      this.StateTaxCol.ContextMenuStrip = this.dgvContextMenu;
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.StateTaxCol.DefaultCellStyle = dataGridViewCellStyle9;
      this.StateTaxCol.HeaderText = "State Tax";
      this.StateTaxCol.MaxInputLength = 4;
      this.StateTaxCol.Name = "StateTaxCol";
      this.StateTaxCol.ReadOnly = true;
      this.StateTaxCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.StateTaxCol.Width = 60;
      // 
      // NetPayCol
      // 
      this.NetPayCol.ContextMenuStrip = this.dgvContextMenu;
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.NetPayCol.DefaultCellStyle = dataGridViewCellStyle10;
      this.NetPayCol.HeaderText = "Net Pay";
      this.NetPayCol.MaxInputLength = 4;
      this.NetPayCol.Name = "NetPayCol";
      this.NetPayCol.ReadOnly = true;
      this.NetPayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.NetPayCol.Width = 60;
      // 
      // mainMenu
      // 
      this.mainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
      this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.viewMenuItem,
            this.helpMenuItem});
      this.mainMenu.Location = new System.Drawing.Point(0, 0);
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
      this.mainMenu.Size = new System.Drawing.Size(2371, 49);
      this.mainMenu.TabIndex = 16;
      this.mainMenu.Text = "mainMenu";
      // 
      // fileMenuItem
      // 
      this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReportMenuItem,
            this.viewReportMenuItem,
            this.seperator1MenuItem,
            this.exitMenuItem});
      this.fileMenuItem.Name = "fileMenuItem";
      this.fileMenuItem.Size = new System.Drawing.Size(75, 45);
      this.fileMenuItem.Text = "&File";
      // 
      // createReportMenuItem
      // 
      this.createReportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReportallMenuItem,
            this.createReportsupervisorMenuItem,
            this.createReporthourlyMenuItem,
            this.createReportpieceMenuItem,
            this.createReportcommissionMenuItem});
      this.createReportMenuItem.Name = "createReportMenuItem";
      this.createReportMenuItem.Size = new System.Drawing.Size(315, 46);
      this.createReportMenuItem.Text = "&Create Report";
      // 
      // createReportallMenuItem
      // 
      this.createReportallMenuItem.Name = "createReportallMenuItem";
      this.createReportallMenuItem.Size = new System.Drawing.Size(296, 46);
      this.createReportallMenuItem.Text = "All";
      this.createReportallMenuItem.Click += new System.EventHandler(this.createReportMenuItem_Click);
      // 
      // createReportsupervisorMenuItem
      // 
      this.createReportsupervisorMenuItem.Name = "createReportsupervisorMenuItem";
      this.createReportsupervisorMenuItem.Size = new System.Drawing.Size(296, 46);
      this.createReportsupervisorMenuItem.Text = "Supervisor";
      this.createReportsupervisorMenuItem.Click += new System.EventHandler(this.createReportMenuItem_Click);
      // 
      // createReporthourlyMenuItem
      // 
      this.createReporthourlyMenuItem.Name = "createReporthourlyMenuItem";
      this.createReporthourlyMenuItem.Size = new System.Drawing.Size(296, 46);
      this.createReporthourlyMenuItem.Text = "Hourly";
      this.createReporthourlyMenuItem.Click += new System.EventHandler(this.createReportMenuItem_Click);
      // 
      // createReportpieceMenuItem
      // 
      this.createReportpieceMenuItem.Name = "createReportpieceMenuItem";
      this.createReportpieceMenuItem.Size = new System.Drawing.Size(296, 46);
      this.createReportpieceMenuItem.Text = "Piece";
      this.createReportpieceMenuItem.Click += new System.EventHandler(this.createReportMenuItem_Click);
      // 
      // createReportcommissionMenuItem
      // 
      this.createReportcommissionMenuItem.Name = "createReportcommissionMenuItem";
      this.createReportcommissionMenuItem.Size = new System.Drawing.Size(296, 46);
      this.createReportcommissionMenuItem.Text = "Commission";
      this.createReportcommissionMenuItem.Click += new System.EventHandler(this.createReportMenuItem_Click);
      // 
      // viewReportMenuItem
      // 
      this.viewReportMenuItem.Name = "viewReportMenuItem";
      this.viewReportMenuItem.Size = new System.Drawing.Size(315, 46);
      this.viewReportMenuItem.Text = "&View Report";
      this.viewReportMenuItem.Click += new System.EventHandler(this.viewReportMenuItem_Click);
      // 
      // seperator1MenuItem
      // 
      this.seperator1MenuItem.Name = "seperator1MenuItem";
      this.seperator1MenuItem.Size = new System.Drawing.Size(312, 6);
      // 
      // exitMenuItem
      // 
      this.exitMenuItem.Name = "exitMenuItem";
      this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.exitMenuItem.Size = new System.Drawing.Size(315, 46);
      this.exitMenuItem.Text = "E&xit";
      this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
      // 
      // editMenuItem
      // 
      this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.updateMenuItem,
            this.deleteMenuItem});
      this.editMenuItem.Name = "editMenuItem";
      this.editMenuItem.Size = new System.Drawing.Size(80, 45);
      this.editMenuItem.Text = "&Edit";
      // 
      // addMenuItem
      // 
      this.addMenuItem.Name = "addMenuItem";
      this.addMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.addMenuItem.Size = new System.Drawing.Size(419, 46);
      this.addMenuItem.Text = "&Add One...";
      this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
      // 
      // updateMenuItem
      // 
      this.updateMenuItem.Name = "updateMenuItem";
      this.updateMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.updateMenuItem.Size = new System.Drawing.Size(419, 46);
      this.updateMenuItem.Text = "&Update One...";
      this.updateMenuItem.Click += new System.EventHandler(this.updateMenuItem_Click);
      // 
      // deleteMenuItem
      // 
      this.deleteMenuItem.Name = "deleteMenuItem";
      this.deleteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.deleteMenuItem.Size = new System.Drawing.Size(419, 46);
      this.deleteMenuItem.Text = "&Delete...";
      this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
      // 
      // viewMenuItem
      // 
      this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllMenuItem,
            this.viewSupervisorMenuItem,
            this.viewHourlyMenuItem,
            this.viewPieceMenuItem,
            this.viewCommissionMenuItem,
            this.toolStripSeparator1,
            this.refreshMenuItem});
      this.viewMenuItem.Name = "viewMenuItem";
      this.viewMenuItem.Size = new System.Drawing.Size(94, 45);
      this.viewMenuItem.Text = "&View";
      // 
      // viewAllMenuItem
      // 
      this.viewAllMenuItem.Name = "viewAllMenuItem";
      this.viewAllMenuItem.Size = new System.Drawing.Size(333, 46);
      this.viewAllMenuItem.Text = "All";
      this.viewAllMenuItem.Click += new System.EventHandler(this.viewTypeMenuItem_Click);
      // 
      // viewSupervisorMenuItem
      // 
      this.viewSupervisorMenuItem.Name = "viewSupervisorMenuItem";
      this.viewSupervisorMenuItem.Size = new System.Drawing.Size(333, 46);
      this.viewSupervisorMenuItem.Text = "Supervisor";
      this.viewSupervisorMenuItem.Click += new System.EventHandler(this.viewTypeMenuItem_Click);
      // 
      // viewHourlyMenuItem
      // 
      this.viewHourlyMenuItem.Name = "viewHourlyMenuItem";
      this.viewHourlyMenuItem.Size = new System.Drawing.Size(333, 46);
      this.viewHourlyMenuItem.Text = "Hourly";
      this.viewHourlyMenuItem.Click += new System.EventHandler(this.viewTypeMenuItem_Click);
      // 
      // viewPieceMenuItem
      // 
      this.viewPieceMenuItem.Name = "viewPieceMenuItem";
      this.viewPieceMenuItem.Size = new System.Drawing.Size(333, 46);
      this.viewPieceMenuItem.Text = "Piece";
      this.viewPieceMenuItem.Click += new System.EventHandler(this.viewTypeMenuItem_Click);
      // 
      // viewCommissionMenuItem
      // 
      this.viewCommissionMenuItem.Name = "viewCommissionMenuItem";
      this.viewCommissionMenuItem.Size = new System.Drawing.Size(333, 46);
      this.viewCommissionMenuItem.Text = "Commission";
      this.viewCommissionMenuItem.Click += new System.EventHandler(this.viewTypeMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(330, 6);
      // 
      // refreshMenuItem
      // 
      this.refreshMenuItem.Name = "refreshMenuItem";
      this.refreshMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
      this.refreshMenuItem.Size = new System.Drawing.Size(333, 46);
      this.refreshMenuItem.Text = "&Refresh";
      this.refreshMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
      // 
      // helpMenuItem
      // 
      this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
      this.helpMenuItem.Name = "helpMenuItem";
      this.helpMenuItem.Size = new System.Drawing.Size(92, 45);
      this.helpMenuItem.Text = "&Help";
      // 
      // aboutMenuItem
      // 
      this.aboutMenuItem.Name = "aboutMenuItem";
      this.aboutMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
      this.aboutMenuItem.Size = new System.Drawing.Size(284, 46);
      this.aboutMenuItem.Text = "&About...";
      this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
      // 
      // createReportSelectedMenuItem
      // 
      this.createReportSelectedMenuItem.Name = "createReportSelectedMenuItem";
      this.createReportSelectedMenuItem.Size = new System.Drawing.Size(245, 46);
      this.createReportSelectedMenuItem.Text = "Selected";
      this.createReportSelectedMenuItem.Click += new System.EventHandler(this.createReportMenuItem_Click);
      // 
      // navigatorToolStrip
      // 
      this.navigatorToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.navigatorToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
      this.navigatorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigatorMoveFirstItem,
            this.navigatorMovePreviousItem,
            this.navigatorPositionItem,
            this.navigatorCountItem,
            this.navigatorMoveNextItem,
            this.navigatorMoveLastItem,
            this.navigatorAddNewItem,
            this.navigatorUpdateNewItem,
            this.navigatorDeleteItem,
            this.toolStripSeparator5,
            this.navigatorFindLabelItem,
            this.navigatorFindTextBoxItem});
      this.navigatorToolStrip.Location = new System.Drawing.Point(0, 58);
      this.navigatorToolStrip.Name = "navigatorToolStrip";
      this.navigatorToolStrip.Size = new System.Drawing.Size(747, 47);
      this.navigatorToolStrip.TabIndex = 23;
      // 
      // navigatorMoveFirstItem
      // 
      this.navigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorMoveFirstItem.Image")));
      this.navigatorMoveFirstItem.Name = "navigatorMoveFirstItem";
      this.navigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.navigatorMoveFirstItem.Size = new System.Drawing.Size(44, 44);
      this.navigatorMoveFirstItem.Text = "Move first";
      this.navigatorMoveFirstItem.Click += new System.EventHandler(this.navigatorMoveFirstItem_Click);
      // 
      // navigatorMovePreviousItem
      // 
      this.navigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorMovePreviousItem.Image")));
      this.navigatorMovePreviousItem.Name = "navigatorMovePreviousItem";
      this.navigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.navigatorMovePreviousItem.Size = new System.Drawing.Size(44, 44);
      this.navigatorMovePreviousItem.Text = "Move previous";
      this.navigatorMovePreviousItem.Click += new System.EventHandler(this.navigatorMovePreviousItem_Click);
      // 
      // navigatorPositionItem
      // 
      this.navigatorPositionItem.AccessibleName = "Position";
      this.navigatorPositionItem.AutoSize = false;
      this.navigatorPositionItem.Name = "navigatorPositionItem";
      this.navigatorPositionItem.Size = new System.Drawing.Size(63, 47);
      this.navigatorPositionItem.Text = "0";
      this.navigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.navigatorPositionItem.ToolTipText = "Current position";
      this.navigatorPositionItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.navigatorPositionItem_KeyDown);
      this.navigatorPositionItem.DoubleClick += new System.EventHandler(this.navigatorPositionItem_DoubleClick);
      // 
      // navigatorCountItem
      // 
      this.navigatorCountItem.AutoSize = false;
      this.navigatorCountItem.Name = "navigatorCountItem";
      this.navigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.navigatorCountItem.Text = "of {0}";
      this.navigatorCountItem.ToolTipText = "Total number of items";
      // 
      // navigatorMoveNextItem
      // 
      this.navigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorMoveNextItem.Image")));
      this.navigatorMoveNextItem.Name = "navigatorMoveNextItem";
      this.navigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.navigatorMoveNextItem.Size = new System.Drawing.Size(44, 44);
      this.navigatorMoveNextItem.Text = "Move next";
      this.navigatorMoveNextItem.Click += new System.EventHandler(this.navigatorMoveNextItem_Click);
      // 
      // navigatorMoveLastItem
      // 
      this.navigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorMoveLastItem.Image")));
      this.navigatorMoveLastItem.Name = "navigatorMoveLastItem";
      this.navigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.navigatorMoveLastItem.Size = new System.Drawing.Size(44, 44);
      this.navigatorMoveLastItem.Text = "Move last";
      this.navigatorMoveLastItem.Click += new System.EventHandler(this.navigatorMoveLastItem_Click);
      // 
      // navigatorAddNewItem
      // 
      this.navigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorAddNewItem.Image")));
      this.navigatorAddNewItem.Name = "navigatorAddNewItem";
      this.navigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.navigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
      this.navigatorAddNewItem.Text = "Add new";
      this.navigatorAddNewItem.Click += new System.EventHandler(this.addMenuItem_Click);
      // 
      // navigatorUpdateNewItem
      // 
      this.navigatorUpdateNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorUpdateNewItem.Name = "navigatorUpdateNewItem";
      this.navigatorUpdateNewItem.RightToLeftAutoMirrorImage = true;
      this.navigatorUpdateNewItem.Size = new System.Drawing.Size(23, 44);
      this.navigatorUpdateNewItem.Text = "Update";
      this.navigatorUpdateNewItem.Click += new System.EventHandler(this.updateMenuItem_Click);
      // 
      // navigatorDeleteItem
      // 
      this.navigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorDeleteItem.Image")));
      this.navigatorDeleteItem.Name = "navigatorDeleteItem";
      this.navigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.navigatorDeleteItem.Size = new System.Drawing.Size(44, 44);
      this.navigatorDeleteItem.ToolTipText = "Delete";
      this.navigatorDeleteItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 47);
      // 
      // navigatorFindLabelItem
      // 
      this.navigatorFindLabelItem.Name = "navigatorFindLabelItem";
      this.navigatorFindLabelItem.Size = new System.Drawing.Size(90, 44);
      this.navigatorFindLabelItem.Text = "Find: ";
      this.navigatorFindLabelItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // navigatorFindTextBoxItem
      // 
      this.navigatorFindTextBoxItem.Name = "navigatorFindTextBoxItem";
      this.navigatorFindTextBoxItem.Size = new System.Drawing.Size(250, 47);
      this.navigatorFindTextBoxItem.ToolTipText = "Find ID";
      this.navigatorFindTextBoxItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.navigatorFindTextBoxItem_KeyDown);
      this.navigatorFindTextBoxItem.DoubleClick += new System.EventHandler(this.navigatorFindTextBoxItem_DoubleClick);
      // 
      // Ch3Prb1Form
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(15, 40);
      this.ClientSize = new System.Drawing.Size(2371, 1310);
      this.Controls.Add(this.navigatorToolStrip);
      this.Controls.Add(this.mainMenu);
      this.Controls.Add(this.dataGridView);
      this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = new System.Drawing.Point(175, 50);
      this.MaximizeBox = false;
      this.Name = "Ch3Prb1Form";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ch3Prb1: Employee List Maintenance";
      this.Load += new System.EventHandler(this.Ch3Prb1Form_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.dgvContextMenu.ResumeLayout(false);
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      this.navigatorToolStrip.ResumeLayout(false);
      this.navigatorToolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    /********************************************************/
    /*  Event Handlers                                      */
    /********************************************************/
    private void Ch3Prb1Form_Load(object sender, EventArgs e)
    {
      //this.typeCol.Items.AddRange(validTypes);
      this.employeeList.Fill(DAT_FILE_NAME);
      this.listOrder = EmployeeList.OrderEnum.EmployeeIDOrder;
      this.RefreshClientAreaControls(1);
    }

    private void createReportMenuItem_Click(object sender, EventArgs e)
    {
      int rowIndex, listIndex;
      string categoryTitle;
      ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
      EmployeeList filteredList = new EmployeeList();

      if (menuItem.Text == "Selected")
      {
        for (rowIndex = 0; rowIndex < dataGridView.SelectedRows.Count; rowIndex++)
        {
          listIndex = this.dataGridView.Rows.IndexOf(dataGridView.SelectedRows[rowIndex]) + 1;
          filteredList.Add(employeeList[listIndex]);
        }
        filteredList.Sort(this.listOrder);
      }
      else
        foreach (Employee employee in this.employeeList)
          if (menuItem.Text == "All" || menuItem.Text == employee.Type)
            filteredList.Add(employee);
      categoryTitle = menuItem.Text + " Employees";
      switch (listOrder)
      {
        case EmployeeList.OrderEnum.EmployeeIDOrder:
          categoryTitle += " - ID Order";
          break;
        case EmployeeList.OrderEnum.NameOrder:
          categoryTitle += " - Name Order";
          break;
        case EmployeeList.OrderEnum.HireDateOrder:
          categoryTitle += " - Hire Date Order";
          break;
        case EmployeeList.OrderEnum.EarningsOrder:
          categoryTitle += " - Earnings Order";
          break;
        case EmployeeList.OrderEnum.FICAOrder:
          categoryTitle += " - FICA Order";
          break;
        case EmployeeList.OrderEnum.FedTaxOrder:
          categoryTitle += " - Fed Tax Order";
          break;
        case EmployeeList.OrderEnum.StateTaxOrder:
          categoryTitle += " - State Tax Order";
          break;
        case EmployeeList.OrderEnum.NetPayOrder:
          categoryTitle += " - Net Pay Order";
          break;
      }
      filteredList.CreateReport(RPT_FILE_NAME, categoryTitle);
    }


    private void viewReportMenuItem_Click(object sender, EventArgs e)
    {
      if (File.Exists(RPT_FILE_NAME))
        Process.Start("Notepad", RPT_FILE_NAME);
      else
        MessageBox.Show(RPT_FILE_NAME + " does not exist", "Invalid File Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void exitMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void addMenuItem_Click(object sender, EventArgs e)
    {
      int listIndex = 1;
      Employee employee;
      Form addDialog = null;
      //AddUpdateEmployeeDialog addDialog = new AddUpdateEmployeeDialog();

      employee = new Employee();
      employee.ID = this.employeeList.AssignID();
      addDialog.Text = "Add Employee";
      addDialog.Tag = employee;
      if (addDialog.Text.Contains("Commission"))
      {
        employee = new Commission();
        addDialog = new AddUpdateCommissionDialog();
        addDialog.Text = "Add Commission";
      }
      if (addDialog.Text.Contains("Hourly"))
      {
        employee = new Hourly();
        addDialog = new AddUpdateHourlyDialog();
        addDialog.Text = "Add Hourly";
      }
      if (addDialog.Text.Contains("Piece"))
      {
        employee = new Piece();
        addDialog = new AddUpdatePieceDialog();
        addDialog.Text = "Add Piece";
      }
      if (addDialog.Text.Contains("Supervisor"))
      {
        employee = new Supervisor();
        addDialog = new AddUpdateSupervisorDialog();
        addDialog.Text = "Add Supervisor";
      }
      if (addDialog.ShowDialog(this) == DialogResult.OK)
      {
        listIndex = ~this.employeeList.BinarySearch(employee, listOrder);
        this.employeeList.InsertAt(listIndex, employee);
        this.RefreshClientAreaControls(listIndex);
      }
      addDialog.Dispose();
    }

    private void updateMenuItem_Click(object sender, EventArgs e)
    {
      int listIndex = 1;
      Employee employee;
      Form updateDialog = null;

      employee = new Employee();
      employee.ID = this.employeeList.AssignID();
      updateDialog.Text = "Update Employee";
      updateDialog.Tag = employee;
      if (employee is Commission)
      {
        updateDialog = new AddUpdateCommissionDialog();
        updateDialog.Text = "Update Commission";
      }
      if (employee is Hourly)
      {
        employee = new Hourly();
        updateDialog = new AddUpdateHourlyDialog();
        updateDialog.Text = "Update Hourly";
      }
      if (employee is Piece)
      {
        employee = new Piece();
        updateDialog = new AddUpdatePieceDialog();
        updateDialog.Text = "Update Piece";
      }
      if (employee is Supervisor)
      {
        employee = new Supervisor();
        updateDialog = new AddUpdateSupervisorDialog();
        updateDialog.Text = "Update Supervisor";
      }
      if (updateDialog.ShowDialog(this) == DialogResult.OK)
      {
        listIndex = ~this.employeeList.BinarySearch(employee, listOrder);
        this.employeeList.InsertAt(listIndex, employee);
        this.RefreshClientAreaControls(listIndex);
      }
      updateDialog.Dispose();

      updateDialog.Tag = employee;
    }

    private void deleteMenuItem_Click(object sender, System.EventArgs e)
    {
      int index, listIndex = 1;
      Employee employee;
      DialogResult dialogResult;
      EList<int> selectedRowIndexList = new EList<int>();

      for (index = 0; index < dataGridView.SelectedRows.Count; index++)
        selectedRowIndexList.Add(dataGridView.Rows.IndexOf(dataGridView.SelectedRows[index]));
      selectedRowIndexList.Sort();
      selectedRowIndexList.Reverse();
      for (index = 1; index <= selectedRowIndexList.Count; index++)
      {
        listIndex = selectedRowIndexList[index] + 1;
        this.navigatorPositionItem.Text = listIndex.ToString();
        this.dataGridView.CurrentCell = this.dataGridView.Rows[listIndex - 1].Cells[0];
        employee = this.employeeList[listIndex];
        dialogResult = MessageBox.Show("Delete " + employee.ID.ToString("d4") + " " +
                                        employee.Name, "Delete Employee",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dialogResult == DialogResult.Yes)
        {
          this.employeeList.RemoveAt(listIndex);
          this.dataGridView.Rows.RemoveAt(listIndex - 1);
          this.RefreshDataGridViewRowHeaderCells();
          this.navigatorCountItem.Text = employeeList.Count.ToString();
        }
      }
    }

    private void viewTypeMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

      employeeList.Fill(DAT_FILE_NAME, menuItem.Text);
      this.listOrder = EmployeeList.OrderEnum.EmployeeIDOrder;
      this.RefreshClientAreaControls(1);
    }

    private void refreshMenuItem_Click(object sender, EventArgs e)
    {
      this.employeeList.Fill(DAT_FILE_NAME);
      this.listOrder = EmployeeList.OrderEnum.EmployeeIDOrder;
      this.RefreshClientAreaControls(1);
    }

    private void aboutMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog aboutDialog = new AboutDialog();

      aboutDialog.ShowDialog(this);
      aboutDialog.Dispose();
    }

    private void navigatorMoveFirstItem_Click(object sender, EventArgs e)
    {
      RefreshClientAreaControls(1);
    }

    private void navigatorMovePreviousItem_Click(object sender, EventArgs e)
    {
      int listIndex = dataGridView.CurrentRow.Index + 1;

      if (listIndex > 1)
      {
        listIndex--;
        RefreshClientAreaControls(listIndex);
      }
    }

    private void navigatorPositionItem_DoubleClick(object sender, EventArgs e)
    {
      int listIndex = dataGridView.CurrentRow.Index + 1;

      try
      {
        int newIndex = Int32.Parse(navigatorPositionItem.Text);
        if (newIndex >= 1 && newIndex <= employeeList.Count)
          RefreshClientAreaControls(newIndex);
      }
      catch
      {
        this.RefreshClientAreaControls(listIndex);
      }
    }

    private void navigatorPositionItem_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
        this.navigatorPositionItem_DoubleClick(sender, e);
    }

    private void navigatorMoveNextItem_Click(object sender, EventArgs e)
    {
      int listIndex = dataGridView.CurrentRow.Index + 1;

      if (listIndex < employeeList.Count)
      {
        listIndex++;
        this.RefreshClientAreaControls(listIndex);
      }
    }

    private void navigatorMoveLastItem_Click(object sender, EventArgs e)
    {
      this.RefreshClientAreaControls(this.employeeList.Count);
    }

    private void navigatorFindTextBoxItem_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
        this.navigatorFindTextBoxItem_DoubleClick(null, null);
    }

    private void navigatorFindTextBoxItem_DoubleClick(object sender, EventArgs e)
    {
      bool valueOK = true;
      int id, listIndex = 1;
      Employee employee = new Employee();

      if (this.listOrder == EmployeeList.OrderEnum.EmployeeIDOrder)
        try
        {
          id = Int32.Parse(this.navigatorFindTextBoxItem.Text);
          if (id >= 1 && id <= 9999)
            employee.ID = id;
          else
          {
            ProcessError("Invalid value.  Must be an integer >= 1 and <= 9999.");
            valueOK = false;
          }
        }
        catch
        {
          ProcessError("Invalid value.  Must be an integer >= 1 and <= 9999.");
          valueOK = false;
        }
      else if (this.listOrder == EmployeeList.OrderEnum.NameOrder)
        employee.Name = this.navigatorFindTextBoxItem.Text;
      else if (this.listOrder == EmployeeList.OrderEnum.HireDateOrder)
        try
        {
          employee.HireDate = Date.Parse(this.navigatorFindTextBoxItem.Text);
        }
        catch
        {
          ProcessError("Invalid date.");
          valueOK = false;
        }
      else
        valueOK = false;
      if (valueOK)
      {
        listIndex = this.employeeList.BinarySearch(employee, listOrder);
        if (listIndex < 0)
          listIndex = ~listIndex;
        this.RefreshSelecteRowDisplays(listIndex);
      }
    }

    private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {
      bool valueOK = false;
      int listIndex;
      double earnings, fica, fedTax, stateTax, netPay;
      string name = "", type = "";
      Date hireDate;

      if (!this.suppressCellValidating && e.ColumnIndex >= 1)
      {
        listIndex = e.RowIndex + 1;
        switch (e.ColumnIndex)
        {
          case 1:
            if (ETextBoxCell.ReadString(e.FormattedValue.ToString(), out name,
                                        ValueRequiredEnum.ValueRequired))
            {
              valueOK = true;
              if (this.employeeList[listIndex].Name.CompareTo(name) != 0)
              {
                this.employeeList[listIndex].Name = name;
                if (this.listOrder == EmployeeList.OrderEnum.NameOrder)
                  this.DeactivateFindControlsAndSortedIndicators(e.ColumnIndex);
              }
            }
            break;
          case 2:
            if (ETextBoxCell.ReadDate(e.FormattedValue.ToString(), out hireDate))
            {
              valueOK = true;
              if ((int)this.employeeList[listIndex].HireDate != (int)hireDate)
              {
                this.employeeList[listIndex].HireDate = hireDate;
                if (this.listOrder == EmployeeList.OrderEnum.HireDateOrder)
                  this.DeactivateFindControlsAndSortedIndicators(e.ColumnIndex);
              }
            }
            break;
          case 3:
            if (ETextBoxCell.ReadString(e.FormattedValue.ToString(), out type))
            {
              valueOK = true;
              if (this.employeeList[listIndex].Type != type)
              {
                this.employeeList[listIndex].Type = type;
                if (this.listOrder == EmployeeList.OrderEnum.TypeOrder)
                  this.DeactivateFindControlsAndSortedIndicators(e.ColumnIndex);
              }
            }
            break;
          case 4:
            if (ETextBoxCell.ReadDouble(e.FormattedValue.ToString(), out earnings,
                                         BoundsEnum.Both, 0.0, 300.0))
            {
              valueOK = true;
              if (this.employeeList[listIndex].Earnings != earnings)
              {
                this.employeeList[listIndex].Earnings = earnings;
                if (this.listOrder == EmployeeList.OrderEnum.EarningsOrder)
                  this.DeactivateFindControlsAndSortedIndicators(e.ColumnIndex);
              }
            }
            break;
          case 5:
            if (ETextBoxCell.ReadDouble(e.FormattedValue.ToString(), out fica,
                                        BoundsEnum.Both, 0.0, 4.0))
            {
              valueOK = true;
              if (this.employeeList[listIndex].FICA != fica)
              {
                this.employeeList[listIndex].FICA = fica;
                if (listOrder == EmployeeList.OrderEnum.FICAOrder)
                  this.DeactivateFindControlsAndSortedIndicators(e.ColumnIndex);
              }
            }
            break;
          case 6:
            if (ETextBoxCell.ReadDouble(e.FormattedValue.ToString(), out fedTax,
                                        BoundsEnum.Both, 0.0, 4.0))
            {
              valueOK = true;
              if (this.employeeList[listIndex].FedTax != fedTax)
              {
                this.employeeList[listIndex].FedTax = fedTax;
                if (listOrder == EmployeeList.OrderEnum.FedTaxOrder)
                  this.DeactivateFindControlsAndSortedIndicators(e.ColumnIndex);
              }
            }
            break;
          case 7:
            if (ETextBoxCell.ReadDouble(e.FormattedValue.ToString(), out stateTax,
                                        BoundsEnum.Both, 0.0, 4.0))
            {
              valueOK = true;
              if (this.employeeList[listIndex].StateTax != stateTax)
              {
                this.employeeList[listIndex].StateTax = stateTax;
                if (listOrder == EmployeeList.OrderEnum.StateTaxOrder)
                  this.DeactivateFindControlsAndSortedIndicators(e.ColumnIndex);
              }
            }
            break;
          case 8:
            if (ETextBoxCell.ReadDouble(e.FormattedValue.ToString(), out netPay,
                                        BoundsEnum.Both, 0.0, 4.0))
            {
              valueOK = true;
              if (this.employeeList[listIndex].NetPay != netPay)
              {
                this.employeeList[listIndex].NetPay = netPay;
                if (listOrder == EmployeeList.OrderEnum.NetPayOrder)
                  this.DeactivateFindControlsAndSortedIndicators(e.ColumnIndex);
              }
            }
            break;
        }

      }
      else
        valueOK = true;
      e.Cancel = !valueOK;
    }

    // Prevent dataGridView cell validating if form's red X close button clicked
    protected override void WndProc(ref Message m)
    {
      if (m.Msg == 0x10)
        this.AutoValidate = AutoValidate.Disable;
      base.WndProc(ref m);
    }

    private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 2)
        this.dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
          Date.Parse(this.dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()).ToString("MM/dd/yyyy");
      else if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
        this.dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
          Double.Parse(this.dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()).ToString("n");
    }

    private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      this.listOrder = (EmployeeList.OrderEnum)e.ColumnIndex;
      this.employeeList.Sort(listOrder);
      this.RefreshClientAreaControls(1);
    }

    private void dataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1 && e.ColumnIndex != -1)
        this.TurnOnSortIndicators(this.dataGridView.Columns[e.ColumnIndex]);
    }

    private void dataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1 && e.ColumnIndex != -1)
        if (this.listOrder != (EmployeeList.OrderEnum)e.ColumnIndex)
          this.TurnOffSortIndicators(this.dataGridView.Columns[e.ColumnIndex]);
    }

    private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.navigatorPositionItem.Text = (e.RowIndex + 1).ToString();
    }

    private void dataGridView_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
        this.deleteMenuItem_Click(null, null);
    }

    /********************************************************/
    /*  Auxiliary Methods                                   */
    /********************************************************/
    private void RefreshClientAreaControls(int listIndex)
    {
      this.suppressCellValidating = true;
      this.RefreshDataGridViewContent();
      this.RefreshDataGridViewRowHeaderCells();
      this.RefreshDataGridViewColHeaderCells();
      this.RefreshFindControls();
      this.RefreshSelecteRowDisplays(listIndex);
      this.suppressCellValidating = false;
    }

    private void RefreshDataGridViewContent()
    {
      this.dataGridView.Rows.Clear();
      foreach (Employee employee in this.employeeList)
        this.dataGridView.Rows.Add(employee.ToStringArray());
    }

    private void RefreshDataGridViewRowHeaderCells()
    {
      for (int i = 1; i <= this.employeeList.Count; i++)
        this.dataGridView.Rows[i - 1].HeaderCell.Value = i.ToString();
    }

    private void RefreshDataGridViewColHeaderCells()
    {
      for (int colIndex = 0; colIndex < this.dataGridView.Columns.Count; colIndex++)
        this.TurnOffSortIndicators(this.dataGridView.Columns[colIndex]);
      this.TurnOnSortIndicators(this.dataGridView.Columns[(int)this.listOrder]);
    }

    private void TurnOnSortIndicators(DataGridViewColumn column)
    {
      column.HeaderCell.Style.BackColor = Color.FromArgb(197, 197, 189);
      column.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
    }

    private void TurnOffSortIndicators(DataGridViewColumn column)
    {
      column.HeaderCell.Style.BackColor = SystemColors.Control;
      column.HeaderCell.SortGlyphDirection = SortOrder.None;
    }

    private void RefreshFindControls()
    {
      navigatorFindLabelItem.Visible = true;
      navigatorFindTextBoxItem.Visible = true;
      navigatorFindTextBoxItem.Text = "";
      switch (this.listOrder)
      {
        case EmployeeList.OrderEnum.EmployeeIDOrder:
          this.navigatorFindTextBoxItem.ToolTipText = "Find ID";
          break;
        case EmployeeList.OrderEnum.NameOrder:
          this.navigatorFindTextBoxItem.ToolTipText = "Find Name";
          break;
        case EmployeeList.OrderEnum.HireDateOrder:
          this.navigatorFindTextBoxItem.ToolTipText = "Find Hire Date";
          break;
        default:
          navigatorFindLabelItem.Visible = false;
          navigatorFindTextBoxItem.Visible = false;
          break;
      }
    }

    private void RefreshSelecteRowDisplays(int listIndex)
    {
      if (listIndex < 1)
        listIndex = 1;
      else if (listIndex > this.employeeList.Count)
        listIndex = this.employeeList.Count;
      if (this.employeeList.Count > 0)
      {
        this.dataGridView.Rows[listIndex - 1].Selected = true;
        this.dataGridView.CurrentCell = this.dataGridView.Rows[listIndex - 1].Cells[0];
      }
      this.navigatorPositionItem.Text = listIndex.ToString();
      this.navigatorCountItem.Text = "of " + this.employeeList.Count.ToString();
      this.dataGridView.Select();
    }

    private void DeactivateFindControlsAndSortedIndicators(int columnIndex)
    {
      this.listOrder = EmployeeList.OrderEnum.None;
      this.navigatorFindLabelItem.Text = "";
      this.navigatorFindTextBoxItem.Visible = false;
      this.TurnOffSortIndicators(this.dataGridView.Columns[columnIndex]);
    }

    private static void ProcessError(string message)
    {
      MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }  // End main form class Ch3Prb1Form: Form

  /**********************************************************/
  /*  2.  Begin application class Ch3Prb1App                */
  /**********************************************************/
  public class Ch3Prb1App
  {
    [STAThread]
    static void Main()
    {
      Application.Run(new Ch3Prb1Form());
    }
  }  // End application class Ch3Prb1App 

}  // End partial namespace Ch3Prb1
