using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Management
{
    public partial class Transmission : Form
    {
        public Transmission()
        {
            InitializeComponent();
        }

        // =============================
        // 画面ロード
        // =============================
        private void Transmission_Load(object sender, EventArgs e)
        {
            // 期間：当月
            var now = DateTime.Now;
            dtpFrom.Value = new DateTime(now.Year, now.Month, 1);
            dtpTo.Value = new DateTime(now.Year, now.Month, 1);

            // 分類・ステータス：全チェック
            chkSend.Checked = true;
            chkReceive.Checked = true;
            chkDone.Checked = true;
            chkRetry.Checked = true;
            chkError.Checked = true;

            // 初期は更新不可
            btnRefresh.Enabled = false;

            InitializeGrid();
        }

        // =============================
        // DataGridView 初期化
        // =============================
        private void InitializeGrid()
        {
            dgvTransmission.AutoGenerateColumns = false;
            dgvTransmission.AllowUserToAddRows = false;
            dgvTransmission.RowHeadersVisible = false;
            dgvTransmission.ScrollBars = ScrollBars.Vertical;

            dgvTransmission.ColumnCount = 5;
            dgvTransmission.Columns[0].Name = "処理日時";
            dgvTransmission.Columns[1].Name = "分類";
            dgvTransmission.Columns[2].Name = "ファイル名";
            dgvTransmission.Columns[3].Name = "ステータス";
            dgvTransmission.Columns[4].Name = "出力メッセージ";

            dgvTransmission.Columns[0].Width = 130;
            dgvTransmission.Columns[1].Width = 80;
            dgvTransmission.Columns[2].Width = 200;
            dgvTransmission.Columns[3].Width = 100;
            dgvTransmission.Columns[4].Width = 300;
        }

        // =============================
        // 検索ボタン押下
        // =============================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();

                string sql = CreateSearchSql();
                DataTable result = ExecuteSearch(sql);

                dgvTransmission.DataSource = result;

                btnRefresh.Enabled = true;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "入力エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex);
                MessageBox.Show("予期せぬエラーが発生しました。",
                    "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================
        // 入力チェック
        // =============================
        private void ValidateInput()
        {
            if (dtpFrom.Value > dtpTo.Value)
                throw new ApplicationException("期間の開始と終了が不正です。");

            if (!(chkSend.Checked || chkReceive.Checked))
                throw new ApplicationException("分類は1つ以上選択してください。");

            if (!(chkDone.Checked || chkRetry.Checked || chkError.Checked))
                throw new ApplicationException("ステータスは1つ以上選択してください。");
        }

        // =============================
        // SQL作成（簡易）
        // =============================
        private string CreateSearchSql()
        {
            var sb = new StringBuilder();
            sb.Append("SELECT * FROM TransmissionLog WHERE ");
            sb.Append($"LogMonth BETWEEN '{dtpFrom.Value:yyyyMM}' AND '{dtpTo.Value:yyyyMM}' ");

            var categories = new List<string>();
            if (chkSend.Checked) categories.Add("'送信'");
            if (chkReceive.Checked) categories.Add("'受信'");
            sb.Append($"AND Category IN ({string.Join(",", categories)}) ");

            var status = new List<string>();
            if (chkDone.Checked) status.Add("'処理済み'");
            if (chkRetry.Checked) status.Add("'再送待ち'");
            if (chkError.Checked) status.Add("'異常'");
            sb.Append($"AND Status IN ({string.Join(",", status)}) ");

            return sb.ToString();
        }

        // =============================
        // 検索実行（スタブ）
        // =============================
        private DataTable ExecuteSearch(string sql)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("処理日時");
            dt.Columns.Add("分類");
            dt.Columns.Add("ファイル名");
            dt.Columns.Add("ステータス");
            dt.Columns.Add("出力メッセージ");

            // ダミーデータ（最大10行）
            for (int i = 0; i < 10; i++)
            {
                dt.Rows.Add(
                    DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    "送信",
                    $"SEND_FILE_{i}.dat",
                    "処理済み",
                    "正常終了しました。"
                );
            }

            return dt;
        }

        // =============================
        // 条件クリア
        // =============================
        private void btnClear_Click(object sender, EventArgs e)
        {
            Transmission_Load(sender, e);
            dgvTransmission.DataSource = null;
        }

        // =============================
        // 更新
        // =============================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        // =============================
        // 閉じる
        // =============================
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =============================
        // エラーログ出力
        // =============================
        private void WriteErrorLog(Exception ex)
        {
            File.AppendAllText("error.log",
                $"{DateTime.Now}: {ex}\r\n");
        }
    }
}

