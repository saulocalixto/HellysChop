using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace HelloWorld.Conexao
{
    public class Conexao
    {
        private String _stringSQL;
        /// <summary>
        /// Construtor que fará a abertura da conexão, juntamente com a execução da string SQL passada como parâmetro
        /// </summary>
        /// <param name="sql">Comando SQL</param>
        public Conexao(String sql) 
        {
            _stringSQL = sql;
        }

        public void ObtenhaConexaoExecuteComando() 
        { 
            using (var Conexao = new SqlConnection("HellysChopConnectionString")) 
            {
                Conexao.Open();
                var Comando = new SqlCommand(this._stringSQL, Conexao);
            }
        }
    }
}