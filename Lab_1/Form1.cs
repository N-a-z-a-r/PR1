using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //створення обʼєкту класу табулювання
            Tabul tabul = new Tabul();
            //Оголошення зміних
            double xn, xk, h, a;
            //Зчитування даних з форми
            xn = Convert.ToDouble(this.textBox1.Text);
            xk = Convert.ToDouble(this.textBox2.Text);
            h = Convert.ToDouble(this.textBox3.Text);
            a = Convert.ToDouble(this.textBox4.Text);


            //Очищуємо грід та графік
            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul.tab(xn, xk, h, a);
            //У циклі заносимо дані у грид та на графік
            for (int i = 0; i < tabul.n; i++)
            {//Округлюємо дані до 2-х знаків після коми
                dataGridView1.Rows.Add(Math.Round(tabul.xy[i,0],2).ToString(),
                    Math.Round(tabul.xy[i,1],3).ToString());
                chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
            }//створення обʼєкту класу табулювання
        }
    }
}
