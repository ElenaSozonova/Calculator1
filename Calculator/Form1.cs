using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        ICalculator Calc; //переменная типа интерфейса с именем Calc
        double a; //временные переменные для хранения чисел
        double b;

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "division by 0  ")
            {
                if (textBox1.Text != "0")
                {
                    AddToTextBox("0");
                }
                else
                {
                    textBox1.Text = "0";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          if (textBox1.Text != "division by 0  ")
            { 
                if (textBox1.Text == "0")
                   {
                      textBox1.Text = "1";
                   }
                    else
                        AddToTextBox("1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "division by 0  ")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "2";
                }
                else
                    AddToTextBox("2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "division by 0  ")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "3";
                }
                else
                    AddToTextBox("3");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "division by 0  ")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "4";
                }
                else
                    AddToTextBox("4");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "division by 0  ")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "5";
                }
                else
                    AddToTextBox("5");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "division by 0  ")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "6";
                }
                else
                    AddToTextBox("6");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "division by 0  ")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "7";
                }
                else
                    AddToTextBox("7");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "division by 0  ")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "8";
                }
                else
                    AddToTextBox("8");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "division by 0  ")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "9";
                }
                else
                    AddToTextBox("9");
            }
        }

        private void AddToTextBox(string a) //доб чисел в текстбокс
        {
                textBox1.Text += a;     
        }

        private void Form1_Load(object sender, EventArgs e) //в событийной модели произойдет первым 
        {
            a = 0;
            b = 0;
            Calc = null; 
            textBox1.Text = "";
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void button13_Click(object sender, EventArgs e) // сложение 
        {
            if ((textBox1.Text != "") && (textBox1.Text != "division by 0  "))
            {
                if (Calc != null)
                {
                    a = Calc.DoCalc( a,Convert.ToDouble(textBox1.Text)); // сохраняются промежуточные значения 
                    textBox2.Text = (Convert.ToString(a)); // для проверок
                }
                else
                {
                    a = Convert.ToDouble(textBox1.Text); //чтобы сохранялось значение
                    textBox2.Text = (Convert.ToString(a)); // для проверок
                }
                textBox1.Text ="";

                Calc = new Addition();
                checkBox1.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void button14_Click(object sender, EventArgs e) // вычитание 
        {
            if ((textBox1.Text != "") && (textBox1.Text != "division by 0  "))
            {
                if (Calc != null)
                {
                    a = Calc.DoCalc(a, Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    a = Convert.ToDouble(textBox1.Text);
                }
                textBox1.Text ="";
                Calc = new Substraction();
                checkBox1.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void button15_Click(object sender, EventArgs e) //умножение 
        {
            if ((textBox1.Text != "") && (textBox1.Text != "division by 0  "))
            {
                if (Calc != null)
                {
                    a = Calc.DoCalc(a, Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    a = Convert.ToDouble(textBox1.Text);
                }
                textBox1.Text = "";
                Calc = new Multiplication();
                checkBox1.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }

        }
        private void button16_Click(object sender, EventArgs e) // деление 
        {
            b = Convert.ToDouble(textBox1.Text);
            if (b==0)
            {
                textBox1.Text = "division by 0";
            }
            else

            if ((textBox1.Text != "") && (textBox1.Text != "division by 0  "))
            {
                if (Calc != null)
                {
                    a = Calc.DoCalc(a, Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    a = Convert.ToDouble(textBox1.Text);
                }
                textBox1.Text = "";
                Calc = new Division();
                checkBox1.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }

        }
        private void button12_Click(object sender, EventArgs e) // =
        {

            if ((textBox1.Text != "") && (Calc != null) && (textBox1.Text != "division by 0  "))
            {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Calc.DoCalc(a, b) + "";

            }
            
        }

        private void button18_Click(object sender, EventArgs e) //смена знака 
        {
          if ((textBox1.Text!="") && (radioButton1.Checked == false) && (radioButton2.Checked == true) && (textBox1.Text != "division by 0  "))
            {
                double r = Convert.ToDouble(textBox1.Text);
                textBox1.Text = ("-" + r);
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
          else 
          if ((textBox1.Text != "") && (radioButton1.Checked == true) && (radioButton2.Checked == false) && (textBox1.Text != "division by 0  "))
            {
                double r = (Convert.ToDouble(textBox1.Text))*(-1);
                textBox1.Text = (Convert.ToString(r));
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void button11_Click(object sender, EventArgs e) //запятая 
        {

            if ((textBox1.Text != "") && (checkBox1.Checked == false) && (textBox1.Text != "division by 0  "))
            {
                checkBox1.Checked = true;
                AddToTextBox(",");
            }
            else
                if
                ((textBox1.Text == "") && (checkBox1.Checked == false) && (textBox1.Text != "division by 0  "))
            {
                checkBox1.Checked = true;
                AddToTextBox("0,");
            }
        }

        private void button19_Click(object sender, EventArgs e) //кнопка се
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = ("");
                checkBox1.Checked = false;
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
        }

    }
}
