using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = listBox1.Items.Count.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
            textBox4.Text = listBox1.SelectedIndex.ToString();
            textBox3.Text = listBox1.Items.GetType().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] arr = { "Строка 1", "Строка 2", "Строка 3", "Строка 4"};
            listBox1.Items.AddRange(arr);
            textBox2.Text = listBox1.Items.Count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool check = listBox1.Items.Contains(textBox9.Text);
            textBox10.Text = check.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox2.Text = listBox1.Items.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("Введіть індекс", "Помилка");
                return;
            }
            if (listBox1.Items.Count > Convert.ToInt32(textBox8.Text))
            {
                listBox1.Items.RemoveAt(Convert.ToInt32(textBox8.Text));
                textBox2.Text = listBox1.Items.Count.ToString();
            }
            else MessageBox.Show("Введіть коректний індекс", "Помилка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Рядок для вставки пустий. Введіть його", "Помилка");
                return;
            }

            if (textBox7.Text == "")
            {
                MessageBox.Show("Введіть коректний індекс", "Помилка");
                return;
            }

            if (listBox1.Items.Count >= Convert.ToInt32(textBox7.Text))
            {
                listBox1.Items.Insert(Convert.ToInt32(textBox7.Text), textBox6.Text);
                textBox6.Clear();
                textBox7.Clear();
                textBox2.Text = listBox1.Items.Count.ToString();
            }
            else MessageBox.Show("Введіть коректний індекс", "Помилка");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                if (listBox1.Items.Contains(textBox5.Text) == true)
                {
                    listBox1.Items.Remove(textBox5.Text);
                    textBox5.Clear();
                    textBox2.Text = listBox1.Items.Count.ToString();
                }
                else MessageBox.Show("Такий рядок не існує. Введіть інший рядок", "Помилка");
            }
            else MessageBox.Show("Рядок для видалення пустий. Введіть його", "Помилка");
            
        }
    }
}
