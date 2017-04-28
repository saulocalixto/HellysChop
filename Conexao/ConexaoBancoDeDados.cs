using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace HelloWorld.Conexao
{
    public class ConexaoBancoDeDados
    {
        private String _stringSQL;
        /// <summary>
        /// Construtor que fará a abertura da conexão, juntamente com a execução da string SQL passada como parâmetro
        /// </summary>
        /// <param name="sql">Comando SQL</param>
        public ConexaoBancoDeDados(String sql) 
        {
            _stringSQL = sql;
        }
        /// <summary>
        /// Abre uma conexão com o banco de dados e executa uma string sql que foi passada no construtor da classe
        /// ConexaoBancoDeDados
        /// </summary>
        public void ObtenhaConexaoExecuteComando() 
        { 
            using (var Conexao = new SqlConnection("Persist Security Info=True; User ID=sa; Password=sa; Integrated Security=true;Initial Catalog=HellysChop;server=localhost\sqlexpress")) 
            {
                Conexao.Open();
                var Comando = new SqlCommand(this._stringSQL, Conexao);
            }
        }
    }
}