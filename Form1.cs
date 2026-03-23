using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        private string defaultImageUrl = "https://via.placeholder.com/150?text=No+Photo";

        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string nick = textBox2.Text;
            string photoUrl = string.IsNullOrWhiteSpace(textBox4.Text) ? defaultImageUrl : textBox4.Text;

            if (int.TryParse(textBox3.Text, out int age))
            {
                UserControl1 item = new UserControl1(name, nick, age, photoUrl);
                item.OnDelete += Item_OnDelete;
                flowLayoutPanel1.Controls.Add(item);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Введіть коректний вік!");
            }
        }

        private void Item_OnDelete(object sender, EventArgs e)
        {
            if (sender is UserControl control)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}