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
    public class PlanoContaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe a Descrição!")]
        public string Descricao { get; set; }
        
        public string Tipo { get; set; }
        public int Usuario_Id { get; set; }

        // dar o poder de acessar a sessão do sistema
        public IHttpContextAccessor httpContextAccessorModel { get; set; }

        public PlanoContaModel()
        {

        }

        //Recebe o contexto para acesso às variáveis de sessão
        public PlanoContaModel(IHttpContextAccessor httpContextAccessor)
        {
            httpContextAccessorModel = httpContextAccessor;
        }

        public List<PlanoContaModel> ListaPlanoContaModel()
        {
            List<PlanoContaModel> lista = new List<PlanoContaModel>();
            PlanoContaModel item;

            string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"SELECT ID, DESCRICAO, TIPO, USUARIO_ID FROM PLANO_CONTAS WHERE USUARIO_ID = {id_usuario_logado}";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new PlanoContaModel();
                item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                item.Descricao = dt.Rows[i]["DESCRICAO"].ToString();
                item.Tipo = dt.Rows[i]["TIPO"].ToString();
                item.Usuario_Id = int.Parse(dt.Rows[i]["USUARIO_ID"].ToString());
                lista.Add(item);
            }
            return lista;
        }

        public void Insert()
        {
            string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"INSERT INTO PLANO_CONTAS (DESCRICAO, TIPO, USUARIO_ID) VALUES ('{Descricao}', '{Tipo}', '{id_usuario_logado}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }        

        public void ExcluirPlanoContaModel(int? id)
        {
            new DAL().ExecutarComandoSQL("DELETE FROM PLANO_CONTAS WHERE ID = " + id);
        }

        public PlanoContaModel ListaPlanoContaEspecifica(int? id)
        {
            PlanoContaModel item = new PlanoContaModel();

            string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"SELECT ID, DESCRICAO, TIPO, USUARIO_ID FROM PLANO_CONTAS WHERE USUARIO_ID = {id_usuario_logado} AND Id = {id}";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            item.Id = int.Parse(dt.Rows[0]["ID"].ToString());
            item.Descricao = dt.Rows[0]["DESCRICAO"].ToString();
            item.Tipo = dt.Rows[0]["TIPO"].ToString();
            item.Usuario_Id = int.Parse(dt.Rows[0]["USUARIO_ID"].ToString());

            return item;
        }

        public void Update(PlanoContaModel formulario)
        {
            string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"UPDATE PLANO_CONTAS SET DESCRICAO = '{formulario.Descricao}', TIPO = '{formulario.Tipo}' WHERE ID = '{formulario.Id}' AND USUARIO_ID = '{id_usuario_logado}'";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }

    }
}
