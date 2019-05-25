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
    public partial class ConsultaCargo : Form
    {
        public ConsultaCargo()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroCargocomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(FiltroCargocomboBox, "No a selecionado ningun filtro");
                FiltroCargocomboBox.Focus();
                paso = false;
            }

            if (CriterioCargoTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CriterioCargoTextBox, "El campo Criterio esta vacio");
                CriterioCargoTextBox.Focus();
                paso = false;
            }
            return paso;
        }
  
        private void ConsultaCargobutton_Click_1(object sender, EventArgs e)
        {
            var listado = new List<Cargos>();

            if (!Validar())
                return;

            if (CriterioCargoTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroCargocomboBox.SelectedIndex)
                {
                    case 0:
                        listado = CargoBLL.GetList(p => true);
                        break;
                    case 1: //ID
                        int id = Convert.ToInt32(CriterioCargoTextBox.Text);
                        listado = CargoBLL.GetList(p => p.CargoId == id);
                        break;
                    case 2://Descripcion
                        listado = CargoBLL.GetList(p => p.Descripcion.Contains(CriterioCargoTextBox.Text));
                        break;
                }

                //listado = listado.Where(c => c.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = CargoBLL.GetList(p => true);
            }

            ConsultaCargoDataGridView.DataSource = null;
            ConsultaCargoDataGridView.DataSource = listado;
        }
    }
}
