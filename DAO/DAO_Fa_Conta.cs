using Digitalware.Apps.Utilities.Fa.TO;
using SevenFramework.DataBase;
using SevenFramework.DataBase.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalware.Apps.Utilities.Fa.DAO
{
   public class  DAO_Fa_Conta
    {

        /// <summary>
        /// Consulta a la tabla FA_CONTA;
        /// </summary>
        /// <param name="sQLParams">Lista de parámetros para incluir en la clausula WHERE</param>
        /// <returns>Retorna las propiedades descritas en el modelo</returns>
        public static List<Fa_Conta> GetFaConta(List<SQLParams> sQLParams)
        {
            string sql;
            sql = DBHelper.SelectQueryString<Fa_Conta>(sQLParams);
            return new DbConnection().GetList<Fa_Conta>(sql, sQLParams);
        }
       
    }
}
