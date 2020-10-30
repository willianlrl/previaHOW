using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//adicionado para utilizar a referência Mysql.Data
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp2
{
    class Locacao
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string stringSql;
        //Essas 5 linhas acima são as variáveis para facilitar durante o processo de utilização do SQL.


        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string dataRetirada;

        public string DataRetirada
        {
            get { return dataRetirada; }
            set { dataRetirada = value; }
        }

        private string dataDevolucao;

        public string DataDevolucao
        {
            get { return dataDevolucao; }
            set { dataDevolucao = value; }
        }

        private string valor;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private string obs;

        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

        private string codigoCarro;

        public string CodigoCarro
        {
            get { return codigoCarro; }
            set { codigoCarro = value; }
        }

        private string modeloCarro;

        public string ModeloCarro
        {
            get { return modeloCarro; }
            set { modeloCarro = value; }
        }

        private string anoCarro;

        public string AnoCarro
        {
            get { return anoCarro; }
            set { anoCarro = value; }
        }

        private string nomeCliente;

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        private string codigoCliente;

        public string CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }





    }
}
