using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserContrlMenu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            HideAll();
            ventasView1.Show();
            
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {

            HideAll();
            btn_ventas.BackColor = Color.AliceBlue;
            ventasView1.Show();
        }

        private void HideAll()
        {
            colaboradoresView1.Hide();
            ventasView1.Hide();
            inventarioView1.Hide();

            btn_ventas.BackColor = Color.FromName("ControlLight");
            btn_colaboradores.BackColor = Color.FromName("ControlLight");
            btn_inventario.BackColor = Color.FromName("ControlLight");
            //btn_colaboradores.BackColor = Color.LightCoral;
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {

            HideAll();
            btn_inventario.BackColor = Color.AliceBlue;
            inventarioView1.Show();
        }

        private void btn_colaboradores_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_colaboradores.BackColor = Color.AliceBlue;
            colaboradoresView1.Show();
        }
    }
}
