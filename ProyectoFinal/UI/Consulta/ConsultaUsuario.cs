using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;

namespace ProyectoFinal.UI.Consulta
{
    public partial class ConsultaUsuario : Form
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(FiltroComboBox, "No a selecionado ningun filtro");
                FiltroComboBox.Focus();
                paso = false;
            }

            if (CristerioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CristerioTextBox, "El campo Criterio esta vacio");
                CristerioTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void ConsultaUserbutton_Click_1(object sender, EventArgs e)
        {
            var listado = new List<Usuarios>();

            if (!Validar())
                return;

            if (CristerioTextBox.Text.Trim().Length > 0)
            {
                switch(FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = UsuarioBLL.GetList(p => true);
                        break;
                    case 1: //ID
                        int id = Convert.ToInt32(CristerioTextBox.Text);
                        listado = UsuarioBLL.GetList(p => p.UsuarioId == id);
                        break;
                    case 2://Nombre
                        listado = UsuarioBLL.GetList(p => p.Nombre.Contains(CristerioTextBox.Text));
                        break;
                    case 3://Email
                        listado = UsuarioBLL.GetList(p => p.Email.Contains(CristerioTextBox.Text));
                        break;
                    case 4://NivelUsuario
                        listado = UsuarioBLL.GetList(p => p.NivelUsuario.Contains(CristerioTextBox.Text));
                        break;
                    case 5://usuario
                        listado = UsuarioBLL.GetList(p => p.usuario.Contains(CristerioTextBox.Text));
                        break;
                }

                listado = listado.Where(c => c.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = UsuarioBLL.GetList(p => true);
            }

            ConsultaUserdataGridView.DataSource = null;
            ConsultaUserdataGridView.DataSource = listado;
        }
    }
}
