using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApP14._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int[,] arrGetallen = new int[3, 5];
        //int[,] arrWisselGetallen = new int[3, 5];
        //int[,] arrVerplaatsGetallen = new int[3, 5];

        private void Form1_Load(object sender, EventArgs e)
        {
            Random myRandom = new Random();


            for (int rij = 0; rij <= arrGetallen.GetUpperBound(0); rij++)
            {
                for (int kolom = 0; kolom <= arrGetallen.GetUpperBound(1); kolom++)
                {
                    arrGetallen[rij, kolom] = myRandom.Next(0, 101);
                    TxtGetallen.Text += (arrGetallen[rij, kolom].ToString().PadLeft(5));
                }
                TxtGetallen.Text += Environment.NewLine;
            }
        }
        static void Swap(int kolomA, int kolomB)
        {
            int temp;
            for (int i = 0; i < 3; i++)
            {
                temp = arrGetallen[i, kolomA];
                arrGetallen[i, kolomA] = arrGetallen[i, kolomB];
                arrGetallen[i, kolomB] = temp;
            }
        }
        private void BtnVerwisselen_Click(object sender, EventArgs e)
        {
            try
            {
                Swap(int.Parse(txtIndex1.Text), int.Parse(txtIndex2.Text));
                for (int rij = 0; rij <= arrGetallen.GetUpperBound(0); rij++)
                {
                    for (int kolom = 0; kolom <= arrGetallen.GetUpperBound(1); kolom++)
                    {
                        //arrGetallen[rij, kolom] = myRandom.Next(0, 101);
                        TxtVerwisssel.Text += (arrGetallen[rij, kolom].ToString().PadLeft(5));
                    }
                    TxtVerwisssel.Text += Environment.NewLine;
                }
                txtIndex1.Text = string.Empty;
                txtIndex2.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void BtnVerplaatsen_Click(object sender, EventArgs e)
        {
            int[,] arrTemp = new int[arrGetallen.GetUpperBound(0) + 1, arrGetallen.GetUpperBound(1) + 1];
            Swap(int.Parse(txtIndex2.Text), arrTemp.GetUpperBound(1));
            Swap(int.Parse(txtIndex1.Text), int.Parse(txtIndex2.Text));
            Swap(int.Parse(txtIndex1.Text) - 1, int.Parse(txtIndex1.Text));
            Swap(int.Parse(txtIndex1.Text) - 2, int.Parse(txtIndex1.Text) - 1);
            //Swap(2, 4);
            //Swap(2, 0);
            //Swap(2, 1);
            //Swap(0, 4);
            for (int rij = 0; rij <= arrGetallen.GetUpperBound(0); rij++)
            {
                for (int kolom = 0; kolom <= arrGetallen.GetUpperBound(1); kolom++)
                {
                    //arrGetallen[rij, kolom] = myRandom.Next(0, 101);
                    TxtVerplaats.Text += (arrGetallen[rij, kolom].ToString().PadLeft(5));
                }
                TxtVerplaats.Text += Environment.NewLine;
            }
        }
    }
}
