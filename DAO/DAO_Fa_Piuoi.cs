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
    public class DAO_Fa_Piuoi
    {
        public Fa_Piuoi GetFaPiuoi(int emp_codi,int arb_cest,int piu_anop)
        {
            string sql;
            List<SQLParams> sQLParams = new List<SQLParams>();
            sQLParams.Add(new SQLParams("EMP_CODI", emp_codi));
            sQLParams.Add(new SQLParams("ARB_CEST", arb_cest));
            sQLParams.Add(new SQLParams("PIU_ANOP", piu_anop));
            sql = DBHelper.SelectQueryString<Fa_Piuoi>(sQLParams);           
            return new DbConnection().Get<Fa_Piuoi>(sql.ToString(), sQLParams);
        }
    }
}
