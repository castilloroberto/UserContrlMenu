using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserContrlMenu.Views
{
    public partial class ColaboradoresView : UserControl
    {
        public ColaboradoresView()
        {
            InitializeComponent();
            
        }

        private void btn_colaboradores_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hola esta es la pestaña {this.Name}", $"{this.Name}");

        }
    }
}
