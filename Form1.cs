namespace Csharp_读取txt练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<double> negativeX = new List<double>();
        public List<double> yValues = new List<double>();

        // 记录每次加载的范围
        public int hoodStartIndex = -1;
        public int hoodEndIndex = -1;
        public int rearDoorStartIndex = -1;
        public int rearDoorEndIndex = -1;

        private void CarHood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Reading_Hood();
                MessageBox.Show("yValues" + yValues.Count);
                MessageBox.Show("车机盖轨迹已添加");
            }
            else
            {
                Delete_Hood();
                MessageBox.Show("车机盖轨迹已删除");
            }
        }
        private void CarRightDoor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Reading_RearDoor();
                MessageBox.Show("yValues" + yValues.Count);
                MessageBox.Show("车右后门轨迹已添加");
            }
            else
            {
                Delete_RearDoor();
                MessageBox.Show("车右后门轨迹已删除");
            }
        }

        public void Reading_Hood()
        {
            string filePath = "E:/Csharp/result_车机盖轨迹.txt"; // 替换为文件路径
            hoodStartIndex = negativeX.Count; // 记录起始位置

            // 逐行读取文件
            foreach (string line in File.ReadLines(filePath))
            {
                // 按空格分割数据
                string[] columns = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // 确保至少有两列数据
                if (columns.Length >= 2)
                {
                    double x = double.Parse(columns[0]);
                    double y = double.Parse(columns[1]);

                    negativeX.Add(-x);   // 取x的负值
                    yValues.Add(y);      // 存y值
                }
            }

            hoodEndIndex = negativeX.Count - 1; // 记录结束位置

        }

        public void Reading_RearDoor()
        {
            string filePath = "E:/Csharp/result_车右后门轨迹.txt"; // 替换为文件路径
            rearDoorStartIndex = negativeX.Count; // 记录起始位置

            // 逐行读取文件
            foreach (string line in File.ReadLines(filePath))
            {
                // 按空格分割数据
                string[] columns = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // 确保至少有两列数据
                if (columns.Length >= 2)
                {
                    double x = double.Parse(columns[0]);
                    double y = double.Parse(columns[1]);

                    negativeX.Add(-x);    // 取x的负值
                    yValues.Add(y);       // 存y值
                }
            }
            rearDoorEndIndex = negativeX.Count - 1; // 记录结束位置
        }

        public void Delete_Hood()
        {
            if (hoodStartIndex >= 0 && hoodEndIndex >= hoodStartIndex)
            {
                int count = hoodEndIndex - hoodStartIndex + 1;
                negativeX.RemoveRange(hoodStartIndex, count);
                yValues.RemoveRange(hoodStartIndex, count);

                // 重置索引
                hoodStartIndex = -1;
                hoodEndIndex = -1;
            }
            else
            {
                MessageBox.Show("没有可删除的车机盖轨迹数据");
            }
        }

        public void Delete_RearDoor()
        {
            if (rearDoorStartIndex >= 0 && rearDoorEndIndex >= rearDoorStartIndex)
            {
                int count = rearDoorEndIndex - rearDoorStartIndex + 1;
                negativeX.RemoveRange(rearDoorStartIndex, count);
                yValues.RemoveRange(rearDoorStartIndex, count);

                // 重置索引
                rearDoorStartIndex = -1;
                rearDoorEndIndex = -1;
            }
            else
            {
                MessageBox.Show("没有可删除的车右后门轨迹数据");
            }
        }

        private void SeeHowManyYvalue_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("y长度是= " + yValues.Count + "\n测试第一个数是" + yValues[0] + "\n测试第二个数是" + yValues[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
    }
}
