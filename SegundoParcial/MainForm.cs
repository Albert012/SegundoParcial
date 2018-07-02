using SegundoParcial.UI.Consultas;
using SegundoParcial.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Saliendo Del Segundo Parcial De >>>Albert De Jesus<<<", "Salida Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Close();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rMatenimiento reg = new rMatenimiento();
            reg.MdiParent = this.MdiParent;
            reg.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cConsulta cons = new cConsulta();
            cons.MdiParent = this.MdiParent;
            cons.Show();
        }
    }
}
