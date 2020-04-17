using GestaoFinanceira.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFinanceira.Models
{
    public class ContaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o Nome da Conta")]
        public string Nome { get; set; }
        [Required (ErrorMessage = "Informe o Saldo da Conta")]
        public double Saldo { get; set; }
        public int IdUsuario { get; set; }
        public IHttpContextAccessor httpContextAccessorModel { get; set; }

        public ContaModel()
        {

        }

        private string IdUsuarioLogado()
        {
            return httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
        }

        //Recebe o contexto para acesso às variáveis de sessão
        public ContaModel(IHttpContextAccessor httpContextAccessor)
        {
            httpContextAccessorModel = httpContextAccessor;
        }

        public List<ContaModel> ListaContaModel()
        {
            List<ContaModel> lista = new List<ContaModel>();
            ContaModel item;

            //string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"SELECT ID, NOME, SALDO, USUARIO_ID FROM CONTA WHERE USUARIO_ID = {IdUsuarioLogado()}";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ContaModel();
                item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                item.Nome = dt.Rows[i]["NOME"].ToString();
                item.Saldo = double.Parse(dt.Rows[i]["SALDO"].ToString());
                item.IdUsuario = int.Parse(dt.Rows[i]["USUARIO_ID"].ToString());
                lista.Add(item);
            }
            return lista;
        }

        public ContaModel ListaContaEspecifica(int? idConta)
        {
            ContaModel lista = new ContaModel();

            //string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"SELECT ID, NOME, SALDO, USUARIO_ID FROM CONTA WHERE USUARIO_ID = {IdUsuarioLogado()} AND ID = {idConta}";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            lista.Id = int.Parse(dt.Rows[0]["ID"].ToString());
            lista.Nome = dt.Rows[0]["NOME"].ToString();
            lista.Saldo = double.Parse(dt.Rows[0]["SALDO"].ToString());
            lista.IdUsuario = int.Parse(dt.Rows[0]["USUARIO_ID"].ToString());

            return lista;
        }
       

            public void Insert()
        {
            //string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"INSERT INTO CONTA(NOME, SALDO, USUARIO_ID) VALUES ('{Nome}', '{Saldo}', '{IdUsuarioLogado()}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }

        public void Update(ContaModel formulario)
        {
            //string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"UPDATE CONTA SET NOME = '{formulario.Nome}', SALDO = '{formulario.Saldo}' WHERE ID = '{formulario.Id}' AND USUARIO_ID = '{IdUsuarioLogado()}'";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }

        public void ExcluirContaModel(int idConta)
        {
            new DAL().ExecutarComandoSQL("DELETE FROM CONTA WHERE ID = " + idConta);
        }        

    }
}
