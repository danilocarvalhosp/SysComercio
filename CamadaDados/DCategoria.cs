using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CamadaDados
{
    public class DCategoria
    {
        private int _IdCategoria;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;

        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }
        
        // Construtor Vazio
        public DCategoria()
        {
        }

        // Construtor com Parâmetros
        public DCategoria(int idCategoria, string nome, string descricao, string textoBuscar)
        {
            IdCategoria = idCategoria;
            Nome = nome;
            Descricao = descricao;
            TextoBuscar = textoBuscar;
        }

        // Método Inserir
        public string Inserir(DCategoria Categoria)
        {
            string resp = "";
            SqlConnection SqlCon = new();

            try
            {
                SqlCon.ConnectionString = Conexao.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new ();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCategoria = new ();
                ParIdCategoria.ParameterName = "@idcategoria";
                ParIdCategoria.SqlDbType = SqlDbType.Int;
                ParIdCategoria.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdCategoria);

                SqlParameter ParNome = new ();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Categoria.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParDescricao = new ();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 100;
                ParDescricao.Value = Categoria.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "O registro não foi inserido.";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }                
            }

            return resp;
        }

        public string Editar(DCategoria Categoria)
        {
            string resp = "";
            SqlConnection SqlCon = new ();

            try
            {
                SqlCon.ConnectionString = Conexao.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new ();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCategoria = new ();
                ParIdCategoria.ParameterName = "@idcategoria";
                ParIdCategoria.SqlDbType = SqlDbType.Int;
                ParIdCategoria.Value = Categoria.IdCategoria;
                SqlCmd.Parameters.Add(ParIdCategoria);

                SqlParameter ParNome = new ();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Categoria.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParDescricao = new ();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 100;
                ParDescricao.Value = Categoria.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "O registro não foi editado.";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return resp;
        }

        public string Excluir(DCategoria Categoria)
        {
            string resp = "";
            SqlConnection SqlCon = new ();

            try
            {
                SqlCon.ConnectionString = Conexao.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new ();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spexcluir_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCategoria = new ();
                ParIdCategoria.ParameterName = "@idcategoria";
                ParIdCategoria.SqlDbType = SqlDbType.Int;
                ParIdCategoria.Value = Categoria.IdCategoria;
                SqlCmd.Parameters.Add(ParIdCategoria);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "O registro foi excluído com sucesso." : "O registro não foi excluído.";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return resp;
        }

        public DataTable Mostrar()
        {
            DataTable dtResultado = new ("categorias");
            SqlConnection SqlCon = new ();

            try
            {
                SqlCon.ConnectionString = Conexao.Cnx;
                SqlCommand SqlCmd = new ();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;               
            }

            return dtResultado;
        }

        public DataTable BuscarNome(DCategoria Categoria)
        {
            DataTable dtResultado = new ("categorias");
            SqlConnection SqlCon = new ();

            try
            {
                SqlCon.ConnectionString = Conexao.Cnx;
                SqlCommand SqlCmd = new ();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nome";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new ();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Categoria.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new (SqlCmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }

            return dtResultado;
        }
    }
}
