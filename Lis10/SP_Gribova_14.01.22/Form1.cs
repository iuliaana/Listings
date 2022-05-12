namespace SP_Gribova_14._01._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] astrLogicalDrives = System.IO.Directory.GetLogicalDrives();
            foreach (string disk in astrLogicalDrives)
                listBox1.Items.Add(disk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Выводим информацию о диске
            System.IO.DriveInfo drv = new System.IO.DriveInfo(@"d:\");
            listBox1.Items.Clear();
            listBox1.Items.Add("Диск: " + drv.Name);

            if (drv.IsReady)
            {
                listBox1.Items.Add("Тип диска: " + drv.DriveType.ToString());
                listBox1.Items.Add("Файловая система: " +
                drv.DriveFormat.ToString());
                listBox1.Items.Add("Свободное место на диске: " +
                drv.AvailableFreeSpace.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получим список папок на диске D:
            listBox1.Items.Clear();
            string[] astrFolders = System.IO.Directory.GetDirectories(@"d:\");
            foreach (string folder in astrFolders)
                listBox1.Items.Add(folder);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Получим список папок, где встречается буквосочетание pro
            listBox1.Items.Clear();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"d:\");
            System.IO.DirectoryInfo[] folders = di.GetDirectories("*pro*");
            foreach (System.IO.DirectoryInfo maskdirs in folders)
                listBox1.Items.Add(maskdirs);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\windows"))
                label1.Text = "Папка " + @"C:\Windows" + " существует";
            else
                label1.Text = "Папка не существует";
        }
    }
}