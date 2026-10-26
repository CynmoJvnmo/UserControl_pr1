using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControl_pr1.FolderforModel;

namespace UserControl_pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static ModelDB DB = new ModelDB();

        List<Table_Motorbike> Motorbikes = DB.Table_Motorbike.ToList();
        int AccNumber = 0;

        private void Loading()
        {
            userControl11.Fill(Motorbikes[AccNumber]);
            userControl12.Fill(Motorbikes[AccNumber + 1]);
        }

        private void Loading(bool Incr)
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)
                AccNumber++;
            else if (Incr == false && 0 <= AccNumber - 1)
                AccNumber--;
            else
                return;

            Loading();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            Loading();
        }


        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Main1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true);
        }
    }
}
