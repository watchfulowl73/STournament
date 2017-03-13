using System;
using System.Windows.Forms;

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
            }
            else
            {
                int r = int.Parse(tB_Rating.Text);
                Form1.pleaseAdd(n,s,r);
            }            
            tB_Name.Text = "";
            tB_Surname.Text = "";
            tB_Rating.Text = "";
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
