using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score.Text = $"{GetScore(5)} - {GetScore(1)}";
        }

        private int GetScore(double lambda)
        {
            double S = 0; // Инициализируем переменную S для хранения суммы
            int m = 0;  // Инициализируем переменную m для подсчета итераций

            Random random = new Random(); // содаем для генерации случайных чисел

            while(S>= -lambda) // Запускаем цикл, который продолжается, пока S больше или равно -lambda
            {
                S += Math.Log(random.NextDouble()); // Генерируем случайное вещественное число между 0.0 и 1.0 и добавляем его натуральный логарифм к S
                m++; // увеличаем счетных итерации
            }
            return m;
        }
    }
}
