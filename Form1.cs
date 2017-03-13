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

namespace STournament
{
    public partial class Form1 : Form
    {
        static List<Player> players = new List<Player>();
        static List<TextBox> tb_SurnList = new List<TextBox>();
        static List<TextBox> tb_NameList = new List<TextBox>();
        

        public Form1() { InitializeComponent();}

        private void Form1_Load(object sender, EventArgs e) {}

        public static void pleaseAdd(string n,string s,int r)
        {
            players.Add(new Player(n,s,r));
            players.Sort();
        }

        public static void pleaseAdd(string n, string s)
        {
            players.Add(new Player(n, s));
            players.Sort();
        }
        
        private void addPlayer_B_Click(object sender, EventArgs e)
        {
                 
        }

        private void start_B_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPlayer_WF wf = new addPlayer_WF();
            wf.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (players.Count > table.RowCount)
            {
                this.Height += 20;
                table.RowCount++;
            }
            for(int i = 0; i < players.Count; i++)
            {
                table.Rows[i].Cells[0].Value = i+1;
                table.Rows[i].Cells[1].Value = players[i].Surname;
                table.Rows[i].Cells[2].Value = players[i].Name;
            }
        }
    }
}
