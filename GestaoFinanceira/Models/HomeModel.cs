using GestaoFinanceira.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFinanceira.Models
{
    public class HomeModel
    {
        public string LerNomeUsuarioModel()
        {
            DAL objDALModel = new DAL();
            DataTable dtModel =  objDALModel.RetDataTable("select * from usuario");
            if (dtModel != null)
            {
                if (dtModel.Rows.Count > 0)
                {
                    return dtModel.Rows[1]["Nome"].ToString();
                }
            }
            return "Nome não encontrado";
        }
    }
}
