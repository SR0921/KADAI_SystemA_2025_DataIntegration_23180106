using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Management
{
    public partial class SalesData : Form
    {
        public SalesData()
        {
            InitializeComponent();
        }

        // =============================
        // 画面ロード
        // =============================
        private void SalesData_Load(object sender, EventArgs e)
        {
            // 期間：当月
            var now = DateTime.Now;
            dtpFrom.Value = new DateTime(now.Year, now.Month, 1);
            dtpTo.Value = new DateTime(now.Year, now.Month, 1);

            // 商品分類：全チェック
            chkFood.Checked = true;
            chkMachine.Checked = true;
            chkDaily.Checked = true;
            chkOther.Checked = true;

            // 入力制御
            txtProductNo.MaxLength = 5;
            txtProductName.MaxLength = 30;

            // 初期は非アクティブ
            btnSend.Enabled = false;
            btnRefresh.Enabled = false;

            InitializeGrid();
        }

        // =============================
        // DataGridView 初期化
        // =============================
        private void InitializeGrid()
        {
            dgvSales.AutoGenerateColumns = false;
            dgvSales.AllowUserToAddRows = false;
            dgvSales.RowHeadersVisible = false;
            dgvSales.ScrollBars = ScrollBars.Vertical;
            dgvSales.ColumnCount = 7;

            dgvSales.Columns[0].Name = "販売日時";
            dgvSales.Columns[1].Name = "分類";
            dgvSales.Columns[2].Name = "商品番号";
            dgvSales.Columns[3].Name = "商品名";
            dgvSales.Columns[4].Name = "売上数量";
            dgvSales.Columns[5].Name = "割引適用額";
            dgvSales.Columns[6].Name = "売上額";

            foreach (DataGridViewColumn col in dgvSales.Columns)
            {
                col.Width = 120;
            }
        }

        // =============================
        // 検索ボタン
        // =============================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();

                string sql = CreateSearchSql();
                DataTable result = ExecuteSearch(sql);

                dgvSales.DataSource = result;

                btnSend.Enabled = true;
                btnRefresh.Enabled = true;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex);
                MessageBox.Show("予期せぬエラーが発生しました。", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================
        // 入力チェック
        // =============================
        private void ValidateInput()
        {
            if (dtpFrom.Value > dtpTo.Value)
                throw new ApplicationException("期間の開始と終了が不正です。");

            if (!(chkFood.Checked || chkMachine.Checked || chkDaily.Checked || chkOther.Checked))
                throw new ApplicationException("商品分類は1つ以上選択してください。");

            if (!string.IsNullOrEmpty(txtProductNo.Text) &&
                !txtProductNo.Text.All(char.IsDigit))
                throw new ApplicationException("商品番号は半角数字のみ入力可能です。");
        }

        // =============================
        // SQL作成（簡易）
        // =============================
        private string CreateSearchSql()
        {
            var sb = new StringBuilder();
            sb.Append("SELECT * FROM Sales WHERE ");
            sb.Append($"SaleMonth BETWEEN '{dtpFrom.Value:yyyyMM}' AND '{dtpTo.Value:yyyyMM}' ");

            var categories = new List<string>();
            if (chkFood.Checked) categories.Add("'食料品'");
            if (chkMachine.Checked) categories.Add("'機器'");
            if (chkDaily.Checked) categories.Add("'生活用品'");
            if (chkOther.Checked) categories.Add("'その他用品'");

            sb.Append($"AND Category IN ({string.Join(",", categories)}) ");

            if (!string.IsNullOrEmpty(txtProductNo.Text))
                sb.Append($"AND ProductNo = '{txtProductNo.Text}' ");

            if (!string.IsNullOrEmpty(txtProductName.Text))
                sb.Append($"AND ProductName LIKE '%{txtProductName.Text}%' ");

            return sb.ToString();
        }

        // =============================
        // 検索実行（スタブ）
        // =============================
        private DataTable ExecuteSearch(string sql)
        {
            // 本来はDBアクセス
            DataTable dt = new DataTable();
            dt.Columns.Add("販売日時");
            dt.Columns.Add("分類");
            dt.Columns.Add("商品番号");
            dt.Columns.Add("商品名");
            dt.Columns.Add("売上数量");
            dt.Columns.Add("割引適用額");
            dt.Columns.Add("売上額");

            // ダミーデータ（最大15行）
            for (int i = 0; i < 15; i++)
            {
                dt.Rows.Add(
                    DateTime.Now.ToString("yyyy/MM/dd"),
                    "食料品",
                    "10001",
                    "テスト商品",
                    1,
                    0,
                    1000
                );
            }

            return dt;
        }

        // =============================
        // バッチ起動（スタブ）
        // =============================
        private int ExecuteBatch()
        {
            // Process.Start() 等でバッチ起動する想定
            return 0; // 0:正常 それ以外:異常
        }

        // =============================
        // エラーログ
        // =============================
        private void WriteErrorLog(Exception ex)
        {
            File.AppendAllText("error.log",
                $"{DateTime.Now}: {ex}\r\n");
        }
        // =============================
        // 閉じる
        // =============================
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // =============================
        // 更新
        // =============================
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        // =============================
        // 売上データ送信
        // =============================
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            var msg = "送信対象は期間のみで、他の検索条件は反映されません。\n送信しますか？";
            if (MessageBox.Show(msg, "確認", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            int resultCode = ExecuteBatch();

            if (resultCode == 0)
                MessageBox.Show("売上データ送信が正常終了しました。");
            else
                MessageBox.Show("売上データ送信が異常終了しました。", "エラー");
        }

        // =============================
        // 条件クリア
        // =============================
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            SalesData_Load(sender, e);
            dgvSales.DataSource = null;
        }
    }
}
