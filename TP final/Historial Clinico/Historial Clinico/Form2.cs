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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Historial_Clinico
{
    public partial class Form2 : Form
    {
        int id;
        public Form2(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mostrarPaciente();
            mostrarLista();

        }
        public void mostrarPaciente() {
            Paciente paciente = PacienteLogico.Instancia.MostrarPacienteUnico(id);
            labApellido1.Text = paciente.Apellido;
            labNombre1.Text = paciente.Nombre;
            labNacimiento1.Text = paciente.FechaNacimiento;
            labGenero1.Text = paciente.Genero;
            labDireccion1.Text= paciente.Direccion;
            labTelefono1.Text= paciente.Telefono;
            labTurno.Text= paciente.Turno;
        }
        public void limpiar() {
            textFecha.Text = "";
            textHora.Text = "";
            textMotivo.Text = "";
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente objeto = new Paciente()
            {
                Id = id,
                Turno = "Fecha: " + textFecha.Text + ", Hora: " + textHora.Text + ", Motivo: " + textMotivo.Text,
                
            };

            bool respuesta = PacienteLogico.Instancia.EditarTurno(objeto);
            if (respuesta)
            {
                limpiar();
                labTurno.Text= objeto.Turno;
                
            }
        }
        public void mostrarLista() {
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = PacienteLogico.Instancia.RecuperarHistorial(id);

        }

        private void btAgregarHistorial_Click(object sender, EventArgs e)
        {
            string historial= "¬" +"Fecha: "+textFecha.Text+" Obvservacion: "+textHistorial.Text;
            
            Paciente objeto = new Paciente()
            {
                Id = id,     
                
            };

            bool respuesta = PacienteLogico.Instancia.SerializarYguardarHistorial(objeto);
            if (respuesta)
            {
                
                mostrarLista();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paciente objeto = new Paciente()
            {
                Id = id,
                Turno = "Sin turno actualmente",

            };

            bool respuesta = PacienteLogico.Instancia.EditarTurno(objeto);
            if (respuesta)
            {
                limpiar();
                labTurno.Text = objeto.Turno;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
