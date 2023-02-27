using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercitazione_colletta
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> persone = new Dictionary<string, double>();
        public void aggiunta(double cifra, string nome)
        {
            persone[nome] = cifra;
        }
        public void rimozione(double cifra, string nome)
        {
            persone.Remove(nome);
        }
        public void visualizza()
        {
            Dictionary<string, double>.KeyCollection keyColl = persone.Keys;

            string a = null;
            foreach(KeyValuePair<string, double> s in persone)
            {
                a += s.Key + Convert.ToDouble(s.Value) + "\n";
            }
                
            
            MessageBox.Show(a);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aggiunta(double.Parse(textBox2.Text), textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rimozione(double.Parse(textBox2.Text), textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aggiunta(double.Parse(textBox2.Text), textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visualizza();
        }
    }
}
