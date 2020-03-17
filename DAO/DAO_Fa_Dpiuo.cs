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
   public class DAO_Fa_Dpiuo
    {
        public Fa_Dpiuo GetFaDpiuo(int emp_codi, int piu_anop,int arb_cest,int dpi_cimp,string dpi_prac,string dpi_tpag,int ite_acti)
        {
            string sql;
            List<SQLParams> sQLParams = new List<SQLParams>();
            sQLParams.Add(new SQLParams("EMP_CODI", emp_codi));
            sQLParams.Add(new SQLParams("PIU_ANOP", piu_anop));
            sQLParams.Add(new SQLParams("ARB_CEST", arb_cest));
            sQLParams.Add(new SQLParams("DPI_CIMP", dpi_cimp));
            sQLParams.Add(new SQLParams("DPI_PRAC", dpi_prac));
            sQLParams.Add(new SQLParams("DPI_TPAG", dpi_tpag));
            sQLParams.Add(new SQLParams("ITE_ACTI", ite_acti));
            sql = DBHelper.SelectQueryString<Fa_Dpiuo>(sQLParams);
            return new DbConnection().Get<Fa_Dpiuo>(sql.ToString(), sQLParams);
        }
    }
}
