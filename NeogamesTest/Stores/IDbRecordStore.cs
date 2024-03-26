
using NeogamesTest.Models;

namespace NeogamesTest.Stores
{
    public interface IDbRecordStore
    {
        public List<DBRecord> GetPlayerBetsRecords(int PlayerID);
        public DBRecord[] GetPlayerBetsRecordsArray(int PlayerID);

    }
}
