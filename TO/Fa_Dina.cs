using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalware.Apps.Utilities.Fa.TO
{

    [SevenFramework.DataBase.TableName("FA_DDINA")]
    public  class Fa_Dina
    {            
            public string aud_esta { get; set; }
            public string aud_usua { get; set; }
            public DateTime aud_ufac { get; set; }
            public short emp_codi { get; set; }
            public decimal cli_codi { get; set; }
            public decimal ite_ctse { get; set; }
            public short dcl_codd { get; set; }
            public string ddi_numr { get; set; }
            public DateTime ddi_fecr { get; set; }
            public DateTime ddi_fece { get; set; }
            public DateTime? ddi_fect { get; set; }
            public short ddi_vige { get; set; }
            public string ddi_esta { get; set; }

            [SevenFramework.DataBase.NotMapped]
            public string ite_nose { get; set; }
        [SevenFramework.DataBase.NotMapped]
        public string ite_cose { get; set; }
        
    }
}
