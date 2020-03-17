using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenFramework.DataBase;
using SevenFramework.DataBase.Utils;
using Digitalware.Apps.Utilities.Fa.TO;
using Ophelia;

namespace Digitalware.Apps.Utilities.Fa.DAO
{
    public class DAO_Fa_Dina
    {
        public List<Fa_Dina> ConsultarFaDdina(int emp_codi, long cli_codi)
        {
            try
            {
                List<SQLParams> sqlPrms = new List<SQLParams>()
                {
                    new SQLParams("EMP_CODI", emp_codi),
                    new SQLParams("CLI_CODI", cli_codi),
                    //new SQLParams("ITE_CTSE", ite_ctse)
                };
                string sql = DBHelper.SelectQueryString<Fa_Dina>(sqlPrms);
                return new DbConnection().GetList<Fa_Dina>(sql.ToString(), sqlPrms);
            }
            catch (Exception ex)
            {
                SevenFramework.Exceptions.ExceptionManager.Throw(this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
                return null;
            }
        }

        public List<Fa_Dina> ConsultarFaDdina(int emp_codi, long cli_codi, int dcl_codd)
        {
            try
            {
                List<SQLParams> sqlPrms = new List<SQLParams>()
                {
                    new SQLParams("EMP_CODI", emp_codi),
                    new SQLParams("CLI_CODI", cli_codi),
                    new SQLParams("DCL_CODD", dcl_codd)
                };
                string sql = DBHelper.SelectQueryString<Fa_Dina>(sqlPrms);
                var result = new DbConnection().GetList<Fa_Dina>(sql.ToString(), sqlPrms);
                return result;
            }
            catch (Exception ex)
            {
                SevenFramework.Exceptions.ExceptionManager.Throw(this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
                return null;
            }




        }


        public List<Fa_Dina> GetFaDdina(short emp_codi, long cli_codi,int dcl_codd=0)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("  SELECT FA_DDINA.AUD_ESTA,                   ");
                sql.Append("  FA_DDINA.AUD_USUA,                          ");
                sql.Append("  FA_DDINA.AUD_UFAC,                          ");
                sql.Append("  FA_DDINA.EMP_CODI,                          ");
                sql.Append("  FA_DDINA.CLI_CODI,                          ");
                sql.Append("  FA_DDINA.ITE_CTSE,                          ");
                sql.Append("  GN_ITESE.ITE_CODI ITE_COSE,                 ");
                sql.Append("  GN_ITESE.ITE_NOMB ITE_NOSE,                 ");
                sql.Append("  GN_ITESE.TIT_CONT TIT_CNSE,                 ");
                sql.Append("  FA_DDINA.DCL_CODD,                          ");
                sql.Append("  FA_DCLIE.DCL_NOMB,                          ");
                sql.Append("  FA_DDINA.DDI_NUMR,                          ");
                sql.Append("  FA_DDINA.DDI_FECR,                          ");
                sql.Append("  FA_DDINA.DDI_FECE,                          ");
                sql.Append("  FA_DDINA.DDI_FECT,                          ");
                sql.Append("  FA_DDINA.DDI_VIGE,                          ");
                sql.Append("  FA_DDINA.DDI_ESTA                           ");
                sql.Append("  FROM   FA_DDINA,                            ");
                sql.Append("  FA_INACL,                                   ");
                sql.Append("  FA_DCLIE,                                   ");
                sql.Append("  GN_ITEMS GN_ITESE                           ");
                sql.Append("  WHERE FA_DDINA.EMP_CODI = FA_INACL.EMP_CODI ");
                sql.Append("  AND FA_DDINA.CLI_CODI = FA_INACL.CLI_CODI   ");
                sql.Append("  AND FA_DDINA.EMP_CODI = FA_DCLIE.EMP_CODI   ");
                sql.Append("  AND FA_DDINA.CLI_CODI = FA_DCLIE.CLI_CODI   ");
                sql.Append("  AND FA_DDINA.DCL_CODD = FA_DCLIE.DCL_CODD   ");
                sql.Append("  AND FA_DDINA.ITE_CTSE = GN_ITESE.ITE_CONT   ");
                sql.Append("  AND FA_DDINA.EMP_CODI = @EMP_CODI           ");
                sql.Append("  AND FA_DDINA.CLI_CODI = @CLI_CODI           ");
                List<SQLParams> sqlPrms = new List<SQLParams>()
                {
                    new SQLParams("EMP_CODI", emp_codi),
                    new SQLParams("CLI_CODI", cli_codi),
                };
                if (dcl_codd > 0)
                {
                    sqlPrms.Add(new SQLParams("DCL_CODD", dcl_codd));
                }

                var result = new DbConnection().GetList<Fa_Dina>(sql.ToString(), sqlPrms);
                return result;
            }
            catch (Exception ex)
            {

                new OException().Throw(this.GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
                return null;
            }
            
        }
    }
}
