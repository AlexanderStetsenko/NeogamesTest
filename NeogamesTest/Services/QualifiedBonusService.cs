using NeogamesTest.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeogamesTest.Services
{
    public class QualifiedBonusService
    {
        private IDbRecordStore _dbRecordStore;

        public QualifiedBonusService(IDbRecordStore dbRecordStore)
        {
            _dbRecordStore = dbRecordStore;
        }


        public bool IsQualifyForBonus(int PlayerID)
        {
            var records = _dbRecordStore.GetPlayerBetsRecords(PlayerID);

            if (records.Select(r => r.WinAmount > 0).ToList().Count >= 10
                && records.All(r => r.BetAmount > r.WinAmount)
                && records.Sum(r => r.WinAmount) == records.Sum(r => r.BetAmount) / 2
                )
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
