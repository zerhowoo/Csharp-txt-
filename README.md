# Csharp 读取txt练习

//多线程练习

namespace TextBox文本框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // 不需要在此处理逻辑，仅监听输入变化
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            // 不需要在此处理逻辑，仅监听输入变化
        }

        private void Minus()
        {
            // 获取两个文本框的输入值
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            // 尝试将输入值转换为数字并相加
            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                double result = number1 - number2;
                MessageBox.Show("相减结果是 " + result); // 显示结果
            }
            else
            {
                MessageBox.Show("请输入有效的数字"); // 错误提示
            }
        }

        private void Addition()
        {
            // 获取两个文本框的输入值
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            // 尝试将输入值转换为数字并相加
            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                double result = number1 + number2;
                MessageBox.Show("相加结果是 " + result); // 显示结果
            }
            else
            {
                MessageBox.Show("请输入有效的数字"); // 错误提示
            }
        }

        private void Division()
        {
            // 获取两个文本框的输入值
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            // 尝试将输入值转换为数字并相加
            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                double result = number1 / number2;
                MessageBox.Show("相除结果是 " + result); // 显示结果
            }
            else
            {
                MessageBox.Show("请输入有效的数字"); // 错误提示
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            // 获取两个文本框的输入值
            Thread.Sleep(2000);
            Addition();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Minus();
        }
        private void btnThreadMinus_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
               Minus();
            });
            t.Start();
        }
        private void btnTaskDivision_Click(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Run(() =>
            {
                Thread.Sleep(3000);
                Division();
            }));

            tasks.Add(Task.Run(() =>
            {
                Thread.Sleep(3000);
                Addition();
            }));

            Task.WhenAll(tasks).ContinueWith(a =>
            {
                Minus();
            });

        }
    }
}
