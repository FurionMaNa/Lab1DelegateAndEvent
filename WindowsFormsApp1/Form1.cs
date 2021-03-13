using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static EventClass eventClass = new EventClass();
        private ProgressBar progressBar = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Width += 200;
                progressBar = new ProgressBar();
                progressBar.Location = new System.Drawing.Point(260, 12);
                progressBar.Width = 190;
                progressBar.Height = 50;
                progressBar.Maximum = 100;
                progressBar.Minimum = 0;
                progressBar.Value = 0;
                timer1.Start();
                
                this.Controls.Add(progressBar);
                
            } else
            {
                Width -= 200;
                this.Controls.Remove(progressBar);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = null;
            Form3 form3 = null;
            Form4 form4 = null;
            form2 = new Form2();
            form2.Show();
            form3 = new Form3();
            form3.Show();
            form4 = new Form4();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                eventClass.ClickEvent(sender, new ModifiedEventArgs(
                    Int32.Parse(textBox1.Text.Trim()),
                    Int32.Parse(textBox2.Text.Trim()),
                    Int32.Parse(textBox3.Text.Trim()),
                    Int32.Parse(textBox4.Text.Trim())));
            } 
            catch(Exception exception)
            {
                MessageBox.Show("Ошибка ввода", "Проверьте правильность введённых параметров", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == 50)
            {
                button1_Click(sender, e);
                button2_Click(sender, e);
                timer1.Stop();
            } else
            {
                progressBar.Value++;
            }
        }
    }
}
