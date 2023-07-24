using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Historial_Clinico.Modelo;
using System.Data.SQLite;
using Newtonsoft.Json;

namespace Historial_Clinico.Logica
{
    public class PacienteLogico
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static PacienteLogico _instancia = null;
        public PacienteLogico() { }
        public static PacienteLogico Instancia {
            get { 
                if (_instancia == null)
                {
                    _instancia= new PacienteLogico();

                }
                return _instancia;
            }
        
        }
        public bool Guardar(Paciente obj) {
            bool respuesta=true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena)) {
                conexion.Open();
                string query = "insert into pacientes(Nombre,Apellido,FechaNacimiento,Genero,Direccion,Telefono)" +
                    "values(@nombre,@apellido,@fechaNacimiento,@genero,@direccion,@telefono)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellido", obj.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("@fechaNacimiento", obj.FechaNacimiento));
                cmd.Parameters.Add(new SQLiteParameter("@genero", obj.Genero));
                cmd.Parameters.Add(new SQLiteParameter("@direccion", obj.Direccion));
                cmd.Parameters.Add(new SQLiteParameter("@telefono", obj.Telefono));
                cmd.CommandType=System.Data.CommandType.Text;
                if(cmd.ExecuteNonQuery()<1){
                    respuesta=false;
                }
            }
                return respuesta;
        }


        public List<Paciente> Listar() { 
            List<Paciente> pacientes = new List<Paciente>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select ID,Nombre,Apellido,FechaNacimiento,Genero,Direccion,Telefono from pacientes";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);;
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader()) {
                    while (dr.Read()) {
                        pacientes.Add(new Paciente() { 
                            Id= int.Parse(dr["Id"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            FechaNacimiento = dr["FechaNacimiento"].ToString(),
                            Genero = dr["Genero"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                        });
                    
                    }
                
                }
               
            }
            

            return pacientes;
        }

        public Paciente MostrarPacienteUnico(int id) {
            Paciente paciente = new Paciente();
            List<Paciente> pacientes = new List<Paciente>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select ID,Nombre,Apellido,FechaNacimiento,Genero,Direccion,Telefono from pacientes";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion); ;
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        pacientes.Add(new Paciente()
                        {
                            Id = int.Parse(dr["Id"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            FechaNacimiento = dr["FechaNacimiento"].ToString(),
                            Genero = dr["Genero"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                        });

                    }

                }

            }
            foreach (Paciente paciente1 in pacientes)
            {
                if(paciente1.Id==id){ 
                    paciente.Id = paciente1.Id;
                    paciente.Nombre = paciente1.Nombre;
                    paciente.Apellido = paciente1.Apellido;
                    paciente.FechaNacimiento=paciente1.FechaNacimiento;
                    paciente.Genero = paciente1.Genero;
                    paciente.Direccion=paciente1.Direccion;
                    paciente.Telefono=paciente1.Telefono;
                    paciente.Turno=paciente1.Turno;
                    paciente.Historial=paciente1.Historial;
                }
            
            }
            return paciente;
        }

        public bool Editar(Paciente obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Update pacientes set Nombre = @nombre, Apellido = @apellido, FechaNacimiento = @fechaNacimiento," +
                    " Genero = @genero,Direccion =@direccion ,Telefono = @telefono where Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@Id", obj.Id));
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellido", obj.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("@fechaNacimiento", obj.FechaNacimiento));
                cmd.Parameters.Add(new SQLiteParameter("@genero", obj.Genero));
                cmd.Parameters.Add(new SQLiteParameter("@direccion", obj.Direccion));
                cmd.Parameters.Add(new SQLiteParameter("@telefono", obj.Telefono));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool EditarTurno(Paciente obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Update pacientes set Turno= @turno where Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@Id", obj.Id));                
                cmd.Parameters.Add(new SQLiteParameter("@turno", obj.Turno));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool Eliminar(Paciente obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "delete from pacientes where Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@Id", obj.Id));                
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        //Trabajar con la lista

        public bool SerializarYguardarHistorial(Paciente obj)
        {
            bool respuesta = true;
            string Serializada = JsonConvert.SerializeObject(obj.Historial);
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Update pacientes set Historial = @historial where Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@Id", obj.Id));
                cmd.Parameters.Add(new SQLiteParameter("@historial", Serializada));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public List<string> RecuperarHistorial(int id)
        {
            List<string> listaRecuperada = new List<string>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select Historial from pacientes where Id = @Id ";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion)) {

                    cmd.Parameters.Add(new SQLiteParameter("@Id", id));

                    object resultado = cmd.ExecuteScalar();
                    try { string miString = (string)resultado;
                        string[] elementos = miString.Split('¬');
                        foreach (string elemento in elementos)
                        {
                            listaRecuperada.Add(elemento);

                        }
                    } catch { }
                    
                    

                    

                }

            }


            return listaRecuperada;
        }


    }
}
