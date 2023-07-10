using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automail
{
    [Serializable]
    class AuthUserEntry
    {
        //private string accountName;
        public string accountName;
        private int accountId;
       // [NonSerialized] public string test;
         public string test;
        
        public string AccountName {
            get;
            set;
        }
        public int AccountId {
            get;
            set;

        }

    }
}
