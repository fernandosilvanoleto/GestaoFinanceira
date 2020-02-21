using GestaoFinanceira.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFinanceira.Models
{
    public class UsuarioModel
    {        
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o Nome!")] // serve para selecionar o campo de nome como obrigatório e além de especificar a mensagem
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha a Senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Preencha a Data de Nascimento!")]
        public String DataNascimento { get; set; }


        public bool ValidarLogin()
        {
            string sql = $"SELECT ID, NOME, DATA_NASCIMENTO FROM USUARIO WHERE EMAIL = '{Email}' AND  SENHA ='{Senha}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Id = int.Parse(dt.Rows[0]["ID"].ToString());                    
                    Nome = dt.Rows[0]["Nome"].ToString();
                    DataNascimento = dt.Rows[0]["DATA_NASCIMENTO"].ToString();
                    return true;
                }
            }
            return false;
        }

        public void RegistrarUsuarioModel()
        {
            string dataNascimento = DateTime.Parse(DataNascimento).ToString("yyyy/MM/dd");
            string sql = $"INSERT INTO USUARIO (NOME, EMAIL, SENHA, DATA_NASCIMENTO) VALUES ('{Nome}', '{Email}', '{Senha}', '{dataNascimento}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }

    }
}
