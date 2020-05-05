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
namespace Lexical
{
    public partial class Form1 : Form
    {
        ////This Project is Created  By Hafiz Hamza(2017-Cs-19)
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Hide();
            textBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string input;
            input = textBox1.Text;
            File.WriteAllText("file.txt", input);
            string text = System.IO.File.ReadAllText("file.txt");
            
            LexicalAnalyzer analyzer = new LexicalAnalyzer();
            

            while (text != null)
            {

                for (int i = 0; i <= text.Length * (text.Length * text.Length * text.Length * text.Length); i++)
                {
                    text = text.Trim(' ', '\t');
                    string token = analyzer.GetNextLexicalAtom(ref text);
                 
                    
                        textBox2.AppendText(token);
                        textBox2.AppendText(Environment.NewLine);
                }
                break;
            }
           
            label1.Show();
            textBox2.Show();
           

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
