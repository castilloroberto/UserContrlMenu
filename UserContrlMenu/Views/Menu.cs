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
           
           
            
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {

            HideAll();
            btn_ventas.BackColor = Color.AliceBlue;
            
        }

        private void HideAll()
        {
            

            btn_ventas.BackColor = Color.FromName("ControlLight");
            btn_colaboradores.BackColor = Color.FromName("ControlLight");
            btn_inventario.BackColor = Color.FromName("ControlLight");
           
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {

            HideAll();
            btn_inventario.BackColor = Color.AliceBlue;
            
        }

        private void btn_colaboradores_Click(object sender, EventArgs e)
        {
            // quita el color de el bton seleccionado antes 
            HideAll();
            // establece el color de selccionado
            btn_colaboradores.BackColor = Color.AliceBlue;
           
        }
    }
}
