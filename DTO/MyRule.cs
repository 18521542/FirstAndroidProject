using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MyRule
    {
        //min book when import
        public int MininumImport { get;  }

        //max book left when sell for someone
        public int MaximumBookLeft { get; }

        //Min book in repo before import
        public int MinimumBookLeft { get; }

        //Max money for someone owed
        public int MaximumOwe { get; }

        public MyRule()
        {

        }
        public MyRule(int import, int MaximumBookLeft, int MinimumBookLeft, int MaximumOwe)
        {
            this.MininumImport = import;
            this.MaximumBookLeft = MaximumBookLeft;
            this.MinimumBookLeft = MinimumBookLeft;
            this.MaximumOwe = MaximumOwe;
        }
    }
}
