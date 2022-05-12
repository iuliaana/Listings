using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Gribova_Stroki
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("строка 1");
            sb.Append("строка 2");
            listBox1.Items.Add(sb.ToString());
        }

      
        private void button19_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            listBox1.Items.Add(today.Date.ToLongDateString());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            listBox1.Items.Clear();
            listBox1.Items.Add("d: " + dt.ToString("d"));
            listBox1.Items.Add("D: " + dt.ToString("D"));
            listBox1.Items.Add("f: " + dt.ToString("f"));
            listBox1.Items.Add("F: " + dt.ToString("F"));
            listBox1.Items.Add("g: " + dt.ToString("g"));
            listBox1.Items.Add("G: " + dt.ToString("G"));
            listBox1.Items.Add("m: " + dt.ToString("m"));
            listBox1.Items.Add("r: " + dt.ToString("r"));
            listBox1.Items.Add("s: " + dt.ToString("s"));
            listBox1.Items.Add("u: " + dt.ToString("u"));
            listBox1.Items.Add("U: " + dt.ToString("U"));
            listBox1.Items.Add("y: " + dt.ToString("y"));
            listBox1.Items.Add("MMMM dd: " + dt.ToString("MMMM dd"));
            listBox1.Items.Add("MM/dd/yyyy: " + dt.ToString("MM/dd/yyyy"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm: " +
            dt.ToString("MM/dd/yyyy HH:mm"));
            listBox1.Items.Add("MM/dd/yyyy hh:mm tt: " +
            dt.ToString("MM/dd/yyyy hh:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy H:mm: " +
            dt.ToString("MM/dd/yyyy H:mm"));
            listBox1.Items.Add("MM/dd/yyyy h:mm tt: " +
            dt.ToString("MM/dd/yyyy h:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm:ss: " +
            dt.ToString("MM/dd/yyyy HH:mm:ss"));

            listBox1.Items.Add("dddd, dd MMMM yyyy: " +
            dt.ToString("dddd, dd MMMM yyyy"));
            listBox1.Items.Add("dddd, dd MMMM yyyy HH:mm:ss: " +
            dt.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            listBox1.Items.Add("ddd, dd MMM yyyy HH':'mm':'ss 'GMT': " +
            dt.ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"));

            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"));
            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            listBox1.Items.Add("yyyy MMMM: " + dt.ToString("yyyy MMMM"));
            listBox1.Items.Add("H:mm: " + dt.ToString("H:mm"));
            listBox1.Items.Add("HH:mm: " + dt.ToString("HH:mm"));
            listBox1.Items.Add("HH:mm:ss: " + dt.ToString("HH:mm:ss"));
            listBox1.Items.Add("h:mm tt: " + dt.ToString("h:mm tt"));
            listBox1.Items.Add("hh:mm tt: " + dt.ToString("hh:mm tt"));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.UtcNow;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.UtcNow == dt)
                    {
                        /* do action */
                    }
                }
                listBox1.Items.Add(sw.ElapsedTicks.ToString());

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DateTime curdate = DateTime.Now;
            // Прибавляем семь дней к текущей дате
            DateTime mydate = curdate.AddDays(7);
            listBox1.Items.Add(mydate.ToShortDateString());
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1945, 5, 9); // Первая дата
            DateTime date2 = new DateTime(2007, 8, 21); // Вторая дата
                                                        // Вычисляем разницу в днях при помощи перечисления DateInterval.Day
            long diff = DateAndTime.DateDiff(DateInterval.Day, date1, date2,
            FirstDayOfWeek.Monday, FirstWeekOfYear.System);
            // Выводим результат в заголовке формы
            this.Text = diff.ToString();
        }

        public static int Button24_Click(object sender, EventArgs e, DateTime date1, DateTime date2)
        {



            string howdays = DaysDiff(DateTime.Today,
            new DateTime(2003, 04, 18)).ToString();
            listBox1.Items.Add("Со дня моего дня рождения прошло: " + howdays);

        }

        private static object DaysDiff(DateTime today, DateTime dateTime)
        {
            return date1.Subtract(date2.Date).Days;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool leapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            listBox1.Items.Add(
             String.Format("{0} является високосным годом: {1}",
             DateTime.Now.Year, leapYear));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Алгоритм для вычисления католической Пасхи
            /// http://snippets.dzone.com/posts/show/765
            /// </summary>
            /// <param name="year">Год</param>
            /// <returns>Пасха</returns>

            {
                int Y = year;
                int a = Y % 19;
                int b = Y / 100;
                int c = Y % 100;
                int d = b / 4;
                int e = b % 4;
                int f = (b + 8) / 25;
                int g = (b - f + 1) / 3;
                int h = (19 * a + b - d - g + 15) % 30;
                int i = c / 4;
                int k = c % 4;
                int L = (32 + 2 * e + 2 * i - h - k) % 7;
                int m = (a + 11 * h + 22 * L) / 451;
                int month = (h + L - 7 * m + 114) / 31;
                int day = ((h + L - 7 * m + 114) % 31) + 1;
                DateTime dt = new DateTime(year, month, day);
                return dt;
            }

            {
                // когда была католическая Пасха в 2006 году
                listBox1.Items.Add(EasterDate(2006).ToLongDateString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int parrots = 38;
            textBox1.Text = parrots.ToString("X8");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int myvalue = 4;
            textBox1.Text = Convert.ToString(myvalue, 2); // возвратит 100
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int myValue = 365;
            // Преобразуем в восьмеричное значение
            listBox1.Items.Add(Convert.ToString(myValue, 8));
            // Преобразуем в шестнадцатеричное значение
            listBox1.Items.Add(Convert.ToString(myValue, 16));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // введите в текстовое поле любое число или слово
            string numstring = textBox1.Text;
            bool bResult1;
            bResult1 = Information.IsNumeric(numstring);
            listBox1.Items.Add("Является ли " + numstring + " числом: " + bResult1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Возвращаемое значение
            bool isNum;
            // Переменная, используемая в качестве параметра
            // в методе TryParse
            double retNum;
            // Метод TryParse конвертирует строку в заданный стиль
            // и локальный формат.
            isNum = Double.TryParse(Convert.ToString(Expression),
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
            listBox1.Items.Add("Является ли " + textBox1.Text +
 " числом: " + IsNumeric(textBox1.Text));
        }
    }
    }
}
}
