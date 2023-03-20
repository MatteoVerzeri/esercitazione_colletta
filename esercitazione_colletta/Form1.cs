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
        Dictionary<Colletta, Importo> tabella = new Dictionary<Colletta, Importo>();
        Colletta persona;
        Importo importo;
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
                persona = new Colletta(cont.ToString(), textBox6.Text, textBox3.Text);
                importo = new Importo(double.Parse(textBox4.Text), textBox5.Text);
                cont++;
                tabella.Add(persona, importo);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                persona = new Colletta(cont.ToString(), textBox6.Text, textBox3.Text);
                tabella.Remove(persona);
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("chiave non trovata");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            persona = new Colletta(cont.ToString(), textBox6.Text, textBox3.Text);
            importo = new Importo(double.Parse(textBox4.Text), textBox5.Text);
            foreach (KeyValuePair<Colletta, Importo> kvp in tabella)
            {
                if(kvp.Key == persona)
                {
                    tabella.Add(persona, importo);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tmp = null;
            foreach (KeyValuePair<Colletta, Importo> kvp in tabella)
            {
                tmp = tmp + kvp.ToString() + "\n";
            }
            MessageBox.Show(tmp);
        }
    }
}
