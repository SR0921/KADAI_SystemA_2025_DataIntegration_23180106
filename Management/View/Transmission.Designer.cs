namespace Management
{
    partial class Transmission
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
            label1 = new Label();
            grpSearchCondition = new GroupBox();
            chkError = new CheckBox();
            chkRetry = new CheckBox();
            chkDone = new CheckBox();
            lblStatus = new Label();
            chkReceive = new CheckBox();
            chkSend = new CheckBox();
            lblCategory = new Label();
            dtpTo = new DateTimePicker();
            lblWave = new Label();
            dtpFrom = new DateTimePicker();
            lblPeriod = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            dgvTransmission = new DataGridView();
            btnRefresh = new Button();
            btnClose = new Button();
            grpSearchCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransmission).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 0;
            label1.Text = "送受信管理";
            // 
            // grpSearchCondition
            // 
            grpSearchCondition.Controls.Add(chkError);
            grpSearchCondition.Controls.Add(chkRetry);
            grpSearchCondition.Controls.Add(chkDone);
            grpSearchCondition.Controls.Add(lblStatus);
            grpSearchCondition.Controls.Add(chkReceive);
            grpSearchCondition.Controls.Add(chkSend);
            grpSearchCondition.Controls.Add(lblCategory);
            grpSearchCondition.Controls.Add(dtpTo);
            grpSearchCondition.Controls.Add(lblWave);
            grpSearchCondition.Controls.Add(dtpFrom);
            grpSearchCondition.Controls.Add(lblPeriod);
            grpSearchCondition.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            grpSearchCondition.Location = new Point(12, 42);
            grpSearchCondition.Name = "grpSearchCondition";
            grpSearchCondition.Size = new Size(508, 146);
            grpSearchCondition.TabIndex = 1;
            grpSearchCondition.TabStop = false;
            grpSearchCondition.Text = "検索条件";
            // 
            // chkError
            // 
            chkError.AutoSize = true;
            chkError.Location = new Point(296, 103);
            chkError.Name = "chkError";
            chkError.Size = new Size(61, 25);
            chkError.TabIndex = 10;
            chkError.Text = "異常";
            chkError.UseVisualStyleBackColor = true;
            // 
            // chkRetry
            // 
            chkRetry.AutoSize = true;
            chkRetry.Location = new Point(188, 103);
            chkRetry.Name = "chkRetry";
            chkRetry.Size = new Size(89, 25);
            chkRetry.TabIndex = 9;
            chkRetry.Text = "再送待ち";
            chkRetry.UseVisualStyleBackColor = true;
            // 
            // chkDone
            // 
            chkDone.AutoSize = true;
            chkDone.Location = new Point(80, 103);
            chkDone.Name = "chkDone";
            chkDone.Size = new Size(91, 25);
            chkDone.TabIndex = 8;
            chkDone.Text = "処理済み";
            chkDone.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(6, 104);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 21);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "ステータス";
            // 
            // chkReceive
            // 
            chkReceive.AutoSize = true;
            chkReceive.Location = new Point(174, 69);
            chkReceive.Name = "chkReceive";
            chkReceive.Size = new Size(61, 25);
            chkReceive.TabIndex = 6;
            chkReceive.Text = "受信";
            chkReceive.UseVisualStyleBackColor = true;
            // 
            // chkSend
            // 
            chkSend.AutoSize = true;
            chkSend.Location = new Point(66, 69);
            chkSend.Name = "chkSend";
            chkSend.Size = new Size(61, 25);
            chkSend.TabIndex = 5;
            chkSend.Text = "送信";
            chkSend.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(6, 70);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(42, 21);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "分類";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(234, 28);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(150, 29);
            dtpTo.TabIndex = 3;
            // 
            // lblWave
            // 
            lblWave.AutoSize = true;
            lblWave.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblWave.Location = new Point(205, 36);
            lblWave.Name = "lblWave";
            lblWave.Size = new Size(23, 19);
            lblWave.TabIndex = 2;
            lblWave.Text = "～";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(49, 28);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(150, 29);
            dtpFrom.TabIndex = 1;
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblPeriod.Location = new Point(6, 36);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(37, 19);
            lblPeriod.TabIndex = 0;
            lblPeriod.Text = "期間";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(544, 138);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 50);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "検索";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(661, 138);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 50);
            btnClear.TabIndex = 4;
            btnClear.Text = "条件クリア";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvTransmission
            // 
            dgvTransmission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransmission.Location = new Point(12, 216);
            dgvTransmission.Name = "dgvTransmission";
            dgvTransmission.Size = new Size(749, 168);
            dgvTransmission.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(544, 399);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 50);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "更新";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(661, 399);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 50);
            btnClose.TabIndex = 8;
            btnClose.Text = "閉じる";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Transmission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(dgvTransmission);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(grpSearchCondition);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Transmission";
            Text = "送受信管理";
            grpSearchCondition.ResumeLayout(false);
            grpSearchCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransmission).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpSearchCondition;
        private Label lblPeriod;
        private DateTimePicker dtpFrom;
        private Label lblWave;
        private DateTimePicker dtpTo;
        private Label lblStatus;
        private CheckBox chkReceive;
        private CheckBox chkSend;
        private Label lblCategory;
        private CheckBox chkError;
        private CheckBox chkRetry;
        private CheckBox chkDone;
        private Button btnSearch;
        private Button btnClear;
        private DataGridView dgvTransmission;
        private Button btnRefresh;
        private Button btnClose;
    }
}