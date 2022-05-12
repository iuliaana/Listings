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
            listBox1.Items.Add("Введите первое число: ");
            x = Convert.ToInt32(Console.ReadLine());
            listBox1.Items.Add("Введите второе число: ");
            y = Convert.ToInt32(Console.ReadLine());
            listBox1.Items.Add("Введите третье число: ");
            z = Convert.ToInt32(Console.ReadLine());

            listBox1.Items.Add("Наибольшее число из трех: " +
            FindMax3(x, y, z));
            listBox1.Items.Add("Наименьшее число из трех: " +
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
            

            String[] s = Regex.Split("Январь Февраль Март Апрель Май Июнь Июль Август Сентябрь Октябрь Ноябрь Декабрь", " "); 
        }
        
            private void button3_Click(object sender, EventArgs e)
        {
                String[] s = Regex.Split("Январь Февраль Март Апрель Май Июнь Июль Август Сентябрь Октябрь Ноябрь Декабрь", " ");
 // Выводим 12 элемент массива
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