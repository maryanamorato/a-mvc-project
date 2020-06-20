using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using projeto_mvc_b27.DAL;


namespace projeto_mvc_b27.BLL
{
    public class tblClienteBLL
    {
        private DALMVC daoBanco = new DALMVC();

        public Boolean Autenticar(string nome, string cpf, string nomeDaMae)
        {
            string consulta = string.Format($@"select * from tbl_clienteb27 where nome_cliente = '{nome}' and cpf_cliente = '{cpf}' and nome_mae = '{nomeDaMae}'");
            DataTable dt = daoBanco.executarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}