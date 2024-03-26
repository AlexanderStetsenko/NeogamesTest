using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeogamesTest.Models;
using Newtonsoft.Json;

namespace NeogamesTest.Stores
{
    public class DbRecordStore : IDbRecordStore
    {
        public List<DBRecord> GetPlayerBetsRecords(int PlayerID)
        {
            throw new NotImplementedException();

        }

        public DBRecord[] GetPlayerBetsRecordsArray(int PlayerID)
        {
            throw new NotImplementedException();
        }
    }
}
