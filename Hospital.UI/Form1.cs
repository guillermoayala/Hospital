using Hospital.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarCitas();
        }


        CitaBL citaBl = new CitaBL();
        
        private void MostrarCitas()
        {
            dataGridView1.DataSource = CitaBl.MostrarCitas();
        }
    }
}
