using MySql.Data.MySqlClient;
using System.Data;

namespace bandoDeDados
{
    public class bancoDeDados
    {
        private static MySqlConnection ConexaoAoBanco;

        private static MySqlConnection Conectar()
        {
            ConexaoAoBanco = new MySqlConnection(@"Server=127.0.0.1;Port=5432;Database=ifsp;User Id=postgres;Password=1234;");
            ConexaoAoBanco.Open();
            return ConexaoAoBanco;
        }

        public static void FecharConexao()
        {
            if (ConexaoAoBanco != null)
            {
                ConexaoAoBanco.Close();
                ConexaoAoBanco = null;
            }
        }


        private static MySqlParameterCollection objParametros = new MySqlCommand().Parameters;

        public static void LimparParametros()
        {
            objParametros.Clear();
        }

        public static void AdicionarParametros(string strNomeParametro, object objValor)
        {
            objParametros.Add(new MySqlParameter(strNomeParametro, objValor));
        }

        //Inserir, Alterar e Excluir
        public static object ExecutarManipulacao(CommandType objTipo, string strSql)
        {
            try
            {
                if (ConexaoAoBanco == null)
                    ConexaoAoBanco = Conectar();

                MySqlConnection objConexao = ConexaoAoBanco;

                MySqlCommand objComando = objConexao.CreateCommand();
                objComando.CommandType = objTipo;
                objComando.CommandText = strSql;
                objComando.CommandTimeout = 999999999; //Seconds

                foreach (MySqlParameter objParametro in objParametros)
                    objComando.Parameters.Add(new MySqlParameter(objParametro.ParameterName, objParametro.Value));

                return objComando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar registros do banco de dados
        public static DataTable ExecutaConsultar(CommandType objTipo, string strSql)
        {
            try
            {
                if (ConexaoAoBanco == null)
                    ConexaoAoBanco = Conectar();

                MySqlConnection objConexao = ConexaoAoBanco;
                MySqlCommand objComando = objConexao.CreateCommand();
                objComando.CommandType = objTipo;
                objComando.CommandText = strSql;
                objComando.CommandTimeout = 999999999;

                foreach (MySqlParameter objParametro in objParametros)
                    objComando.Parameters.Add(new MySqlParameter(objParametro.ParameterName, objParametro.Value));

                MySqlDataAdapter objAdaptador = new MySqlDataAdapter(objComando);
                DataTable objTabelaRecebeDados = new DataTable();

                objAdaptador.Fill(objTabelaRecebeDados);

                return objTabelaRecebeDados;
            }
            catch (Exception objErro)
            {
                throw new Exception(objErro.Message);
            }

        }
    }
}