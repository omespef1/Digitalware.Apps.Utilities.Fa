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
   public class DAO_Fa_Parfe
    {
        public static Fa_Parfe GetFaParfe(int emp_codi)
        {
            string sql;
            List<SQLParams> sQLParams = new List<SQLParams>();
            sQLParams.Add(new SQLParams("EMP_CODI", emp_codi));
            sql = DBHelper.SelectQueryString<Fa_Parfe>(sQLParams);
            return new DbConnection().Get<Fa_Parfe>(sql.ToString(),sQLParams);
        }
    }
}
