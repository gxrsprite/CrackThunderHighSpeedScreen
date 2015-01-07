using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace 破解高速通道
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = textboxFile1.Text;
            if (!File.Exists(filename))
            {
                return;
            }
            Task.Factory.StartNew(() =>
            {
                破解高速通道(filename);
                MessageBox.Show("完成");
            });
        }

        private static void 破解高速通道(string filename)
        {
            //连接数据库
            SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection();
            System.Data.SQLite.SQLiteConnectionStringBuilder connstr = new System.Data.SQLite.SQLiteConnectionStringBuilder();
            connstr.DataSource = filename;
            //connstr.Password = "admin";//设置密码，SQLite ADO.NET实现了数据库密码保护
            conn.ConnectionString = connstr.ToString();
            conn.Open();

            var tasks = conn.Query("select LocalTaskId,UserData from [AccelerateTaskMap27443399_superspeed_1_1]");
            foreach (dynamic task in tasks)
            {
                var encoding = System.Text.Encoding.UTF8;
                string jsonStr = encoding.GetString(task.UserData, 0, task.UserData.Length);

                JObject tentity = JObject.Parse(jsonStr);
                tentity["Result"] = 0;

                string newJson = JsonConvert.SerializeObject(tentity);
                var jsonbyte = encoding.GetBytes(newJson);
                conn.Execute("update [AccelerateTaskMap27443399_superspeed_1_1] set UserData = @jsondata where LocalTaskId = @Id", new { jsondata = jsonbyte, Id = task.LocalTaskId });
            }
            conn.Close();

        }
    }
}
