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
        int InputNumber;

        public Form2()
        {
            InitializeComponent();
            StartForm2();
        }

        /// <summary>
        /// Закрытие Form2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
        }

        /// <summary>
        /// Кнопка ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {              
            //проверяем введенный символ на его корректность            
            if (int.TryParse(txtInputNumber.Text, out int rezult) || !String.IsNullOrWhiteSpace(txtInputNumber.Text))
                InputNumber = int.Parse(txtInputNumber.Text);

            if (InputNumber > 0) ShowInputData();
        }

        /// <summary>
        /// Показываем введенные пользователем числа и считаем количество попыток
        /// </summary>
        private void ShowInputData()
        {
            if (count == 1)
            {
                //lblFirstNumber.Text = $"Первое ваше число - {Convert.ToString(InputNumber)}";
                string first = $"Первое ваше число: {Convert.ToString(InputNumber)}";
                CheckAnswer(first);
            }

            if (count == 2)
            {                
                //lblSecondNumber.Text = $"Второе ваше число - {Convert.ToString(InputNumber)}";
                string scnd = $"Второе ваше число: {Convert.ToString(InputNumber)}";
                CheckAnswer(scnd);
            }

            if (count == 3)
            {
                string thrd = " ";
                CheckAnswer(thrd);

                if (number != InputNumber)
                {
                    lblCondition.Text = $"Вы не угадали! Загаданное число - {number}";
                    
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
            InputNumber = 0;
            lblCondition.Text = "За 3 попытки угадайте загаданное компьютером число";

            btnOK.Text = "OK";
            btnOK.Visible = true;
            
            btnСontinue.Text = "Сброс";

            number = MyRandomNumber();

            txtInputNumber.Mask = "000";
            txtInputNumber.Focus();
            txtInputNumber.Text = "";
            
            lblFirstNumber.Text = "Первое ваше число";
            lblSecondNumber.Text = "Второе ваше число";
            count = 1;               
            
        }

        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        /// <returns></returns>
        private int MyRandomNumber()
        {
            Random r = new Random();            
            return r.Next(1,101);;
        }

        /// <summary>
        /// Получаем результат сравнения чисел
        /// </summary>
        private void CheckAnswer(string inputString)
        {
            if (number == InputNumber)
            {
                lblCondition.Text = "Вы выиграли!!!";
                btnOK.Visible = false;
                btnСontinue.Text = "Продолжить";
            }

            else if (number > InputNumber && count < 3)
            {
                string endfraz = " - меньше загаданного";

                if(count == 1)lblFirstNumber.Text = inputString + endfraz;
                if(count == 2) lblSecondNumber.Text = inputString + endfraz;
                txtInputNumber.Text = " ";
                txtInputNumber.Focus();
            }
            else if (number < InputNumber && count < 3)
            {
                string endfraz = " - больше загаданного";

                if (count == 1) lblFirstNumber.Text = inputString + endfraz;
                if (count == 2) lblSecondNumber.Text = inputString + endfraz;
                txtInputNumber.Text = " ";
                txtInputNumber.Focus();
            }

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

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
