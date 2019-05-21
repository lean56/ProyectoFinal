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
    }
}
