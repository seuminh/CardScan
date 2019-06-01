namespace Card
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabScan = new System.Windows.Forms.TabPage();
            this.txtScanType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnScanClear = new System.Windows.Forms.Button();
            this.txtScanAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScanCardId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cboAddType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboAddAmount = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddCardId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.txtDeleteType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDeleteAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteCardId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnReport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.datagridview1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colCardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScanTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.account = new System.Windows.Forms.ToolStripMenuItem();
            this.login = new System.Windows.Forms.ToolStripMenuItem();
            this.signout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain.SuspendLayout();
            this.tabScan.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabScan);
            this.tabMain.Controls.Add(this.tabAdd);
            this.tabMain.Controls.Add(this.tabDelete);
            this.tabMain.Controls.Add(this.tabSearch);
            this.tabMain.Location = new System.Drawing.Point(16, 28);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(417, 511);
            this.tabMain.TabIndex = 0;
            // 
            // tabScan
            // 
            this.tabScan.BackColor = System.Drawing.SystemColors.Window;
            this.tabScan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabScan.Controls.Add(this.txtScanType);
            this.tabScan.Controls.Add(this.label8);
            this.tabScan.Controls.Add(this.btnScan);
            this.tabScan.Controls.Add(this.lblNote);
            this.tabScan.Controls.Add(this.btnScanClear);
            this.tabScan.Controls.Add(this.txtScanAmount);
            this.tabScan.Controls.Add(this.label2);
            this.tabScan.Controls.Add(this.txtScanCardId);
            this.tabScan.Controls.Add(this.label1);
            this.tabScan.Location = new System.Drawing.Point(4, 25);
            this.tabScan.Margin = new System.Windows.Forms.Padding(4);
            this.tabScan.Name = "tabScan";
            this.tabScan.Padding = new System.Windows.Forms.Padding(4);
            this.tabScan.Size = new System.Drawing.Size(409, 482);
            this.tabScan.TabIndex = 0;
            this.tabScan.Text = "Scan";
            this.tabScan.Enter += new System.EventHandler(this.tabScan_Enter);
            this.tabScan.Leave += new System.EventHandler(this.tabScan_Leave);
            // 
            // txtScanType
            // 
            this.txtScanType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScanType.Enabled = false;
            this.txtScanType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtScanType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScanType.HintForeColor = System.Drawing.Color.Empty;
            this.txtScanType.HintText = "";
            this.txtScanType.isPassword = false;
            this.txtScanType.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtScanType.LineIdleColor = System.Drawing.Color.Gray;
            this.txtScanType.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtScanType.LineThickness = 3;
            this.txtScanType.Location = new System.Drawing.Point(138, 141);
            this.txtScanType.Margin = new System.Windows.Forms.Padding(4);
            this.txtScanType.Name = "txtScanType";
            this.txtScanType.Size = new System.Drawing.Size(183, 44);
            this.txtScanType.TabIndex = 8;
            this.txtScanType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Type";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(138, 305);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(97, 32);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(84, 449);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(223, 17);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "* Please Put Card on the Reader *";
            // 
            // btnScanClear
            // 
            this.btnScanClear.Location = new System.Drawing.Point(138, 376);
            this.btnScanClear.Name = "btnScanClear";
            this.btnScanClear.Size = new System.Drawing.Size(97, 32);
            this.btnScanClear.TabIndex = 4;
            this.btnScanClear.Text = "Clear";
            this.btnScanClear.UseVisualStyleBackColor = true;
            this.btnScanClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtScanAmount
            // 
            this.txtScanAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScanAmount.Enabled = false;
            this.txtScanAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtScanAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScanAmount.HintForeColor = System.Drawing.Color.Empty;
            this.txtScanAmount.HintText = "";
            this.txtScanAmount.isPassword = false;
            this.txtScanAmount.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtScanAmount.LineIdleColor = System.Drawing.Color.Gray;
            this.txtScanAmount.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtScanAmount.LineThickness = 3;
            this.txtScanAmount.Location = new System.Drawing.Point(138, 210);
            this.txtScanAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtScanAmount.Name = "txtScanAmount";
            this.txtScanAmount.Size = new System.Drawing.Size(183, 44);
            this.txtScanAmount.TabIndex = 3;
            this.txtScanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // txtScanCardId
            // 
            this.txtScanCardId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScanCardId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtScanCardId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScanCardId.HintForeColor = System.Drawing.Color.Empty;
            this.txtScanCardId.HintText = "";
            this.txtScanCardId.isPassword = false;
            this.txtScanCardId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtScanCardId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtScanCardId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtScanCardId.LineThickness = 3;
            this.txtScanCardId.Location = new System.Drawing.Point(138, 67);
            this.txtScanCardId.Margin = new System.Windows.Forms.Padding(4);
            this.txtScanCardId.Name = "txtScanCardId";
            this.txtScanCardId.Size = new System.Drawing.Size(183, 44);
            this.txtScanCardId.TabIndex = 1;
            this.txtScanCardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card ID";
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.SystemColors.Window;
            this.tabAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabAdd.Controls.Add(this.cboAddType);
            this.tabAdd.Controls.Add(this.label9);
            this.tabAdd.Controls.Add(this.cboAddAmount);
            this.tabAdd.Controls.Add(this.btnAddNew);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.txtAddCardId);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Location = new System.Drawing.Point(4, 25);
            this.tabAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(4);
            this.tabAdd.Size = new System.Drawing.Size(409, 482);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.Click += new System.EventHandler(this.tabAdd_Click);
            this.tabAdd.Leave += new System.EventHandler(this.tabAdd_Leave);
            // 
            // cboAddType
            // 
            this.cboAddType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddType.FormattingEnabled = true;
            this.cboAddType.Items.AddRange(new object[] {
            "Gasoline",
            "Super",
            "Diesel"});
            this.cboAddType.Location = new System.Drawing.Point(138, 153);
            this.cboAddType.Name = "cboAddType";
            this.cboAddType.Size = new System.Drawing.Size(183, 24);
            this.cboAddType.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Type";
            // 
            // cboAddAmount
            // 
            this.cboAddAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddAmount.FormattingEnabled = true;
            this.cboAddAmount.Items.AddRange(new object[] {
            "1L",
            "2L",
            "3L",
            "5L",
            "10L",
            "20L",
            "30L"});
            this.cboAddAmount.Location = new System.Drawing.Point(138, 226);
            this.cboAddAmount.Name = "cboAddAmount";
            this.cboAddAmount.Size = new System.Drawing.Size(183, 24);
            this.cboAddAmount.TabIndex = 10;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(138, 376);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(97, 32);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // txtAddCardId
            // 
            this.txtAddCardId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddCardId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddCardId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddCardId.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddCardId.HintText = "";
            this.txtAddCardId.isPassword = false;
            this.txtAddCardId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddCardId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddCardId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddCardId.LineThickness = 3;
            this.txtAddCardId.Location = new System.Drawing.Point(138, 67);
            this.txtAddCardId.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddCardId.Name = "txtAddCardId";
            this.txtAddCardId.Size = new System.Drawing.Size(183, 44);
            this.txtAddCardId.TabIndex = 5;
            this.txtAddCardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Card ID";
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.SystemColors.Window;
            this.tabDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabDelete.Controls.Add(this.txtDeleteType);
            this.tabDelete.Controls.Add(this.label10);
            this.tabDelete.Controls.Add(this.txtDeleteAmount);
            this.tabDelete.Controls.Add(this.label6);
            this.tabDelete.Controls.Add(this.btnDeleteClear);
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.Controls.Add(this.txtDeleteCardId);
            this.tabDelete.Controls.Add(this.label5);
            this.tabDelete.Location = new System.Drawing.Point(4, 25);
            this.tabDelete.Margin = new System.Windows.Forms.Padding(4);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(4);
            this.tabDelete.Size = new System.Drawing.Size(409, 482);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete";
            this.tabDelete.Click += new System.EventHandler(this.tabDelete_Click);
            this.tabDelete.Leave += new System.EventHandler(this.tabDelete_Leave);
            // 
            // txtDeleteType
            // 
            this.txtDeleteType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeleteType.Enabled = false;
            this.txtDeleteType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDeleteType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDeleteType.HintForeColor = System.Drawing.Color.Empty;
            this.txtDeleteType.HintText = "";
            this.txtDeleteType.isPassword = false;
            this.txtDeleteType.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDeleteType.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDeleteType.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDeleteType.LineThickness = 3;
            this.txtDeleteType.Location = new System.Drawing.Point(138, 141);
            this.txtDeleteType.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeleteType.Name = "txtDeleteType";
            this.txtDeleteType.Size = new System.Drawing.Size(183, 44);
            this.txtDeleteType.TabIndex = 15;
            this.txtDeleteType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Type";
            // 
            // txtDeleteAmount
            // 
            this.txtDeleteAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeleteAmount.Enabled = false;
            this.txtDeleteAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDeleteAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDeleteAmount.HintForeColor = System.Drawing.Color.Empty;
            this.txtDeleteAmount.HintText = "";
            this.txtDeleteAmount.isPassword = false;
            this.txtDeleteAmount.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDeleteAmount.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDeleteAmount.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDeleteAmount.LineThickness = 3;
            this.txtDeleteAmount.Location = new System.Drawing.Point(138, 210);
            this.txtDeleteAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeleteAmount.Name = "txtDeleteAmount";
            this.txtDeleteAmount.Size = new System.Drawing.Size(183, 44);
            this.txtDeleteAmount.TabIndex = 13;
            this.txtDeleteAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Amount";
            // 
            // btnDeleteClear
            // 
            this.btnDeleteClear.Location = new System.Drawing.Point(138, 376);
            this.btnDeleteClear.Name = "btnDeleteClear";
            this.btnDeleteClear.Size = new System.Drawing.Size(97, 32);
            this.btnDeleteClear.TabIndex = 11;
            this.btnDeleteClear.Text = "Clear";
            this.btnDeleteClear.UseVisualStyleBackColor = true;
            this.btnDeleteClear.Click += new System.EventHandler(this.btnDeleteClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(138, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteCardId
            // 
            this.txtDeleteCardId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeleteCardId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDeleteCardId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDeleteCardId.HintForeColor = System.Drawing.Color.Empty;
            this.txtDeleteCardId.HintText = "";
            this.txtDeleteCardId.isPassword = false;
            this.txtDeleteCardId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDeleteCardId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDeleteCardId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDeleteCardId.LineThickness = 3;
            this.txtDeleteCardId.Location = new System.Drawing.Point(138, 67);
            this.txtDeleteCardId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeleteCardId.Name = "txtDeleteCardId";
            this.txtDeleteCardId.Size = new System.Drawing.Size(183, 44);
            this.txtDeleteCardId.TabIndex = 7;
            this.txtDeleteCardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Card ID";
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tabSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabSearch.Controls.Add(this.btnReport);
            this.tabSearch.Controls.Add(this.label7);
            this.tabSearch.Controls.Add(this.btnSearchClear);
            this.tabSearch.Controls.Add(this.datagridview1);
            this.tabSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSearch.Location = new System.Drawing.Point(4, 25);
            this.tabSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(4);
            this.tabSearch.Size = new System.Drawing.Size(409, 482);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(219, 423);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(97, 32);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Card Scan Records";
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClear.Location = new System.Drawing.Point(92, 423);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(97, 32);
            this.btnSearchClear.TabIndex = 10;
            this.btnSearchClear.Text = "Clear";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // datagridview1
            // 
            this.datagridview1.AllowUserToAddRows = false;
            this.datagridview1.AllowUserToDeleteRows = false;
            this.datagridview1.AllowUserToResizeColumns = false;
            this.datagridview1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview1.ColumnHeadersHeight = 25;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCardId,
            this.colType,
            this.colAmount,
            this.colScanTimes});
            this.datagridview1.DoubleBuffered = true;
            this.datagridview1.EnableHeadersVisualStyles = false;
            this.datagridview1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.datagridview1.HeaderForeColor = System.Drawing.Color.LawnGreen;
            this.datagridview1.Location = new System.Drawing.Point(7, 82);
            this.datagridview1.MultiSelect = false;
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.ReadOnly = true;
            this.datagridview1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview1.RowHeadersVisible = false;
            this.datagridview1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview1.Size = new System.Drawing.Size(391, 321);
            this.datagridview1.TabIndex = 0;
            // 
            // colCardId
            // 
            this.colCardId.HeaderText = "Card ID";
            this.colCardId.Name = "colCardId";
            this.colCardId.ReadOnly = true;
            this.colCardId.Width = 140;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 80;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 80;
            // 
            // colScanTimes
            // 
            this.colScanTimes.HeaderText = "Scan Times";
            this.colScanTimes.Name = "colScanTimes";
            this.colScanTimes.ReadOnly = true;
            this.colScanTimes.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.account});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.SystemColors.ControlDark;
            this.account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.login,
            this.signout});
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(64, 20);
            this.account.Text = "Account";
            // 
            // login
            // 
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(117, 22);
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // signout
            // 
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(117, 22);
            this.signout.Text = "SignOut";
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnScan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(450, 557);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabMain.ResumeLayout(false);
            this.tabScan.ResumeLayout(false);
            this.tabScan.PerformLayout();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabScan;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem account;
        private System.Windows.Forms.ToolStripMenuItem login;
        private System.Windows.Forms.ToolStripMenuItem signout;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtScanAmount;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtScanCardId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScanClear;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddCardId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAddAmount;
        private System.Windows.Forms.Button btnScan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDeleteAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteClear;
        private System.Windows.Forms.Button btnDelete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDeleteCardId;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridview1;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtScanType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboAddType;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDeleteType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScanTimes;
        private System.Windows.Forms.Button btnReport;
    }
}

