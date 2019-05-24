using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.UI.Registro;
using ProyectoFinal.UI.Consulta;

namespace ProyectoFinal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario ru = new RegistroUsuario();
            ru.Show();
        }

        private void registroCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCargo rc = new RegistroCargo();
            rc.Show();
        }

        private void consultaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuario cu = new ConsultaUsuario();
            cu.Show();
        }
    }
}
