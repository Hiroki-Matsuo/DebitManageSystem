using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitManageSystem
{
    interface IDAOBase
    {

        int InsertRecord(int cd, string name);

        int UpdateRecord(int cd, string name);

        int UpdateSomeDebitRecords(List<DebitInfo> debitInfos);

    }

    interface IClientDAO
    {
        client_table SelectNameForCode(int cd);



    }
}
