using GestaoFinanceira.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFinanceira.Models
{
    public class ContaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public int IdUsuario { get; set; }
        IHttpContextAccessor httpContextAccessorModel;

        public ContaModel()
        {

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

            string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"SELECT ID, NOME, SALDO, USUARIO_ID FROM CONTA WHERE USUARIO_ID = {id_usuario_logado}";
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
    }
}
