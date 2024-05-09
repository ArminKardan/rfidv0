using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string s = File.ReadAllText("./db.json");
                Dictionary<string, dynamic> db = JSONResearch.Parse(s);
                if (db.ContainsKey(txtID.Text))
                {
                    Dictionary<string, dynamic> user_s = db[txtID.Text];
                    string show = user_s["name"] + "\n" + user_s["credit"] + "\n" + user_s["phone"];
                    MessageBox.Show(show);
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }
    }
}
