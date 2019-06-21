using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLesson7
{
    public partial class Form1 : Form
    {
        int genNumber = 0;
        public Form1()
        {
            InitializeComponent();

            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "1";
            lblCount.Text = "0";
            this.Text = "Набор игр";
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Кнопка "+1"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            if (genNumber > 0) CheckAnswer();
        }

        /// <summary>
        /// Кнопка "*2"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            if (genNumber > 0) CheckAnswer();
        }
        /// <summary>
        /// Кнопка "Сброс"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }
                
        /// <summary>
        /// Окно показывающее условие игры "Удвоитель" и сгенерированное число, которое нужно набрать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ИгратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearData();
            Random r = new Random();
            genNumber = r.Next(10, 100);
           
            lblRandomNumber.Visible = true;
            lblRandomNumber.Text = $"Наберите число - { Convert.ToString(genNumber)}";

            MessageBox.Show($"Вы должны за минимальное количество ходов получить число -  {genNumber}");
        }

/// <summary>
        /// Сбрасываем счетчик ходов и результат вычислений
        /// </summary>
        private void ClearData()
        {
            lblNumber.Text = "1";
            lblCount.Text = "0";
            genNumber = 0;
        }

        /// <summary>
        /// Вызов окна с игрой - "Угадай число"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void УгадайЧислоToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Form2 f2 = new Form2();
            f2.Show();          

            this.Hide();
        }
        /// <summary>
        /// Проверяем сгенерированное число с числом набранным пользователем
        /// </summary>
        private void CheckAnswer()
        {
            if (genNumber == (int.Parse(lblNumber.Text)))
            {
                MessageBox.Show("Вы выиграли!!!");
                ClearData();
                lblRandomNumber.Visible = false;
            }

            if (genNumber < (int.Parse(lblNumber.Text)) && genNumber != 0)
            {
                MessageBox.Show("Вы проиграли, попробуйте еще раз!");
                ClearData();
                lblRandomNumber.Visible = false;
            }
        }
    }
}
