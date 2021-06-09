using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserContrlMenu.Views
{
    public partial class InventarioView : UserControl
    {
        public InventarioView()
        {
            InitializeComponent();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hola esta es la pestaña {this.Name}", $"{this.Name}");

        }
    }
}
