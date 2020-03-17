using Digitalware.Apps.Utilities.Fa.TO;
using SevenFramework.DataBase;
using SevenFramework.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalware.Apps.Utilities.Fa.DAO
{
  public  class DAO_Fa_Inacl
    {
       public Fa_Inacl GetFaInacl (short emp_codi, long cli_codi)
        {
            try
            {               
                List<SQLParams> sqlPrms = new List<SQLParams>()
                {
                    new SQLParams("EMP_CODI", emp_codi),
                       new SQLParams("CLI_CODI", cli_codi),
                };
                StringBuilder sql = new StringBuilder();
                sql.Append("  SELECT *                                               ");
                sql.Append("  FROM   FA_INACL INA                                    ");
                sql.Append("  INNER JOIN GN_ITEMS ITE                                ");
                sql.Append("  ON INA.ITE_CTGO = ITE.ITE_CONT                         ");
                sql.Append("  WHERE INA.CLI_CODI = @CLI_CODI AND INA.EMP_CODI = @EMP_CODI   ");
                var retorno = new DbConnection().Get<Fa_Inacl>(sql.ToString(), sqlPrms);
                return retorno;

            }
            catch(SqlException ex)
            {
                ExceptionManager.Throw(this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
                return null;
            }
            catch (Exception ex)
            {
                ExceptionManager.Throw(this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
                return null;
            }

        }


    }
}
