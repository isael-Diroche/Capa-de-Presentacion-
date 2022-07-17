using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Capa_de_Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void paintBasicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }
    }
}
