namespace Management
{
    partial class SalesData
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            grpSearchCondition = new GroupBox();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtProductNo = new TextBox();
            lblProductNo = new Label();
            chkOther = new CheckBox();
            chkDaily = new CheckBox();
            chkMachine = new CheckBox();
            chkFood = new CheckBox();
            lblCategory = new Label();
            lblWave = new Label();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            lblPeriod = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            dgvSales = new DataGridView();
            販売日時 = new DataGridViewTextBoxColumn();
            分類 = new DataGridViewTextBoxColumn();
            商品番号 = new DataGridViewTextBoxColumn();
            商品名 = new DataGridViewTextBoxColumn();
            売上数量 = new DataGridViewTextBoxColumn();
            割引適用額 = new DataGridViewTextBoxColumn();
            売上額 = new DataGridViewTextBoxColumn();
            btnSend = new Button();
            btnRefresh = new Button();
            btnClose = new Button();
            grpSearchCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 0;
            label1.Text = "売上管理";
            // 
            // grpSearchCondition
            // 
            grpSearchCondition.Controls.Add(txtProductName);
            grpSearchCondition.Controls.Add(lblProductName);
            grpSearchCondition.Controls.Add(txtProductNo);
            grpSearchCondition.Controls.Add(lblProductNo);
            grpSearchCondition.Controls.Add(chkOther);
            grpSearchCondition.Controls.Add(chkDaily);
            grpSearchCondition.Controls.Add(chkMachine);
            grpSearchCondition.Controls.Add(chkFood);
            grpSearchCondition.Controls.Add(lblCategory);
            grpSearchCondition.Controls.Add(lblWave);
            grpSearchCondition.Controls.Add(dtpTo);
            grpSearchCondition.Controls.Add(dtpFrom);
            grpSearchCondition.Controls.Add(lblPeriod);
            grpSearchCondition.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            grpSearchCondition.Location = new Point(29, 42);
            grpSearchCondition.Name = "grpSearchCondition";
            grpSearchCondition.Size = new Size(630, 180);
            grpSearchCondition.TabIndex = 1;
            grpSearchCondition.TabStop = false;
            grpSearchCondition.Text = "検索条件";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(86, 133);
            txtProductName.MaxLength = 50;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(198, 29);
            txtProductName.TabIndex = 12;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblProductName.Location = new Point(15, 139);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(65, 19);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "商品分類";
            // 
            // txtProductNo
            // 
            txtProductNo.Location = new Point(86, 98);
            txtProductNo.MaxLength = 5;
            txtProductNo.Name = "txtProductNo";
            txtProductNo.Size = new Size(198, 29);
            txtProductNo.TabIndex = 10;
            // 
            // lblProductNo
            // 
            lblProductNo.AutoSize = true;
            lblProductNo.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblProductNo.Location = new Point(15, 104);
            lblProductNo.Name = "lblProductNo";
            lblProductNo.Size = new Size(65, 19);
            lblProductNo.TabIndex = 9;
            lblProductNo.Text = "商品番号";
            // 
            // chkOther
            // 
            chkOther.AutoSize = true;
            chkOther.Location = new Point(410, 67);
            chkOther.Name = "chkOther";
            chkOther.Size = new Size(102, 25);
            chkOther.TabIndex = 8;
            chkOther.Text = "その他用品";
            chkOther.UseVisualStyleBackColor = true;
            // 
            // chkDaily
            // 
            chkDaily.AutoSize = true;
            chkDaily.Location = new Point(302, 67);
            chkDaily.Name = "chkDaily";
            chkDaily.Size = new Size(93, 25);
            chkDaily.TabIndex = 7;
            chkDaily.Text = "生活用品";
            chkDaily.UseVisualStyleBackColor = true;
            // 
            // chkMachine
            // 
            chkMachine.AutoSize = true;
            chkMachine.Location = new Point(194, 67);
            chkMachine.Name = "chkMachine";
            chkMachine.Size = new Size(61, 25);
            chkMachine.TabIndex = 6;
            chkMachine.Text = "機器";
            chkMachine.UseVisualStyleBackColor = true;
            // 
            // chkFood
            // 
            chkFood.AutoSize = true;
            chkFood.Location = new Point(86, 67);
            chkFood.Name = "chkFood";
            chkFood.Size = new Size(77, 25);
            chkFood.TabIndex = 5;
            chkFood.Text = "食料品";
            chkFood.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblCategory.Location = new Point(15, 71);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 19);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "商品分類";
            // 
            // lblWave
            // 
            lblWave.AutoSize = true;
            lblWave.Location = new Point(214, 32);
            lblWave.Name = "lblWave";
            lblWave.Size = new Size(26, 21);
            lblWave.TabIndex = 3;
            lblWave.Text = "～";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(246, 28);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(150, 29);
            dtpTo.TabIndex = 2;
            // 
            // dtpFrom
            // 
            dtpFrom.CustomFormat = "";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(58, 28);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(150, 29);
            dtpFrom.TabIndex = 1;
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblPeriod.Location = new Point(15, 35);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(37, 19);
            lblPeriod.TabIndex = 0;
            lblPeriod.Text = "期間";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(665, 172);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 50);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "検索";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(775, 172);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 50);
            btnClear.TabIndex = 3;
            btnClear.Text = "条件クリア";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { 販売日時, 分類, 商品番号, 商品名, 売上数量, 割引適用額, 売上額 });
            dgvSales.Location = new Point(29, 245);
            dgvSales.Name = "dgvSales";
            dgvSales.Size = new Size(846, 191);
            dgvSales.TabIndex = 4;
            // 
            // 販売日時
            // 
            販売日時.HeaderText = "販売日時";
            販売日時.Name = "販売日時";
            // 
            // 分類
            // 
            分類.HeaderText = "分類";
            分類.Name = "分類";
            // 
            // 商品番号
            // 
            商品番号.HeaderText = "商品番号";
            商品番号.Name = "商品番号";
            // 
            // 商品名
            // 
            商品名.HeaderText = "商品名";
            商品名.Name = "商品名";
            // 
            // 売上数量
            // 
            売上数量.HeaderText = "売上数量";
            売上数量.Name = "売上数量";
            // 
            // 割引適用額
            // 
            割引適用額.HeaderText = "割引適用額";
            割引適用額.Name = "割引適用額";
            // 
            // 売上額
            // 
            売上額.HeaderText = "売上額";
            売上額.Name = "売上額";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(29, 451);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(129, 48);
            btnSend.TabIndex = 5;
            btnSend.Text = "売上データ送信";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(665, 450);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 50);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "更新";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(775, 449);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 50);
            btnClose.TabIndex = 7;
            btnClose.Text = "閉じる";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // SalesData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 527);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(btnSend);
            Controls.Add(dgvSales);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(grpSearchCondition);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SalesData";
            Text = "売上管理";
            Load += SalesData_Load;
            grpSearchCondition.ResumeLayout(false);
            grpSearchCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private GroupBox grpSearchCondition;
        private Label lblPeriod;
        private Label lblWave;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private CheckBox chkOther;
        private CheckBox chkDaily;
        private CheckBox chkMachine;
        private CheckBox chkFood;
        private Label lblCategory;
        private TextBox txtProductName;
        private Label lblProductName;
        private TextBox txtProductNo;
        private Label lblProductNo;
        private Button btnSearch;
        private Button btnClear;
        private DataGridView dgvSales;
        private DataGridViewTextBoxColumn 販売日時;
        private DataGridViewTextBoxColumn 分類;
        private DataGridViewTextBoxColumn 商品番号;
        private DataGridViewTextBoxColumn 商品名;
        private DataGridViewTextBoxColumn 売上数量;
        private DataGridViewTextBoxColumn 割引適用額;
        private DataGridViewTextBoxColumn 売上額;
        private Button btnSend;
        private Button btnRefresh;
        private Button btnClose;
    }
}