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
            // ������� ��������� � ������� �������
            bookTitle = bookTitle.Remove(2);
            listBox1.Items.Add(bookTitle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox1.Text;
            // ��������� ��������� � ������ ������� � �������� � ��� �������
            bookTitle = bookTitle.Substring(5, 3);
            listBox1.Items.Add(bookTitle);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            int i = str2.IndexOf(str1);
            // ���������, ������ �� ������ ��� � ����� ����-�������
            if (i >= 0) listBox1.Items.Add(str1 + " ������ � ������ " + str2);
            else listBox1.Items.Add("������ �� ������");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog; // ������� 41
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox1.Text += Environment.NewLine + all.ToString(); // ������� 5 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Unicode-��� ��� �������� �����
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text += specialChar.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // ������� ������ �� 5 ���������
            System.String FiveStars = new System.String('*', 5);
            textBox1.Text = FiveStars;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string AutoName;
            AutoName = "BMW";
            textBox1.Text =
            String.Format("��������� {0} ����� {1:0.0;c}", AutoName, 12000);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // ������ ����
            Color clr = Color.Blue;
            // ������� ��� ���������� �����
            textBox1.Text =
            (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            // �������� ������. ������������ �������� ����� Green � ������ Color
            clr = (Color)TypeDescriptor.GetConverter(
            typeof(Color)).ConvertFromString("Green");
            // ����������� ����� � ��������� ����
            this.BackColor = clr;
        }



        private void button13_Click(object sender, EventArgs e)
        {

            // ����� ����� �� ���������� ����
            // ��������, � ���� ����� �� ���� �����
            string myString = textBox1.Text;
            // ���������� ���������� ������� Visual Basic
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
            // ������� ���� � �����
            string strPathFile =
            "c:/program files/My SuperProgram/skins/sample.txt";
            StringBuilder sb = new StringBuilder(260);
            // ��������� 20 ��������, ��������� �������� �����������
            bool b = PathCompactPathEx(sb, strPathFile, 20 + 1, 0);
            // ������� ��������� � ��������� ����
            textBox1.Text = sb.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "�����")
            {
                timer1.Enabled = true;
                textBox1.Text = "����";
            }
            else
            {
                timer1.Enabled = false;
                textBox1.Text = "�����";
            }
        }
        public static int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string typingText = "C#.�������� ������";

            textBox2.Text = typingText.Substring(0, counter);
            counter++;
            if (counter > typingText.Length)
                counter = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
        // �������� ������. ��� �������� �������� ��������� ��������� ��������
        // � ����� ������
        private string scrollText = "C#.�������� ������ ";
        private void timer2_Tick(object sender, EventArgs e)
        {
            // ������� ���� ������ ����� � ���������� ��� � ������ �������
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