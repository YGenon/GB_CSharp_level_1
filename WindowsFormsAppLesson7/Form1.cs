using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLesson7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "1";
            lblCount.Text = "0";
            this.Text = "Удвоитель";

        }

        
        private void BtnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
        }

        private void BtnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BuhfnmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ИгратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            ClearData();
            MessageBox.Show($"Вы должны за минимальное количество ходов получить число -  {r.Next(10,100)}");

        }

        /// <summary>
        /// Сбрасываем счетчик ходов и результат вычислений
        /// </summary>
        private void ClearData()
        {
            lblNumber.Text = "1";
            lblCount.Text = "0";
        }
    }
}
