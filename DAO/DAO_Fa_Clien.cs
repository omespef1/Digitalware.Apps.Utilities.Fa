using Digitalware.Apps.Utilities.Fa.TO;
using Ophelia;
using SevenFramework.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalware.Apps.Utilities.Fa.DAO
{
    public class DAO_Fa_Clien
    {

        public Fa_Clien GetFaClien(int emp_codi, string cli_coda, string cli_clav)
        {
            OException oException = new OException();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("  SELECT *                    ");
                sql.Append("  FROM   FA_CLIEN             ");
                sql.Append("  WHERE  EMP_CODI = @EMP_CODI      ");
                sql.Append("  AND CLI_CODA = @CLI_CODA   ");
                sql.Append("  AND CLI_ESTA = 'A'          ");
                sql.Append(" AND CLI_CLAV = @CLI_CLAV");
                List<SQLParams> sQLParams = new List<SQLParams>();
                sQLParams.Add(new SQLParams("EMP_CODI", emp_codi));
                sQLParams.Add(new SQLParams("CLI_CODA", cli_coda));
                sQLParams.Add(new SQLParams("CLI_CLAV", cli_clav));
                return new DbConnection().Get<Fa_Clien>(sql.ToString(), sQLParams);
            }
            catch (Exception ex)
            {

                oException.Throw(this.GetType().ToString(), "GetFaClien", ex);
                return null;
            }
        }

        public String GetCliCoda(int emp_codi, int cli_codi)
        {
            OException oException = new OException();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("  SELECT CLI_CODA                    ");
                sql.Append("  FROM   FA_CLIEN             ");
                sql.Append("  WHERE  EMP_CODI = @EMP_CODI      ");
                sql.Append("  AND CLI_CODI = @CLI_CODI   ");
                sql.Append("  AND CLI_ESTA = 'A'          ");               
                List<SQLParams> sQLParams = new List<SQLParams>();
                sQLParams.Add(new SQLParams("EMP_CODI", emp_codi));
                sQLParams.Add(new SQLParams("CLI_CODI", cli_codi));               
                var result = new DbConnection().ExecuteScalar(sql.ToString(), sQLParams);
                return result == null ? "" : (string)result;
            }
            catch (Exception ex)
            {

                oException.Throw(this.GetType().ToString(), "GetFaClien", ex);
                return null;
            }
        }

        public Fa_Dclie GetFaClien(int emp_codi,string cli_coda,int dcl_codd)
        {
            //    StringBuilder sql = new StringBuilder();
            //sql.Append("    SELECT CLI_CODA,                                        ");
            //sql.Append("    CLI.TIP_CODI,                                           ");
            //sql.Append("    CLI_NOCO,                                               ");
            //sql.Append("    DCL.DCL_DIRE,                                           ");
            //sql.Append("    DCL.DCL_NTEL,                                           ");
            //sql.Append("    DCL.DCL_MAIL                                            ");
            //sql.Append("    FROM   FA_CLIEN CLI                                     ");
            //sql.Append("    INNER JOIN FA_DCLIE DCL                                 ");
            //sql.Append("    ON CLI.EMP_CODI = DCL.EMP_CODI                          ");
            //sql.Append("    AND CLI.CLI_CODI = DCL.CLI_CODI                         ");
            //sql.Append("    WHERE DCL.EMP_CODI = @EMP_CODI AND CLI_CODA = @CLI_CODA  ");
            //sql.Append("    AND DCL.DCL_CODD = @DCL_CODD  ");
            return null;                                      

        }
    }
}
