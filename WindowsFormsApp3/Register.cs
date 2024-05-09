using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> user = new Dictionary<string, dynamic>();
            user.Add("name", txtName.Text);
            user.Add("credit", txtCredit.Text);
            user.Add("phone", txtMobile.Text);

            string dbs = File.ReadAllText("./db.json");

            Dictionary<string, dynamic> db = JSONResearch.Parse(dbs);

            db.Add(txtID.Text.Trim(), user);

            string s = JSONResearch.Stringify(db, true);

            File.WriteAllText("./db.json", s);

            MessageBox.Show("با موفقیت ثبت شد");
        }
    }
}
