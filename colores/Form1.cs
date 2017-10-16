using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace colores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(cboColores.SelectedItem.ToString());
        }

        
        
            
    }
}