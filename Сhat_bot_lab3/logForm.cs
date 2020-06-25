using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сhat_bot_lab3
{
    public partial class logForm : Form
    {
        public logForm()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели имя");
            }
            else
            {
                Form1 tmp = new Form1();
                tmp.bot.LoadHistory(textBox1.Text);
                tmp.Show();
                tmp.RestoreChat();
                this.Hide();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        private void LogForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Button1_Click(button1, null);
            }
        }

        Point lastPoint;
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // перемещение окна 
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.LightSkyBlue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Info = "Чат бот" + "\n\n" +
                "Работал над программой Флоря АА" + "\n\n" +
                "Бот может выполнять следующие команды: " + "\n\n" +
                "Привет,хай" + "\n\n" +
                "Скажи мне время, сколько сейчас времени, время" + "\n\n" +
                "какое сегодня числo, Скажи дату, число" + "\n\n" +
                "Сложи(число) на (число), умножь (число) на (число), вычти (число) на (число), раздели (число) на (число)" + "\n\n" +
                "погода,какая сегодня погода" + "\n\n" +
                "чем заняться дома";
            MessageBox.Show(Info, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
