using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.AspNetCore.Http;
using GestaoFinanceira.Util;

namespace GestaoFinanceira.Models
{
    public class TransacaoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe a Data!")]
        public string Data { get; set; }

        public string DataFinal { get; set; } //utilizando para filtro

        [Required(ErrorMessage = "Informe o Tipo!")]
        public string Tipo { get; set; }
        public double Valor { get; set; }

        [Required(ErrorMessage = "Informe a descricao!")]
        public string Descricao { get; set; }
        public int Conta_Id { get; set; }
        public string NomeConta { get; set; }
        public int PlanoConta_Id { get; set; }
        public string PlanoConta { get; set; }
        public int Usuario_Id { get; set; }
        public string NomeUsuario { get; set; }

        // dar o poder de acessar a sessão do sistema
        public IHttpContextAccessor httpContextAccessorModel { get; set; }

        public TransacaoModel()
        {

        }

        private string IdUsuarioLogado()
        {
            return httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
        }

        //Recebe o contexto para acesso às variáveis de sessão
        public TransacaoModel(IHttpContextAccessor httpContextAccessor)
        {
            httpContextAccessorModel = httpContextAccessor;
        }

        public List<TransacaoModel> ListaTransacaoModel()
        {
            List<TransacaoModel> lista = new List<TransacaoModel>();
            TransacaoModel item;

            //utilizado pelo view Extrato
            string filtro = "";
            if (Data != null && DataFinal != null)
            {
                filtro += $" and t.DATA >= '{DateTime.Parse(Data).ToString("yyyy/MM/dd")}' and t.DATA <= '{DateTime.Parse(DataFinal).ToString("yyyy/MM/dd")}'";
            }

            if (Tipo != null)
            {
                if (Tipo != "A")
                {
                    filtro += $" and t.TIPO = '{Tipo}'";
                }
            }

            if (Conta_Id != 0)
            {
                filtro += $" and t.Conta_Id = '{Conta_Id}'";
                
            }

            //string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = "SELECT t.ID, t.DATA, t.TIPO, t.VALOR, t.DESCRICAO AS Historico, t.CONTA_ID, c.Nome, "+
                            " t.PLANO_CONTAS_ID, plano.Descricao AS PlanoConta, t.USUARIO_ID, usuario.Nome as NomeUsuario" +
                            " FROM TRANSACAO as t" +
                            " inner join conta as c on t.CONTA_ID = c.id" +
                            " inner join plano_contas as plano on t.PLANO_CONTAS_ID = plano.Id" +
                            " inner join usuario as usuario on t.USUARIO_ID = usuario.Id" +
                            $" WHERE t.USUARIO_ID = { IdUsuarioLogado() } {filtro} ORDER BY t.DATA;";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new TransacaoModel();
                item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                item.Data = DateTime.Parse(dt.Rows[i]["DATA"].ToString()).ToString("dd/MM/yyyy") ;
                item.Tipo = dt.Rows[i]["TIPO"].ToString();
                item.Valor = double.Parse(dt.Rows[i]["VALOR"].ToString());
                item.Descricao = dt.Rows[i]["Historico"].ToString();
                item.Conta_Id = int.Parse(dt.Rows[i]["CONTA_ID"].ToString());
                item.NomeConta = dt.Rows[i]["Nome"].ToString();
                item.PlanoConta_Id = int.Parse(dt.Rows[i]["PLANO_CONTAS_ID"].ToString());
                item.PlanoConta = dt.Rows[i]["PlanoConta"].ToString();
                item.Usuario_Id = int.Parse(dt.Rows[i]["USUARIO_ID"].ToString());
                item.NomeUsuario = dt.Rows[i]["NomeUsuario"].ToString();

                lista.Add(item);
            }
            return lista;
        }

        public TransacaoModel ListaTransacaoEspecificaModel(int? id)
        {
            TransacaoModel transacao = new TransacaoModel();

            //string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = "SELECT t.ID, t.DATA, t.TIPO, t.VALOR, t.DESCRICAO AS Historico, t.CONTA_ID, c.Nome, " +
                            " t.PLANO_CONTAS_ID, plano.Descricao AS PlanoConta, t.USUARIO_ID, usuario.Nome as NomeUsuario" +
                            " FROM TRANSACAO as t" +
                            " inner join conta as c on t.CONTA_ID = c.id" +
                            " inner join plano_contas as plano on t.PLANO_CONTAS_ID = plano.Id" +
                            " inner join usuario as usuario on t.USUARIO_ID = usuario.Id" +
                            $" WHERE t.USUARIO_ID = { IdUsuarioLogado() } AND t.ID = {id};";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            transacao.Id = int.Parse(dt.Rows[0]["ID"].ToString());
            transacao.Data = DateTime.Parse(dt.Rows[0]["DATA"].ToString()).ToString("dd/MM/yyyy");
            transacao.Tipo = dt.Rows[0]["TIPO"].ToString();
            transacao.Valor = double.Parse(dt.Rows[0]["VALOR"].ToString());
            transacao.Descricao = dt.Rows[0]["Historico"].ToString();
            transacao.Conta_Id = int.Parse(dt.Rows[0]["CONTA_ID"].ToString());
            transacao.NomeConta = dt.Rows[0]["Nome"].ToString();
            transacao.PlanoConta_Id = int.Parse(dt.Rows[0]["PLANO_CONTAS_ID"].ToString());
            transacao.PlanoConta = dt.Rows[0]["PlanoConta"].ToString();
            transacao.Usuario_Id = int.Parse(dt.Rows[0]["USUARIO_ID"].ToString());
            transacao.NomeUsuario = dt.Rows[0]["NomeUsuario"].ToString();

            return transacao;
        }

        public void Inserir()
        {
            //string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"INSERT INTO TRANSACAO (DATA, TIPO, VALOR, DESCRICAO, CONTA_ID, PLANO_CONTAS_ID, USUARIO_ID) VALUES ('{DateTime.Parse(Data).ToString("yyyy/MM/dd")}', '{Tipo}', '{Valor}', '{Descricao}', '{Conta_Id}', '{PlanoConta_Id}', '{IdUsuarioLogado()}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }

        public void Update(TransacaoModel formulario)
        {
            //string id_usuario_logado = httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"UPDATE TRANSACAO SET DATA = '{DateTime.Parse(formulario.Data).ToString("yyyy/MM/dd")}', TIPO = '{formulario.Tipo}', VALOR = '{formulario.Valor}', DESCRICAO = '{formulario.Descricao}', CONTA_ID = '{formulario.Conta_Id}', TIPO = '{formulario.Tipo}', PLANO_CONTAS_ID = '{formulario.PlanoConta_Id}' WHERE ID = '{formulario.Id}' AND USUARIO_ID = '{IdUsuarioLogado()}'";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }

        public void Excluir(int id)
        {
            new DAL().ExecutarComandoSQL("DELETE FROM TRANSACAO WHERE ID = " + id);
        }         

    }

    public class Dashboard
    {
        public double Total { get; set; }
        public string PlanoConta { get; set; }

        public IHttpContextAccessor httpContextAccessorModel { get; set; }

        public Dashboard()
        {

        }        

        //Recebe o contexto para acesso às variáveis de sessão
        public Dashboard(IHttpContextAccessor httpContextAccessor)
        {
            httpContextAccessorModel = httpContextAccessor;
        }

        private string IdUsuarioLogado()
        {
            return httpContextAccessorModel.HttpContext.Session.GetString("IdUsuarioLogado");
        }

        public List<Dashboard> RetornarDadosGeral()
        {
            List<Dashboard> lista = new List<Dashboard>();
            Dashboard item;

            string sql = "SELECT pc.Descricao, SUM(t.valor) as Total FROM financeiro.transacao t " +
                         "inner join financeiro.plano_contas pc on t.Plano_Contas_Id = pc.Id " +
                         $"where t.Tipo = 'D' and t.Usuario_Id = '{IdUsuarioLogado()}' " +
                         "group by pc.Descricao";

            DAL objDAL = new DAL();
            DataTable dt = new DataTable();

            dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new Dashboard();
                item.Total = double.Parse(dt.Rows[i]["Total"].ToString());
                item.PlanoConta = dt.Rows[i]["Descricao"].ToString();
                lista.Add(item);
            }
            return lista;
        }
    }
}
