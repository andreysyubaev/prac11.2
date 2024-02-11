using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac11._2
{
    public partial class Form1 :Form
    {
        static Client client1 = new Client();
        public Form1 ()
        {
            InitializeComponent();
            
        }

        public class Client
        {
            public string surname;
            public string name;
            public string otc;
            public string fio;
            public string list;
            public string address;
            public string numbercard;

            public string SetName(string name, string surname, string otc)
            {
                string fio = surname + " " + name + " " + otc + " ";
                return fio;
            }

            public string SetInfo(string name, string surname, string otc, string address, string numbercard)
            {
                string info = $"{name} {surname} {otc} {address} {numbercard}";
                return info;
            }
        }


        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void numbercard_Click (object sender, EventArgs e)
        {

        }
        
        private void surname_Click (object sender, EventArgs e)
        {

        }

        private void acceptbutton_Click(object sender, EventArgs e)
        {
            client1.surname = textBox1.Text;
            client1.name = textBox2.Text;
            client1.otc = textBox3.Text;
            client1.address = textBox5.Text;
            client1.numbercard = textBox4.Text;

            if (string.IsNullOrWhiteSpace(client1.surname) || string.IsNullOrWhiteSpace(client1.name) || string.IsNullOrWhiteSpace(client1.otc) || string.IsNullOrWhiteSpace(client1.address) || string.IsNullOrWhiteSpace(client1.numbercard))
            {
                MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (client1.numbercard.Length != 16)
            {
                MessageBox.Show("Длина поля кредитной карты должна быть 16 символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Add(client1.SetInfo(client1.name, client1.surname, client1.otc, client1.address, client1.numbercard));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string address = textBox6.Text;
            string numbercard = textBox7.Text;

            foreach (string item in listBox1.Items)
            {
                string[] parts = item.Split(' ');

                if (parts.Length >= 5)
                {
                    string itemAddress = parts[3];
                    string itemNumberCard = parts[4];

                    if (address == itemAddress && numbercard == itemNumberCard)
                    {
                        listBox2.Items.Clear();
                        listBox2.Items.Add(item);
                        return;
                    }
                }
            }

            listBox2.Items.Clear();
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {
            //surname
        }

        private void textBox2_TextChanged (object sender, EventArgs e)
        {
            //name
        }

        private void textBox3_TextChanged (object sender, EventArgs e)
        {
            //otc
        }

        private void textBox5_TextChanged (object sender, EventArgs e)
        {
            //address 1
        }

        private void textBox6_TextChanged (object sender, EventArgs e)
        {
            //address 2
        }

        private void textBox4_TextChanged (object sender, EventArgs e)
        {
            //numbercard 1
        }

        private void textBox7_TextChanged (object sender, EventArgs e)
        {
            //numbercard 2
            
        }

        private void listBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            //вывод 1

        }

        private void listBox2_SelectedIndexChanged (object sender, EventArgs e)
        {
            //вывод 2

        }

        private void sort_Click (object sender, EventArgs e)
        {
            //сортировка по алфавиту
            client1.list = listBox1.SelectedIndex.ToString();
            listBox1.Sorted = true;
        }
    }
}
