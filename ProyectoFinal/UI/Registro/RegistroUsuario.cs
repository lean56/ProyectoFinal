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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            UserradioButton.Checked = false;
            AdminradioButton.Checked = false;
            UsuarioTextBox.Text = string.Empty;
            ClaveTextBox.Text = string.Empty;
            FechaIngresodateTimePicker.Value = DateTime.Now;
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = Convert.ToInt32(IdnumericUpDown.Value);
            usuario.Nombre = NombreTextBox.Text;
            usuario.Email = EmailTextBox.Text;
            if (UserradioButton.Checked == true)
                usuario.NivelUsuario = "Usuario";
            else
                usuario.NivelUsuario = "Administrador";
            usuario.usuario = UsuarioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.FechaIngreso = FechaIngresodateTimePicker.Value;

            return usuario;
        }

        private void LlenaCampo(Usuarios usuario)
        {
            IdnumericUpDown.Value = usuario.UsuarioId;
            NombreTextBox.Text = usuario.Nombre;
            EmailTextBox.Text = usuario.Email;
            if (UserradioButton.Checked == true)
                usuario.NivelUsuario = "Usuario";
            else
                usuario.NivelUsuario = "Administrador";
            UsuarioTextBox.Text = usuario.usuario;
            ClaveTextBox.Text = usuario.Clave;
            FechaIngresodateTimePicker.Value = usuario.FechaIngreso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuario = UsuarioBLL.Buscar((int)IdnumericUpDown.Value);

            return (usuario != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (IdnumericUpDown.Text == string.Empty)
            {
                MyErrorProvider.SetError(IdnumericUpDown, "El campo Id no puede estar vacio");
                IdnumericUpDown.Focus();
                paso = false;
            }

            if (NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo Nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyErrorProvider.SetError(EmailTextBox, "El campo Email no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }


            if (UserradioButton.Checked == false && AdminradioButton.Checked == false)
            {
                MyErrorProvider.SetError(NivelUsergroupBox, "Debe elegir un tipo de usuario");
                NivelUsergroupBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo Cedula no puede estar vacio");
                UsuarioTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                MyErrorProvider.SetError(ClaveTextBox, "El campo Clave no puede estar vacio");
                ClaveTextBox.Focus();
                paso = false;
            }

            return paso;
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;

            if (!Validar())
                return;

            usuario = LlenarClase();
            Limpiar();

            if (IdnumericUpDown.Value == 0)
                paso = UsuarioBLL.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuarioBLL.Modificar(usuario);
            }

            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
                MessageBox.Show("Error al Guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();

            if (UsuarioBLL.Eliminar(id))
            {
                MessageBox.Show("Elimino el ID: " + id + "", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
                MyErrorProvider.SetError(IdnumericUpDown, "Id no Existe");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            usuario = UsuarioBLL.Buscar(id);

            if(usuario !=null)
            {
                MessageBox.Show("Usuario Encontrado");
                LlenaCampo(usuario);
            }
            else
            {
                MessageBox.Show("Usuario no Encontrado");
            }
        }
    }
}
