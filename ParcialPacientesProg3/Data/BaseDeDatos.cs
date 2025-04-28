using Microsoft.Data.SqlClient;
using ParcialPacientesProg3.Models;

namespace ParcialPacientesProg3.Data
{
    public class BaseDeDatos
    {
        private string conexionString = "server=(localdb)\\mssqllocaldb; database=HospitalDB; Trusted_Connection=True;TrustServerCertificate=True";

        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> lista = new List<Paciente>();

            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string query = "SELECT * FROM Pacientes";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Paciente paciente = new Paciente
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        ObraSocial = reader["ObraSocial"].ToString(),
                        Edad = (int)reader["Edad"],
                        Sintomas = reader["Sintomas"].ToString()
                    };

                    lista.Add(paciente);
                }
            }

            return lista;
        }

        public void GuardarPaciente(Paciente paciente)
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                string query = $"INSERT INTO Pacientes (Nombre, ObraSocial, Edad, Sintomas) " +
                               $"VALUES ('{paciente.Nombre}', '{paciente.ObraSocial}', {paciente.Edad}, '{paciente.Sintomas}')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}