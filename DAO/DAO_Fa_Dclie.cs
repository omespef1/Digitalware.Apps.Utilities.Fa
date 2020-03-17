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
  public  class DAO_Fa_Dclie
    {
        public static List<Fa_Dclie> GetFaDclie(List<SQLParams> sqlParams)
        {
            string sql;
            sql = DBHelper.SelectQueryString<Fa_Dclie>(sqlParams);
            return new DbConnection().GetList<Fa_Dclie>(sql, sqlParams);
        }
       
    }
}
