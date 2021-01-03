using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class MyRuleBLL
    {
        private RuleDAL ruleDAL = null;

        public MyRuleBLL()
        {
            this.ruleDAL = new RuleDAL();
        }

        public bool UpdateRules(int import, int MaximumBookLeft, int MinimumBookLeft, int MaximumOwe)
        {
            return this.ruleDAL.UpdateRules(import, MaximumBookLeft, MinimumBookLeft, MaximumOwe);
        }

        public MyRule GetRules()
        {
            return this.ruleDAL.GetRules();
        }
    }
}
