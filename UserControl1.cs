using System;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler OnDelete;

        public UserControl1(string name, string nick, int age, string imageUrl)
        {
            InitializeComponent();

            label1.Text = name;
            label2.Text = nick;
            label3.Text = age.ToString() + " років";

            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Load(imageUrl);
            }
            catch
            {
                try { pictureBox1.Load("https://via.placeholder.com/150?text=Error"); }
                catch { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(this, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}