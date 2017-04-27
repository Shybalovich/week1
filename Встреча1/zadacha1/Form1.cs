using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace zadacha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"..\..\Summary.txt";
            try
            {
                using (StreamReader text = new StreamReader(path, Encoding.Default))
                {
                    long length = text.BaseStream.Length;                           // общее количество символов
                    string caption = "/" + length;                                  // заголовок
                    string line = "";                                               // считываемая строка
                    long count = 0;                                                 // прочитанноуе количество символов
                    var x1 = text.Peek();
                    while ((line = text.ReadLine()) != null)
                    {
                        count += line.Length;
                        MessageBox.Show(line, count + caption);
                        count += 2;                                                 // добавляем количество (два) упровляющих символо переноса строки
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }
    
    }
}
