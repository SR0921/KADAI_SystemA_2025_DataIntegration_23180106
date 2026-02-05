using System;
using System.Windows.Forms;

namespace Management
{
    public partial class Top : Form
    {
        public Top()
        {
            InitializeComponent();
        }

        // =====================================
        // 売上管理ボタン押下
        // =====================================
        private void btnSalesData_Click(object sender, EventArgs e)
        {
            // 売上管理画面を表示する
            using (var form = new SalesData())
            {
                form.ShowDialog();
            }
        }

        // =====================================
        // 送受信管理ボタン押下
        // =====================================
        private void btnTransmission_Click(object sender, EventArgs e)
        {
            // 送受信管理画面を表示する
            using (var form = new Transmission())
            {
                form.ShowDialog();
            }
        }
    }
} 
