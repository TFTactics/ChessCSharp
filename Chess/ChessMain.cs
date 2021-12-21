using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Chess
{
	/// <summary>
	/// Summary description for ChessMain.
	/// </summary>
	public class ChessMain : System.Windows.Forms.Form
	{
		private GameUI GameObj;		// The Game UI object
		public System.Windows.Forms.ListView lstHistory;
		public Chess.CaptureBar ChessCaptureBar;

		private System.Windows.Forms.MainMenu MainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem mnuNewGame;
		private System.Windows.Forms.MenuItem mnuFileExit;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.Timer TurnTicker;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem mnuEditUndoMove;
		private System.Windows.Forms.MenuItem mnuEditRedoMove;
		private System.Windows.Forms.MenuItem mnuEditShowLog;
		private System.Windows.Forms.MenuItem mnuShowLog;
		private System.Windows.Forms.MenuItem mnuHelp;
		private System.Windows.Forms.ColumnHeader LstIndex;
		private System.Windows.Forms.ColumnHeader lstMove;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.MenuItem mnuComputerPlayer;
		private System.Windows.Forms.MenuItem mnCompNullMove;
		private System.Windows.Forms.MenuItem mnuCompPrincipleVar;
		private System.Windows.Forms.MenuItem mnuCompQuiescentSearch;
        private MenuItem mnuShowComputerThinkDepth;
        private MenuItem mnuAbout;
        private MenuItem mnuSaveGame;
        private MenuItem mnuLoadGame;
        private MenuItem menuItem2;
        public PictureBox BlackPlayerImage;
        public PictureBox WhitePlayerImage;
        public Label BlackPlayerName;
        public Label WhitePlayerName;
        public Label BlackPlayerTime;
        public Label WhitePlayerTime;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuItem menuItem3;
        public Panel PnlComputerThinkStatus;
        public Label LblComuterThinkLabel;
        public ProgressBar PrgComputerThinkDepth;
        private MenuItem menuItem10;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private System.Windows.Forms.MenuItem mnuShowMoveHelp;
		
		public ChessMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessMain));
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuNewGame = new System.Windows.Forms.MenuItem();
            this.mnuLoadGame = new System.Windows.Forms.MenuItem();
            this.mnuSaveGame = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mnuFileExit = new System.Windows.Forms.MenuItem();
            this.mnuEditShowLog = new System.Windows.Forms.MenuItem();
            this.mnuEditUndoMove = new System.Windows.Forms.MenuItem();
            this.mnuEditRedoMove = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.mnuShowLog = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.mnuShowMoveHelp = new System.Windows.Forms.MenuItem();
            this.mnuComputerPlayer = new System.Windows.Forms.MenuItem();
            this.mnCompNullMove = new System.Windows.Forms.MenuItem();
            this.mnuCompPrincipleVar = new System.Windows.Forms.MenuItem();
            this.mnuCompQuiescentSearch = new System.Windows.Forms.MenuItem();
            this.mnuShowComputerThinkDepth = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.lstHistory = new System.Windows.Forms.ListView();
            this.LstIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMove = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TurnTicker = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlComputerThinkStatus = new System.Windows.Forms.Panel();
            this.LblComuterThinkLabel = new System.Windows.Forms.Label();
            this.PrgComputerThinkDepth = new System.Windows.Forms.ProgressBar();
            this.BlackPlayerImage = new System.Windows.Forms.PictureBox();
            this.WhitePlayerImage = new System.Windows.Forms.PictureBox();
            this.BlackPlayerName = new System.Windows.Forms.Label();
            this.WhitePlayerName = new System.Windows.Forms.Label();
            this.BlackPlayerTime = new System.Windows.Forms.Label();
            this.WhitePlayerTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ChessCaptureBar = new Chess.CaptureBar();
            this.panel2.SuspendLayout();
            this.PnlComputerThinkStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlackPlayerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhitePlayerImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.mnuEditShowLog,
            this.mnuComputerPlayer,
            this.mnuHelp,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNewGame,
            this.mnuLoadGame,
            this.mnuSaveGame,
            this.menuItem9,
            this.mnuFileExit});
            this.menuItem1.Text = "&File";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Index = 0;
            this.mnuNewGame.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.mnuNewGame.Text = "&New";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            // 
            // mnuLoadGame
            // 
            this.mnuLoadGame.Index = 1;
            this.mnuLoadGame.Text = "&Load Game";
            this.mnuLoadGame.Click += new System.EventHandler(this.mnuLoadGame_Click);
            // 
            // mnuSaveGame
            // 
            this.mnuSaveGame.Enabled = false;
            this.mnuSaveGame.Index = 2;
            this.mnuSaveGame.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSaveGame.Text = "&Save Game";
            this.mnuSaveGame.Click += new System.EventHandler(this.mnuSaveGame_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Text = "-";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Index = 4;
            this.mnuFileExit.Text = "&Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuEditShowLog
            // 
            this.mnuEditShowLog.Index = 1;
            this.mnuEditShowLog.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEditUndoMove,
            this.mnuEditRedoMove,
            this.menuItem11,
            this.mnuShowLog,
            this.menuItem14,
            this.mnuShowMoveHelp});
            this.mnuEditShowLog.Text = "&Edit";
            // 
            // mnuEditUndoMove
            // 
            this.mnuEditUndoMove.Index = 0;
            this.mnuEditUndoMove.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.mnuEditUndoMove.Text = "&Undo";
            this.mnuEditUndoMove.Click += new System.EventHandler(this.mnuEditUndoMove_Click);
            // 
            // mnuEditRedoMove
            // 
            this.mnuEditRedoMove.Index = 1;
            this.mnuEditRedoMove.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.mnuEditRedoMove.Text = "&Redo";
            this.mnuEditRedoMove.Click += new System.EventHandler(this.mnuEditRedoMove_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 2;
            this.menuItem11.Text = "-";
            // 
            // mnuShowLog
            // 
            this.mnuShowLog.Checked = true;
            this.mnuShowLog.Index = 3;
            this.mnuShowLog.Text = "Show Log";
            this.mnuShowLog.Click += new System.EventHandler(this.mnuShowLog_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 4;
            this.menuItem14.Text = "-";
            // 
            // mnuShowMoveHelp
            // 
            this.mnuShowMoveHelp.Index = 5;
            this.mnuShowMoveHelp.Text = "Show Move Help";
            this.mnuShowMoveHelp.Click += new System.EventHandler(this.mnuShowMoveHelp_Click);
            // 
            // mnuComputerPlayer
            // 
            this.mnuComputerPlayer.Index = 2;
            this.mnuComputerPlayer.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnCompNullMove,
            this.mnuCompPrincipleVar,
            this.mnuCompQuiescentSearch,
            this.mnuShowComputerThinkDepth});
            this.mnuComputerPlayer.Text = "Computer";
            // 
            // mnCompNullMove
            // 
            this.mnCompNullMove.Checked = true;
            this.mnCompNullMove.Index = 0;
            this.mnCompNullMove.Text = "Null Move Pruning";
            this.mnCompNullMove.Click += new System.EventHandler(this.mnCompNullMove_Click);
            // 
            // mnuCompPrincipleVar
            // 
            this.mnuCompPrincipleVar.Checked = true;
            this.mnuCompPrincipleVar.Index = 1;
            this.mnuCompPrincipleVar.Text = "Principle Variation Search";
            this.mnuCompPrincipleVar.Click += new System.EventHandler(this.mnuCompPrincipleVar_Click);
            // 
            // mnuCompQuiescentSearch
            // 
            this.mnuCompQuiescentSearch.Index = 2;
            this.mnuCompQuiescentSearch.Text = "Quiescent Search";
            this.mnuCompQuiescentSearch.Click += new System.EventHandler(this.mnuCompQuiescentSearch_Click);
            // 
            // mnuShowComputerThinkDepth
            // 
            this.mnuShowComputerThinkDepth.Checked = true;
            this.mnuShowComputerThinkDepth.Index = 3;
            this.mnuShowComputerThinkDepth.Text = "Show Computer Think Depth";
            this.mnuShowComputerThinkDepth.Click += new System.EventHandler(this.mnuShowComputerThinkDepth_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 3;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAbout,
            this.menuItem10});
            this.mnuHelp.Text = "&Help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 0;
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "&Rules";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 4;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3});
            this.menuItem2.Text = "&Tools";
            this.menuItem2.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "&Music";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = -1;
            this.menuItem5.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = -1;
            this.menuItem6.Text = "Beginner";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = -1;
            this.menuItem7.Text = "Intermediate";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = -1;
            this.menuItem8.Text = "Expert";
            // 
            // lstHistory
            // 
            this.lstHistory.AllowColumnReorder = true;
            this.lstHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LstIndex,
            this.lstMove});
            this.lstHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHistory.ForeColor = System.Drawing.Color.DarkGreen;
            this.lstHistory.GridLines = true;
            this.lstHistory.HideSelection = false;
            this.lstHistory.LabelEdit = true;
            this.lstHistory.Location = new System.Drawing.Point(3, 3);
            this.lstHistory.MultiSelect = false;
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(200, 266);
            this.lstHistory.TabIndex = 6;
            this.lstHistory.UseCompatibleStateImageBehavior = false;
            this.lstHistory.View = System.Windows.Forms.View.Details;
            this.lstHistory.SelectedIndexChanged += new System.EventHandler(this.lstHistory_SelectedIndexChanged);
            // 
            // LstIndex
            // 
            this.LstIndex.Text = "No.";
            this.LstIndex.Width = 48;
            // 
            // lstMove
            // 
            this.lstMove.Text = "Move";
            this.lstMove.Width = 137;
            // 
            // TurnTicker
            // 
            this.TurnTicker.Enabled = true;
            this.TurnTicker.Interval = 500;
            this.TurnTicker.Tick += new System.EventHandler(this.TurnTicker_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.PnlComputerThinkStatus);
            this.panel2.Location = new System.Drawing.Point(12, 535);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 111);
            this.panel2.TabIndex = 1;
            // 
            // PnlComputerThinkStatus
            // 
            this.PnlComputerThinkStatus.BackColor = System.Drawing.Color.Transparent;
            this.PnlComputerThinkStatus.Controls.Add(this.ChessCaptureBar);
            this.PnlComputerThinkStatus.Controls.Add(this.LblComuterThinkLabel);
            this.PnlComputerThinkStatus.Controls.Add(this.PrgComputerThinkDepth);
            this.PnlComputerThinkStatus.Location = new System.Drawing.Point(16, 15);
            this.PnlComputerThinkStatus.Name = "PnlComputerThinkStatus";
            this.PnlComputerThinkStatus.Size = new System.Drawing.Size(794, 67);
            this.PnlComputerThinkStatus.TabIndex = 0;
            // 
            // LblComuterThinkLabel
            // 
            this.LblComuterThinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComuterThinkLabel.ForeColor = System.Drawing.Color.Blue;
            this.LblComuterThinkLabel.Location = new System.Drawing.Point(-3, 29);
            this.LblComuterThinkLabel.Name = "LblComuterThinkLabel";
            this.LblComuterThinkLabel.Size = new System.Drawing.Size(768, 18);
            this.LblComuterThinkLabel.TabIndex = 1;
            // 
            // PrgComputerThinkDepth
            // 
            this.PrgComputerThinkDepth.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PrgComputerThinkDepth.Location = new System.Drawing.Point(3, 3);
            this.PrgComputerThinkDepth.Name = "PrgComputerThinkDepth";
            this.PrgComputerThinkDepth.Size = new System.Drawing.Size(788, 25);
            this.PrgComputerThinkDepth.TabIndex = 0;
            // 
            // BlackPlayerImage
            // 
            this.BlackPlayerImage.BackColor = System.Drawing.Color.White;
            this.BlackPlayerImage.Location = new System.Drawing.Point(17, 50);
            this.BlackPlayerImage.Name = "BlackPlayerImage";
            this.BlackPlayerImage.Size = new System.Drawing.Size(54, 58);
            this.BlackPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlackPlayerImage.TabIndex = 0;
            this.BlackPlayerImage.TabStop = false;
            // 
            // WhitePlayerImage
            // 
            this.WhitePlayerImage.BackColor = System.Drawing.Color.White;
            this.WhitePlayerImage.Location = new System.Drawing.Point(17, 156);
            this.WhitePlayerImage.Name = "WhitePlayerImage";
            this.WhitePlayerImage.Size = new System.Drawing.Size(54, 58);
            this.WhitePlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WhitePlayerImage.TabIndex = 1;
            this.WhitePlayerImage.TabStop = false;
            // 
            // BlackPlayerName
            // 
            this.BlackPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.BlackPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackPlayerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BlackPlayerName.Location = new System.Drawing.Point(83, 50);
            this.BlackPlayerName.Name = "BlackPlayerName";
            this.BlackPlayerName.Size = new System.Drawing.Size(116, 28);
            this.BlackPlayerName.TabIndex = 2;
            // 
            // WhitePlayerName
            // 
            this.WhitePlayerName.BackColor = System.Drawing.Color.Transparent;
            this.WhitePlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhitePlayerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WhitePlayerName.Location = new System.Drawing.Point(83, 156);
            this.WhitePlayerName.Name = "WhitePlayerName";
            this.WhitePlayerName.Size = new System.Drawing.Size(116, 27);
            this.WhitePlayerName.TabIndex = 3;
            // 
            // BlackPlayerTime
            // 
            this.BlackPlayerTime.BackColor = System.Drawing.Color.White;
            this.BlackPlayerTime.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackPlayerTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BlackPlayerTime.Location = new System.Drawing.Point(84, 80);
            this.BlackPlayerTime.Name = "BlackPlayerTime";
            this.BlackPlayerTime.Size = new System.Drawing.Size(115, 28);
            this.BlackPlayerTime.TabIndex = 4;
            this.BlackPlayerTime.Click += new System.EventHandler(this.BlackPlayerTime_Click);
            // 
            // WhitePlayerTime
            // 
            this.WhitePlayerTime.BackColor = System.Drawing.Color.White;
            this.WhitePlayerTime.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhitePlayerTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.WhitePlayerTime.Location = new System.Drawing.Point(84, 186);
            this.WhitePlayerTime.Name = "WhitePlayerTime";
            this.WhitePlayerTime.Size = new System.Drawing.Size(115, 28);
            this.WhitePlayerTime.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.WhitePlayerTime);
            this.panel1.Controls.Add(this.BlackPlayerTime);
            this.panel1.Controls.Add(this.WhitePlayerName);
            this.panel1.Controls.Add(this.BlackPlayerName);
            this.panel1.Controls.Add(this.WhitePlayerImage);
            this.panel1.Controls.Add(this.BlackPlayerImage);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(538, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 594);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.Controls.Add(this.lstHistory, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 237);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(182, 272);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "3";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "2";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "1";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "A";
            this.label9.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "C";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(118, 505);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "B";
            this.label11.Click += new System.EventHandler(this.label6_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(236, 505);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "D";
            this.label12.Click += new System.EventHandler(this.label6_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(298, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "E";
            this.label13.Click += new System.EventHandler(this.label6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(418, 505);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 24);
            this.label14.TabIndex = 2;
            this.label14.Text = "G";
            this.label14.Click += new System.EventHandler(this.label6_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(478, 505);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "H";
            this.label15.Click += new System.EventHandler(this.label6_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(358, 505);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 24);
            this.label16.TabIndex = 2;
            this.label16.Text = "F";
            this.label16.Click += new System.EventHandler(this.label6_Click);
            // 
            // ChessCaptureBar
            // 
            this.ChessCaptureBar.BackColor = System.Drawing.Color.Transparent;
            this.ChessCaptureBar.Location = new System.Drawing.Point(3, 3);
            this.ChessCaptureBar.Name = "ChessCaptureBar";
            this.ChessCaptureBar.Size = new System.Drawing.Size(819, 70);
            this.ChessCaptureBar.TabIndex = 1;
            // 
            // ChessMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::Chess.Properties.Resources.chess;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 622);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.MainMenu;
            this.Name = "ChessMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOPChess";
            this.Load += new System.EventHandler(this.ChessMain_Load);
            this.panel2.ResumeLayout(false);
            this.PnlComputerThinkStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BlackPlayerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhitePlayerImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new ChessMain());
		}

        /// <summary>
        /// Enable the Save Menu
        /// </summary>
        public void EnableSaveMenu()
        {
            mnuSaveGame.Enabled = true;
        }

        /// <summary>
        /// Set/Re-set the Game Preferences menu
        /// </summary>
        public void SetGamePrefrencesMenu()
        {
            mnuCompPrincipleVar.Checked = GameObj.ChessGame.DoPrincipleVariation;
            mnuCompQuiescentSearch.Checked = GameObj.ChessGame.DoQuiescentSearch;
            mnCompNullMove.Checked = GameObj.ChessGame.DoNullMovePruning;
        }

		// Chess board load event. Initialize all the chess positions
		private void ChessMain_Load(object sender, System.EventArgs e)
		{
			GameObj = new GameUI(this);
			this.mnuShowMoveHelp.Checked = GameObj.ShowMoveHelp;	// Show the check box
		}

		// Menu Handler
		private void mnuNewGame_Click(object sender, System.EventArgs e)
		{
			GameObj.NewGame();	// Initialize the new game

			// Initialize computer player characterstics
			if (GameObj.ChessGame!=null)
			{
				GameObj.ChessGame.DoNullMovePruning = mnCompNullMove.Checked;
				GameObj.ChessGame.DoPrincipleVariation = mnuCompPrincipleVar.Checked;
				GameObj.ChessGame.DoQuiescentSearch = mnuCompQuiescentSearch.Checked;
			}
		}

		private void mnuFileExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();		// Send the terminate signal to all running threads
		}

		private void mnuShowMoveHelp_Click(object sender, System.EventArgs e)
		{
			GameObj.ShowMoveHelp = !GameObj.ShowMoveHelp;	// Reverse the show help check box state
			this.mnuShowMoveHelp.Checked = GameObj.ShowMoveHelp;	// Show the check box
		}

		private void TurnTicker_Tick(object sender, System.EventArgs e)
		{
			if (GameObj.IsRunning && !GameObj.IsOver )	// game is in active state
			{
				GameObj.ShowPlayerTurn();
			}
		}

		private void mnuEditUndoMove_Click(object sender, System.EventArgs e)
		{
			if (GameObj.IsRunning)	// game is in active state
			{
				GameObj.UndoMove();
			}		
		}

		private void mnuEditRedoMove_Click(object sender, System.EventArgs e)
		{
			if (GameObj.IsRunning)	// game is in active state
			{
				GameObj.RedoMove();
			}			
		}

		private void mnuShowLog_Click(object sender, System.EventArgs e)
		{
			mnuShowLog.Checked = !mnuShowLog.Checked;

			if (mnuShowLog.Checked)	// Need to show the log
			{
				this.Width +=190;
				this.Height +=96;
			}
			else
			{
				this.Width -=190;
				this.Height -=96;
			}
		}

		private void mnuHelp_Click(object sender, System.EventArgs e)
		{
		}

		// Enable or disable null move pruning for the computer player
		private void mnCompNullMove_Click(object sender, System.EventArgs e)
		{
			mnCompNullMove.Checked = !mnCompNullMove.Checked;
			if (GameObj.ChessGame!=null)
				GameObj.ChessGame.DoNullMovePruning = mnCompNullMove.Checked;
		}

		// Enable or disable principle variation search for the computer player
		private void mnuCompPrincipleVar_Click(object sender, System.EventArgs e)
		{
			mnuCompPrincipleVar.Checked = !mnuCompPrincipleVar.Checked;
			if (GameObj.ChessGame!=null)
				GameObj.ChessGame.DoPrincipleVariation = mnuCompPrincipleVar.Checked;
		}

		// Enable or disable quiescent search for the computer player
		private void mnuCompQuiescentSearch_Click(object sender, System.EventArgs e)
		{
			mnuCompQuiescentSearch.Checked = !mnuCompQuiescentSearch.Checked;
			if (GameObj.ChessGame!=null)
				GameObj.ChessGame.DoQuiescentSearch = mnuCompQuiescentSearch.Checked;	
		}

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
		}

        private void mnuShowComputerThinkDepth_Click(object sender, EventArgs e)
        {
            // Toggle the status
            this.mnuShowComputerThinkDepth.Checked = !this.mnuShowComputerThinkDepth.Checked;

            // Update the game status
            GameObj.ShowComputerThinkingProgres = this.mnuShowComputerThinkDepth.Checked;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutDlg = new AboutBox();
            aboutDlg.ShowDialog();
        }

        private void mnuSaveGame_Click(object sender, EventArgs e)
        {
            // Save the game state
            GameObj.SaveGame();
        }

        private void mnuLoadGame_Click(object sender, EventArgs e)
        {
            GameObj.LoadGame();
        }
        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            MusicMediaPlayer add = new MusicMediaPlayer();
            add.Show();
        }

        private void BlackPlayerTime_Click(object sender, EventArgs e)
        {

        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            RulesForm rulesForm = new RulesForm();
            rulesForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
