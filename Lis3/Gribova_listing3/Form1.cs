using System.Text.RegularExpressions;
namespace Gribova_listing3
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int x;
            int y;
            int z;
            listBox1.Items.Add("������� ������ �����: ");
            x = Convert.ToInt32(Console.ReadLine());
            listBox1.Items.Add("������� ������ �����: ");
            y = Convert.ToInt32(Console.ReadLine());
            listBox1.Items.Add("������� ������ �����: ");
            z = Convert.ToInt32(Console.ReadLine());

            listBox1.Items.Add("���������� ����� �� ����: " +
            FindMax3(x, y, z));
            listBox1.Items.Add("���������� ����� �� ����: " +
            FindMin3(x, y, z));


        }

        public static int FindMax3(int x, int y, int z)
        {
            int max;
            max = Math.Max(x, Math.Max(y, z));
            return max;
        }

        public static int FindMin3(int x, int y, int z)

        {
            int min;
            min = Math.Min(x, Math.Min(y, z));
            return min;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            String[] s = Regex.Split("������ ������� ���� ������ ��� ���� ���� ������ �������� ������� ������ �������", " "); 
        }
        
            private void button3_Click(object sender, EventArgs e)
        {
                String[] s = Regex.Split("������ ������� ���� ������ ��� ���� ���� ������ �������� ������� ������ �������", " ");
 // ������� 12 ������� �������
 Console.WriteLine(s[11]);
            }

        public static double ConvertRadiansToDegrees(double radians)
        {
            double degrees = (180 / Math.PI) * radians;
            return degrees;
        }
        public static double ConvertDegreesToRadians(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return radians;
        }
    }
}