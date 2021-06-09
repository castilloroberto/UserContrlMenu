using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserContrlMenu.Views
{
    public partial class VentasView : UserControl
    {
        public VentasView()
        {
            InitializeComponent();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola esta es la pestaña ventas","Ventas");
        }
    }
}
