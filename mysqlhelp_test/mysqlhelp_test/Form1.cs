using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using mysqlhelp_test;

namespace mysqlhelp_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginID = textBox1.Text.Trim();
            string loginPwd = textBox2.Text.Trim();
            string sqlstr = "SELECT count(*) FROM `user` WHERE `user`.id = '' AND `user`.userPwd = ''";
        }
    }
}
