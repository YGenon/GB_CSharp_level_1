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
        int count;

        public Form2()
        {
            InitializeComponent();
            StartForm2();

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
                CheckAnswer();
            }

            if (count == 2)
            {
                

                lblSecondNumber.Visible = true;
                lblSecondNumber.Text = $"Второе ваше число - {txtInputNumber.Text}";
                CheckAnswer();
            }

            if (count == 3)
            {
                CheckAnswer();

                if (number != (int.Parse(txtInputNumber.Text)))
                {
                    lblCondition.Text = $"Вы не угадали! Загаданное число - {number} \n Игра закончена, попробуйте еще раз.";
                    HidLbl();
                    btnOK.Visible = false;
                    btnСontinue.Text = "Продолжить";
                    btnСontinue.Visible = true;
                }
            }
            count++;
            

        }

        /// <summary>
        /// Задаем начальные параметры Form2
        /// </summary>
        private void StartForm2()
        {
            this.Text = "Угадай число";            

            lblCondition.Text = "За три попытки угадайте загаданное компьютером число от 1 до 100";

            btnOK.Text = "OK";
            btnOK.Visible = true;            

            btnСontinue.Visible = false;

            number = MyRandomNumber();

            txtInputNumber.Text = " ";
            txtInputNumber.Focus();
            HidLbl();
            count = 1;
        }

        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        /// <returns></returns>
        private int MyRandomNumber()
        {
            Random r = new Random();            
            return r.Next(1,100);;
        }

        /// <summary>
        /// Получаем результат сравнения чисел
        /// </summary>
        private void CheckAnswer()
        {
            if (number == (int.Parse(txtInputNumber.Text)))
            {
                
                lblCondition.Text = "Вы выиграли!!!";
                HidLbl();
                btnOK.Visible = false;
                btnСontinue.Text = "Продолжить";
                btnСontinue.Visible = true;
            }

            else if (number > (int.Parse(txtInputNumber.Text)) && count < 3)
            {
                lblCondition.Text = "Загаданное число больше вашего";                
                txtInputNumber.Text = " ";
                txtInputNumber.Focus();
            }
            else if (number < (int.Parse(txtInputNumber.Text)) && count < 3)
            {
                lblCondition.Text = "Загаданное число меньше вашего";
                txtInputNumber.Text = " ";
                txtInputNumber.Focus();
            }            
        }

        /// <summary>
        /// Скрываем надписи с введенными играком числами
        /// </summary>
        private void HidLbl()
        {
            lblFirstNumber.Visible = false;
            lblSecondNumber.Visible = false;
        }


        /// <summary>
        /// Кнопка продолжения игры в случае проигрыша
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnСontinue_Click(object sender, EventArgs e)
        {
            StartForm2();
        }
    }
}
