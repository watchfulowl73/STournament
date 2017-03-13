using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Media;
using System.CodeDom;

using System.Web;

namespace STournament
{
    public partial class addPlayer_WF : Form
    {
        public addPlayer_WF()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string n = tB_Name.Text;
            string s = tB_Surname.Text;
            if (tB_Rating.Text == "")
            {
                Form1.pleaseAdd(n, s);
                this.Close();
                return;
            }
            int r = int.Parse(tB_Rating.Text);
            Form1.pleaseAdd(n,s,r);
            this.Close();
        }

        
    }
}
