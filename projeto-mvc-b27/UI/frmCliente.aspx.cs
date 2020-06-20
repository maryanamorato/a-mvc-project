﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using projeto_mvc_b27.BLL;
using projeto_mvc_b27.DTO;

namespace projeto_mvc_b27.UI
{
    public partial class frmCliente : System.Web.UI.Page
    {
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Pessoa obj = new Pessoa();

            obj.Nome = txtNomeB27.Text;
            obj.Cpf = txtCpf27.Text;
            obj.NomeMae = txtNomeMaeB27.Text;

            tblClienteBLL bllCliente = new tblClienteBLL();
            if (bllCliente.Autenticar(obj.Nome, obj.Cpf, obj.NomeMae))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
            }
            else
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
            }
        }
    }
}