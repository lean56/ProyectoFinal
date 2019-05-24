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


namespace ProyectoFinal.UI.Registro
{
    public partial class RegistroCargo : Form
    {
        public RegistroCargo()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            CargoId.Value = 0;
            DescripcionTextBox.Text = string.Empty;
        }


        private Cargos LlenarClase()
        {
            Cargos cargo = new Cargos();
            cargo.CargoId = Convert.ToInt32(CargoId.Value);
            cargo.Descripcion = DescripcionTextBox.Text;
            return cargo;
        }

        private void LlenaCampo(Cargos cargo)
        {
            CargoId.Value = cargo.CargoId;
            DescripcionTextBox.Text = cargo.Descripcion;           
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Cargos cargo = CargoBLL.Buscar((int)CargoId.Value);

            return (cargo != null);
        }


        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cargos cargo;
            bool paso = false;

            //if (!Validar())
              //  return;

            cargo = LlenarClase();
            Limpiar();

            if (CargoId.Value == 0)
                paso = CargoBLL.Guardar(cargo);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CargoBLL.Modificar(cargo);
            }

            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
                MessageBox.Show("Error al Guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
          //  MyErrorProvider.Clear();

            int id;
            int.TryParse(CargoId.Text, out id);
            Limpiar();

            if (CargoBLL.Eliminar(id))
            {
                MessageBox.Show("Elimino el ID: " + id + "", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
           // else
               // MyErrorProvider.SetError(IdnumericUpDown, "Id no Existe");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Cargos cargo = new Cargos();
            int.TryParse(CargoId.Text, out id);

            Limpiar();

            cargo = CargoBLL.Buscar(id);

            if (cargo != null)
            {
                MessageBox.Show("Cargo Encontrado");
                LlenaCampo(cargo);
            }
            else
            {
                MessageBox.Show("Cargo no Encontrado");
            }
        }
    }
}
