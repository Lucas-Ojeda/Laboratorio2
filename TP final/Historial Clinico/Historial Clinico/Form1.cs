using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Historial_Clinico.Logica;
using Historial_Clinico.Modelo;


namespace Historial_Clinico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            Paciente objeto = new Paciente() { 
                Nombre=textNombre.Text,
                Apellido=textApellido.Text,
                FechaNacimiento=textNacimiento.Text,
                Genero=textGenero.Text,
                Direccion=textDireccion.Text,
                Telefono=textTelefono.Text,            
            };

            bool respuesta=PacienteLogico.Instancia.Guardar(objeto);
            if (respuesta) {
                limpiar();
                mostrar_pacientes();
            }

        }
        public void mostrar_pacientes() {
            DGVPacientes.DataSource = null;
            DGVPacientes.DataSource= PacienteLogico.Instancia.Listar();
        
        }
        public void limpiar() {
            textApellido.Text = "";
            textNombre.Text = "";
            textDireccion.Text = "";
            textGenero.Text = "";
            textNacimiento.Text = "";
            textTelefono.Text = "";        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar_pacientes();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            Paciente objeto = new Paciente()
            {
                Id = int.Parse(textID.Text),
                Nombre = textNombre.Text,
                Apellido = textApellido.Text,
                FechaNacimiento = textNacimiento.Text,
                Genero = textGenero.Text,
                Direccion = textDireccion.Text,
                Telefono = textTelefono.Text,
            };

            bool respuesta = PacienteLogico.Instancia.Editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_pacientes();
            }
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            Paciente objeto = new Paciente()
            {
                Id = int.Parse(textID.Text),
               
            };

            bool respuesta = PacienteLogico.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_pacientes();
            }
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buTurnos_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            Form2 form2 = new Form2(id);
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
