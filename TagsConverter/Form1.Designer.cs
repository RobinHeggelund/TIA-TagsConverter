namespace TagsConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewExcel = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBoarder = new System.Windows.Forms.Panel();
            this.panelBoarderMinimize = new System.Windows.Forms.Panel();
            this.panelBoarderFullscreen = new System.Windows.Forms.Panel();
            this.panelBoarderExit = new System.Windows.Forms.Panel();
            this.labelImportGuide = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.panelTableSelection = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelImportScreen = new System.Windows.Forms.Panel();
            this.buttonImportAgain = new System.Windows.Forms.Button();
            this.panelInputData = new System.Windows.Forms.Panel();
            this.labelInputData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.comboBoxComment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLogicalAddress = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.comboBoxPath = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxImport = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxFullscreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            this.panelBoarder.SuspendLayout();
            this.panelBoarderMinimize.SuspendLayout();
            this.panelBoarderFullscreen.SuspendLayout();
            this.panelBoarderExit.SuspendLayout();
            this.panelTableSelection.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelImportScreen.SuspendLayout();
            this.panelInputData.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExcel
            // 
            this.dataGridViewExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcel.Location = new System.Drawing.Point(30, 30);
            this.dataGridViewExcel.Margin = new System.Windows.Forms.Padding(30);
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.Size = new System.Drawing.Size(1345, 387);
            this.dataGridViewExcel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(95)))), ((int)(((byte)(227)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(622, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBoarder
            // 
            this.panelBoarder.BackColor = System.Drawing.Color.Black;
            this.panelBoarder.Controls.Add(this.label3);
            this.panelBoarder.Controls.Add(this.panelBoarderMinimize);
            this.panelBoarder.Controls.Add(this.panelBoarderFullscreen);
            this.panelBoarder.Controls.Add(this.panelBoarderExit);
            this.panelBoarder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBoarder.Location = new System.Drawing.Point(0, 0);
            this.panelBoarder.Name = "panelBoarder";
            this.panelBoarder.Size = new System.Drawing.Size(1470, 35);
            this.panelBoarder.TabIndex = 2;
            this.panelBoarder.DoubleClick += new System.EventHandler(this.panelBoarder_DoubleClick);
            this.panelBoarder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBoarder_MouseDown);
            // 
            // panelBoarderMinimize
            // 
            this.panelBoarderMinimize.Controls.Add(this.pictureBoxMinimize);
            this.panelBoarderMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBoarderMinimize.Location = new System.Drawing.Point(1365, 0);
            this.panelBoarderMinimize.Name = "panelBoarderMinimize";
            this.panelBoarderMinimize.Size = new System.Drawing.Size(35, 35);
            this.panelBoarderMinimize.TabIndex = 2;
            this.panelBoarderMinimize.Click += new System.EventHandler(this.panelBoarderMinimize_Click);
            this.panelBoarderMinimize.MouseEnter += new System.EventHandler(this.panelBoarderMinimize_MouseEnter);
            this.panelBoarderMinimize.MouseLeave += new System.EventHandler(this.panelBoarderMinimize_MouseLeave);
            // 
            // panelBoarderFullscreen
            // 
            this.panelBoarderFullscreen.Controls.Add(this.pictureBoxFullscreen);
            this.panelBoarderFullscreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBoarderFullscreen.Location = new System.Drawing.Point(1400, 0);
            this.panelBoarderFullscreen.Name = "panelBoarderFullscreen";
            this.panelBoarderFullscreen.Size = new System.Drawing.Size(35, 35);
            this.panelBoarderFullscreen.TabIndex = 1;
            this.panelBoarderFullscreen.Click += new System.EventHandler(this.panelBoarderFullscreen_Click);
            this.panelBoarderFullscreen.MouseEnter += new System.EventHandler(this.panelBoarderFullscreen_MouseEnter);
            this.panelBoarderFullscreen.MouseLeave += new System.EventHandler(this.panelBoarderFullscreen_MouseLeave);
            // 
            // panelBoarderExit
            // 
            this.panelBoarderExit.Controls.Add(this.pictureBoxExit);
            this.panelBoarderExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBoarderExit.Location = new System.Drawing.Point(1435, 0);
            this.panelBoarderExit.Name = "panelBoarderExit";
            this.panelBoarderExit.Size = new System.Drawing.Size(35, 35);
            this.panelBoarderExit.TabIndex = 0;
            this.panelBoarderExit.Click += new System.EventHandler(this.panelBoarderExit_Click);
            this.panelBoarderExit.MouseEnter += new System.EventHandler(this.panelBoarderExit_MouseEnter);
            this.panelBoarderExit.MouseLeave += new System.EventHandler(this.panelBoarderExit_MouseLeave);
            // 
            // labelImportGuide
            // 
            this.labelImportGuide.AutoSize = true;
            this.labelImportGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.labelImportGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImportGuide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.labelImportGuide.Location = new System.Drawing.Point(427, 519);
            this.labelImportGuide.Name = "labelImportGuide";
            this.labelImportGuide.Size = new System.Drawing.Size(534, 37);
            this.labelImportGuide.TabIndex = 4;
            this.labelImportGuide.Text = "Click to import or drag in excel file";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.comboBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTables.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(496, 472);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(417, 33);
            this.comboBoxTables.TabIndex = 5;
            // 
            // panelTableSelection
            // 
            this.panelTableSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.panelTableSelection.Controls.Add(this.label1);
            this.panelTableSelection.Controls.Add(this.comboBoxTables);
            this.panelTableSelection.Controls.Add(this.button1);
            this.panelTableSelection.Location = new System.Drawing.Point(0, 0);
            this.panelTableSelection.Name = "panelTableSelection";
            this.panelTableSelection.Size = new System.Drawing.Size(1402, 754);
            this.panelTableSelection.TabIndex = 7;
            this.panelTableSelection.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(433, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select the table you want to import";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.panelMain.Controls.Add(this.panelTableSelection);
            this.panelMain.Controls.Add(this.panelImportScreen);
            this.panelMain.Controls.Add(this.buttonImportAgain);
            this.panelMain.Controls.Add(this.panelInputData);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.dataGridViewExcel);
            this.panelMain.Location = new System.Drawing.Point(30, 62);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1405, 757);
            this.panelMain.TabIndex = 8;
            // 
            // panelImportScreen
            // 
            this.panelImportScreen.AllowDrop = true;
            this.panelImportScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.panelImportScreen.Controls.Add(this.pictureBoxImport);
            this.panelImportScreen.Controls.Add(this.labelImportGuide);
            this.panelImportScreen.Location = new System.Drawing.Point(3, 3);
            this.panelImportScreen.Name = "panelImportScreen";
            this.panelImportScreen.Size = new System.Drawing.Size(1392, 748);
            this.panelImportScreen.TabIndex = 21;
            this.panelImportScreen.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelImportScreen_DragDrop);
            // 
            // buttonImportAgain
            // 
            this.buttonImportAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonImportAgain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonImportAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportAgain.Location = new System.Drawing.Point(1288, 380);
            this.buttonImportAgain.Name = "buttonImportAgain";
            this.buttonImportAgain.Size = new System.Drawing.Size(87, 37);
            this.buttonImportAgain.TabIndex = 24;
            this.buttonImportAgain.Text = "Import";
            this.buttonImportAgain.UseVisualStyleBackColor = false;
            this.buttonImportAgain.Visible = false;
            this.buttonImportAgain.Click += new System.EventHandler(this.buttonImportAgain_Click);
            // 
            // panelInputData
            // 
            this.panelInputData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelInputData.Controls.Add(this.labelInputData);
            this.panelInputData.Location = new System.Drawing.Point(30, 30);
            this.panelInputData.Name = "panelInputData";
            this.panelInputData.Size = new System.Drawing.Size(108, 37);
            this.panelInputData.TabIndex = 23;
            this.panelInputData.Visible = false;
            this.panelInputData.Click += new System.EventHandler(this.panelInputData_Click);
            this.panelInputData.MouseEnter += new System.EventHandler(this.panelInputData_MouseEnter);
            this.panelInputData.MouseLeave += new System.EventHandler(this.panelInputData_MouseLeave);
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputData.Location = new System.Drawing.Point(11, 9);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(85, 20);
            this.labelInputData.TabIndex = 0;
            this.labelInputData.Text = "Input Data";
            this.labelInputData.Click += new System.EventHandler(this.labelInputData_Click);
            this.labelInputData.MouseEnter += new System.EventHandler(this.labelInputData_MouseEnter);
            this.labelInputData.MouseLeave += new System.EventHandler(this.labelInputData_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonConvert);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelComment);
            this.panel2.Controls.Add(this.comboBoxComment);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBoxLogicalAddress);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxDataType);
            this.panel2.Controls.Add(this.labelPath);
            this.panel2.Controls.Add(this.comboBoxPath);
            this.panel2.Controls.Add(this.comboBoxName);
            this.panel2.Location = new System.Drawing.Point(30, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 283);
            this.panel2.TabIndex = 20;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(95)))), ((int)(((byte)(227)))));
            this.buttonConvert.FlatAppearance.BorderSize = 0;
            this.buttonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConvert.Location = new System.Drawing.Point(282, 236);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(133, 37);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Export";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelName.Location = new System.Drawing.Point(89, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 24);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelComment.ForeColor = System.Drawing.SystemColors.Control;
            this.labelComment.Location = new System.Drawing.Point(58, 187);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(92, 24);
            this.labelComment.TabIndex = 19;
            this.labelComment.Text = "Comment";
            // 
            // comboBoxComment
            // 
            this.comboBoxComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.comboBoxComment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxComment.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxComment.FormattingEnabled = true;
            this.comboBoxComment.Location = new System.Drawing.Point(156, 183);
            this.comboBoxComment.Name = "comboBoxComment";
            this.comboBoxComment.Size = new System.Drawing.Size(417, 33);
            this.comboBoxComment.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(5, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Logical Address";
            // 
            // comboBoxLogicalAddress
            // 
            this.comboBoxLogicalAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.comboBoxLogicalAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogicalAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLogicalAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLogicalAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxLogicalAddress.FormattingEnabled = true;
            this.comboBoxLogicalAddress.Location = new System.Drawing.Point(156, 139);
            this.comboBoxLogicalAddress.Name = "comboBoxLogicalAddress";
            this.comboBoxLogicalAddress.Size = new System.Drawing.Size(417, 33);
            this.comboBoxLogicalAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(55, 99);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data Type";
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.comboBoxDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDataType.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxDataType.FormattingEnabled = true;
            this.comboBoxDataType.Location = new System.Drawing.Point(156, 95);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(417, 33);
            this.comboBoxDataType.TabIndex = 3;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelPath.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPath.Location = new System.Drawing.Point(103, 55);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(47, 24);
            this.labelPath.TabIndex = 16;
            this.labelPath.Text = "Path";
            // 
            // comboBoxPath
            // 
            this.comboBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.comboBoxPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPath.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxPath.FormattingEnabled = true;
            this.comboBoxPath.Location = new System.Drawing.Point(156, 51);
            this.comboBoxPath.Name = "comboBoxPath";
            this.comboBoxPath.Size = new System.Drawing.Size(417, 33);
            this.comboBoxPath.TabIndex = 2;
            // 
            // comboBoxName
            // 
            this.comboBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxName.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(156, 7);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(417, 33);
            this.comboBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 829);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "2023 - Robin Heggelund";
            // 
            // pictureBoxImport
            // 
            this.pictureBoxImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.pictureBoxImport.Image = global::TagsConverter.Properties.Resources.import1;
            this.pictureBoxImport.Location = new System.Drawing.Point(570, 221);
            this.pictureBoxImport.Name = "pictureBoxImport";
            this.pictureBoxImport.Size = new System.Drawing.Size(262, 261);
            this.pictureBoxImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImport.TabIndex = 3;
            this.pictureBoxImport.TabStop = false;
            this.pictureBoxImport.Click += new System.EventHandler(this.pictureBoxImport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TagsConverter.Properties.Resources.USN_logo_hvit;
            this.pictureBox1.Location = new System.Drawing.Point(741, 501);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Image = global::TagsConverter.Properties.Resources.minus;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(29, 29);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimize.TabIndex = 1;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            this.pictureBoxMinimize.MouseEnter += new System.EventHandler(this.pictureBoxMinimize_MouseEnter);
            this.pictureBoxMinimize.MouseLeave += new System.EventHandler(this.pictureBoxMinimize_MouseLeave);
            // 
            // pictureBoxFullscreen
            // 
            this.pictureBoxFullscreen.Image = global::TagsConverter.Properties.Resources.fullscreen__1_;
            this.pictureBoxFullscreen.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxFullscreen.Name = "pictureBoxFullscreen";
            this.pictureBoxFullscreen.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxFullscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFullscreen.TabIndex = 0;
            this.pictureBoxFullscreen.TabStop = false;
            this.pictureBoxFullscreen.Click += new System.EventHandler(this.pictureBoxFullscreen_Click);
            this.pictureBoxFullscreen.MouseEnter += new System.EventHandler(this.pictureBoxFullscreen_MouseEnter);
            this.pictureBoxFullscreen.MouseLeave += new System.EventHandler(this.pictureBoxFullscreen_MouseLeave);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::TagsConverter.Properties.Resources.cancel__1_;
            this.pictureBoxExit.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 1;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            this.pictureBoxExit.MouseEnter += new System.EventHandler(this.pictureBoxExit_MouseEnter);
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.pictureBoxExit_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(719, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "TC";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1470, 851);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBoarder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TIA Tag Converter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).EndInit();
            this.panelBoarder.ResumeLayout(false);
            this.panelBoarder.PerformLayout();
            this.panelBoarderMinimize.ResumeLayout(false);
            this.panelBoarderFullscreen.ResumeLayout(false);
            this.panelBoarderExit.ResumeLayout(false);
            this.panelTableSelection.ResumeLayout(false);
            this.panelTableSelection.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelImportScreen.ResumeLayout(false);
            this.panelImportScreen.PerformLayout();
            this.panelInputData.ResumeLayout(false);
            this.panelInputData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelBoarder;
        private System.Windows.Forms.Panel panelBoarderMinimize;
        private System.Windows.Forms.Panel panelBoarderFullscreen;
        private System.Windows.Forms.Panel panelBoarderExit;
        private System.Windows.Forms.PictureBox pictureBoxFullscreen;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxImport;
        private System.Windows.Forms.Label labelImportGuide;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Panel panelTableSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox comboBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxPath;
        private System.Windows.Forms.ComboBox comboBoxDataType;
        private System.Windows.Forms.ComboBox comboBoxLogicalAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelImportScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelInputData;
        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.Button buttonImportAgain;
        private System.Windows.Forms.Label label3;
    }
}

