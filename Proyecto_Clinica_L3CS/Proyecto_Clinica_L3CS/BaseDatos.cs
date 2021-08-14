using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Clinica_L3CS
{
    public class BaseDatos
    {
        readonly string cadena = "Data Source=AFICOT\\RUBENDS; Initial Catalog=CLINICA_UMBRELLA; Integrated Security=True";

        public bool ValidarUsuario(string codigo, string clave)
        {
            bool EsUsuarioValido = false;

            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT 1 FROM USUARIOS ");
                consultaSQL.Append(" WHERE CODIGO = @codigo AND CLAVE = @clave AND ESTAACTIVO = 1; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@clave", SqlDbType.NVarChar, 30).Value = clave;

                        EsUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception)
            {

            }

            return EsUsuarioValido;


        }

        public DataTable CargarEspecialidades()
        {
            DataTable tabla = new DataTable();

            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT * FROM ESPECIALIDAD ");
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {

            }

            return tabla;


        }

        public bool AgregarDoctor(string codigo, string nombre, string identidad, int telefono, int idEspecialidad)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" INSERT INTO DOCTORES ");
                consultaSQL.Append(" VALUES (@codigo, @nombre, @identidad, @telefono, @idEspecialidad); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@codigo", SqlDbType.NVarChar, 50).Value = codigo;
                        comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@identidad", SqlDbType.NVarChar, 50).Value = identidad;
                        comando.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
                        comando.Parameters.Add("@idEspecialidad", SqlDbType.Int).Value = idEspecialidad;
                        comando.ExecuteNonQuery();
                        return true;

                    }
                }
            }

            catch (Exception)
            {

                return false;
            }
        }

        public DataTable ListarDoctores()
        {
            DataTable tabla = new DataTable();

            try
            {
                StringBuilder consultaSQL = new StringBuilder();

                consultaSQL.Append(" SELECT P.CODIGO,  P.NOMBRE, P.IDENTIDAD, P.TELEFONO, C.ESPECIALIDAD  FROM DOCTORES P ");
                consultaSQL.Append(" INNER JOIN ESPECIALIDAD C ON C.ID = P.IDESPECIALIDAD ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {

            }

            return tabla;
        }

        public bool EditarDoctor(string codigo, string nombre, string identidad, int telefono, int idEspecialidad)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" UPDATE DOCTORES ");
                consultaSQL.Append(" SET NOMBRE = @nombre, IDENTIDAD = @identidad, TELEFONO = @telefono, IDESPECIALIDAD = @idEspecialidad ");
                consultaSQL.Append(" WHERE CODIGO = @codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@codigo", SqlDbType.NVarChar, 50).Value = codigo;
                        comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@identidad", SqlDbType.NVarChar, 50).Value = identidad;
                        comando.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
                        comando.Parameters.Add("@idEspecialidad", SqlDbType.Int).Value = idEspecialidad;
                        comando.ExecuteNonQuery();
                        return true;

                    }
                }
            }

            catch (Exception)
            {

                return false;
            }

        }

        public bool EliminarDoctor(string codigo)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" DELETE FROM DOCTORES ");
                consultaSQL.Append(" WHERE CODIGO = @codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@codigo", SqlDbType.NVarChar, 50).Value = codigo;
                        comando.ExecuteNonQuery();
                        return true;

                    }
                }
            }

            catch (Exception)
            {

                return false;
            }
        }

        public bool AgregarUsuario(string codigo, string nombre, string contraseña, bool activo)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" INSERT INTO USUARIOS ");
                consultaSQL.Append(" VALUES (@codigo, @nombre, @clave, @activo); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@clave", SqlDbType.NVarChar, 30).Value = contraseña;
                        comando.Parameters.Add("@activo", SqlDbType.Bit).Value = activo;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            } 
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarUsuario(string codigo, string nombre, string contraseña, bool activo)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" UPDATE USUARIOS ");
                consultaSQL.Append(" SET NOMBRE = @nombre, CLAVE = @clave, ESTAACTIVO = @activo ");
                consultaSQL.Append(" WHERE CODIGO = @codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@clave", SqlDbType.NVarChar, 30).Value = contraseña;
                        comando.Parameters.Add("@activo", SqlDbType.Bit).Value = activo;
                        comando.ExecuteNonQuery();
                        return true;

                    }
                }
            }

            catch (Exception)
            {

                return false;
            }
        }

        public DataTable ListaUsuarios()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();

                consultaSQL.Append(" SELECT CODIGO, NOMBRE, ESTAACTIVO FROM USUARIOS");
 
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {

            }

            return tabla;

        }

        public bool EliminarUsuario(string codigo)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" DELETE FROM USUARIOS ");
                consultaSQL.Append(" WHERE CODIGO = @codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@codigo", SqlDbType.NVarChar, 50).Value = codigo;
                        comando.ExecuteNonQuery();
                        return true;

                    }
                }
            }

            catch (Exception)
            {

                return false;
            }
        }

        public DataTable CargarTiposSangre()
        {
            DataTable tabla = new DataTable();

            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT * FROM SANGRE ");
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {

            }

            return tabla;


        }

        public DataTable ListarPacientes()
        {
            DataTable tabla = new DataTable();

            try
            {
                StringBuilder consultaSQL = new StringBuilder();

                consultaSQL.Append(" SELECT P.IDENTIDAD, P.NOMBRE, P.TELEFONO, P.DIRECCION, P.EDAD, C.TIPO_SANGRE  FROM PACIENTES P ");
                consultaSQL.Append(" INNER JOIN SANGRE C ON C.ID = P.IDTIPO_SANGRE ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {

            }

            return tabla;
        }

        public bool AgregarPaciente(string identidad, string nombre, int telefono, string direccion, int edad, int tiposangre)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" INSERT INTO PACIENTES ");
                consultaSQL.Append(" VALUES (@identidad, @nombre, @telefono, @direccion, @edad, @tiposangre); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@identidad", SqlDbType.NVarChar, 20).Value = identidad;
                        comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
                        comando.Parameters.Add("@direccion", SqlDbType.NVarChar, 50).Value = direccion;
                        comando.Parameters.Add("@edad", SqlDbType.Int).Value = edad;
                        comando.Parameters.Add("@tiposangre", SqlDbType.Int).Value = tiposangre;
                        comando.ExecuteNonQuery();
                        return true;

                    }
                }
            }

            catch (Exception)
            {

                return false;
            }
        }

        public bool EditarPaciente(string identidad, string nombre, int telefono, string direccion, int edad, int tiposangre)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" UPDATE PACIENTES ");
                consultaSQL.Append(" SET IDENTIDAD = @identidad, NOMBRE = @nombre, TELEFONO = @telefono, DIRECCION = @direccion, EDAD = @edad, IDTIPO_SANGRE = @tiposangre ");
                consultaSQL.Append(" WHERE ID = @id; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@identidad", SqlDbType.NVarChar, 20).Value = identidad;
                        comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
                        comando.Parameters.Add("@direccion", SqlDbType.NVarChar, 50).Value = direccion;
                        comando.Parameters.Add("@edad", SqlDbType.Int).Value = edad;
                        comando.Parameters.Add("@tiposangre", SqlDbType.Int).Value = tiposangre;
                        comando.ExecuteNonQuery();
                        return true;

                    }
                }
            }

            catch (Exception)
            {

                return false;
            }
        }

        public bool EliminarPaciente(string identidad)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" DELETE FROM PACIENTES ");
                consultaSQL.Append(" WHERE IDENTIDAD = @identidad; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@identidad", SqlDbType.NVarChar, 20).Value = identidad;
                        comando.ExecuteNonQuery();
                        return true;

                    }
                }
            }

            catch (Exception)
            {

                return false;
            }
        }

        public string GetNombreUsuario(string CodigodeUsuario)
        {
            string nombre = string.Empty;
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT NOMBRE FROM USUARIOS");
                consultaSQL.Append(" WHERE CODIGO = @codigo ; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@codigo", SqlDbType.NVarChar, 30).Value = CodigodeUsuario;
                        SqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            nombre = dr["NOMBRE"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return nombre;
        }

        public List<KeyValuePair<int, string>> GetPacienteParaFactura(string identidad)
        {
            List<KeyValuePair<int, string>> miLista = new List<KeyValuePair<int, string>>();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();

                consultaSQL.Append(" SELECT ID, NOMBRE FROM PACIENTES ");
                consultaSQL.Append(" WHERE IDENTIDAD = @identidad ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@identidad", SqlDbType.NVarChar, 20).Value = identidad;
                        SqlDataReader dr = comando.ExecuteReader(); 

                        if (dr.Read())
                        {
                            miLista.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr["ID"].ToString()), dr["NOMBRE"].ToString()));
                        }
                    }
                }
            }
            catch (Exception)
            {

            }

            return miLista;
        }


    } 
}
