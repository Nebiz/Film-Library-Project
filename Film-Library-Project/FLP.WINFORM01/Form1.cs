using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FLP.Library01;

namespace FLP.WINFORM01
{
    public partial class Form1 : Form
    {
        public Personne Pers { get; set; }
        public Form1()
        {
            InitializeComponent();
            Pers = new Personne("Ben", 21);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FLP.Library01.Serialize.SerializeLibrary(Pers);
        }
    }
}
