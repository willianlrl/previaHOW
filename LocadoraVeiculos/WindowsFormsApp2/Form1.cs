﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vEÍCULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroModelo cm = new cadastroModelo();
            cm.Show();
        }

        private void mARCASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroMarca cm = new cadastroMarca();
            cm.Show();
        }

        private void cADASTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vEÍCULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroVeiculo cv = new cadastroVeiculo();
            cv.Show();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroCliente cc = new cadastroCliente();
            cc.Show();
        }

        private void lOCAÇÃOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadastroLocacao cl = new cadastroLocacao();
            cl.Show();
        }
    }
}
