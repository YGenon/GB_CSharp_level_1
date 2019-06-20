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
    public partial class Form2 : Form
    {

        int number;
        int count = 1;

        public Form2()
        {
            InitializeComponent();

            this.Text = "Угадай число";
            btnOK.Text = "OK";
            lblCondition.Text = "За три попытки угадайте загаданное компьютером число от 1 до 100";
            number = MyRandomNumber();
            lblFirstNumber.Visible = false;
            lblSecondNumber.Visible = false;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtInputNumber.Text}  {number}");
            
            if (count == 1)
            {
                lblFirstNumber.Visible = true;
                lblFirstNumber.Text = $"Первое ваше число - {txtInputNumber.Text}";
                
            }

            if (count == 2)
            {
                lblSecondNumber.Visible = true;
                lblSecondNumber.Text = $"Второе ваше число - {txtInputNumber.Text}";
                
            }
            count++;
            CheckAnswer();

        }

        private int MyRandomNumber()
        {
            Random r = new Random();            
            return r.Next(1,100);;
        }

        /// <summary>
        /// Проверяем результат
        /// </summary>
        private void CheckAnswer()
        {
            if (number == (int.Parse(txtInputNumber.Text)))
            {
                
                lblCondition.Text = "Вы выиграли!!!";
                lblFirstNumber.Visible = false;
                lblSecondNumber.Visible = false;
                txtInputNumber.Text = " ";
            }

            else if (number > (int.Parse(txtInputNumber.Text)))
            {
                lblCondition.Text = "Загаданное число больше вашего";
                //ClearData();
                //lblRandomNumber.Visible = false;
                txtInputNumber.Text = " ";
                txtInputNumber.Focus();
            }
            else
            {
                lblCondition.Text = "Загаданное число меньше вашего";
                txtInputNumber.Text = " ";
                txtInputNumber.Focus();
            }
        }
    }
}
