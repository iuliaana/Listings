using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SP_Gribova_Stroki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partBookTitle = textBox1.Text;
            string insertText = textBox2.Text;
            string bookTitle = partBookTitle.Insert(3, insertText);
            listBox1.Items.Add(bookTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox1.Text;
            // Удаляем подстроку с третьей позиции
            bookTitle = bookTitle.Remove(2);
            listBox1.Items.Add(bookTitle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox1.Text;
            // Извлекаем подстроку с шестой позиции с размером в три символа
            bookTitle = bookTitle.Substring(5, 3);
            listBox1.Items.Add(bookTitle);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            int i = str2.IndexOf(str1);
            // Проверяем, входит ли строка око в слово Царь-колокол
            if (i >= 0) listBox1.Items.Add(str1 + " входит в строку " + str2);
            else listBox1.Items.Add("ничего не входит");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog; // получим 41
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox1.Text += Environment.NewLine + all.ToString(); // получим 5 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Unicode-код для торговой марки
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text += specialChar.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Создаем строку из 5 звездочек
            System.String FiveStars = new System.String('*', 5);
            textBox1.Text = FiveStars;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string AutoName;
            AutoName = "BMW";
            textBox1.Text =
            String.Format("Стоимость {0} равна {1:0.0;c}", AutoName, 12000);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Задаем цвет
            Color clr = Color.Blue;
            // Получим имя выбранного цвета
            textBox1.Text =
            (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            // Обратная задача. Конвертируем название цвета Green в объект Color
            clr = (Color)TypeDescriptor.GetConverter(
            typeof(Color)).ConvertFromString("Green");
            // Закрашиваем форму в выбранный цвет
            this.BackColor = clr;
        }



        private void button13_Click(object sender, EventArgs e)
        {

            // Взять текст из текстового поля
            // Например, А роза упала на лапу Азора
            string myString = textBox1.Text;
            // Используем встроенную функцию Visual Basic
            textBox1.Text = Strings.StrReverse(myString);
        }



        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool PathCompactPathEx(
        System.Text.StringBuilder pszOut,
        string pszSrc,
        Int32 cchMax,
        Int32 dwFlags);

        private void button15_Click(object sender, EventArgs e)
        {
            // длинный путь к файлу
            string strPathFile =
            "c:/program files/My SuperProgram/skins/sample.txt";
            StringBuilder sb = new StringBuilder(260);
            // оставляем 20 символов, остальное заменяем многоточием
            bool b = PathCompactPathEx(sb, strPathFile, 20 + 1, 0);
            // Выводим результат в текстовое поле
            textBox1.Text = sb.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Старт")
            {
                timer1.Enabled = true;
                textBox1.Text = "Стоп";
            }
            else
            {
                timer1.Enabled = false;
                textBox1.Text = "Старт";
            }
        }
        public static int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string typingText = "C#.Народные советы";

            textBox2.Text = typingText.Substring(0, counter);
            counter++;
            if (counter > typingText.Length)
                counter = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
        // Исходная строка. Для большего удобства добавлено несколько пробелов
        // в конец строки
        private string scrollText = "C#.Народные советы ";
        private void timer2_Tick(object sender, EventArgs e)
        {
            // Удаляем один символ слева и прибавляем его с правой стороны
            scrollText = scrollText.Substring(1, (scrollText.Length - 1)) + scrollText.Substring(0, 1);
            listBox1.Items.Add(scrollText);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }     