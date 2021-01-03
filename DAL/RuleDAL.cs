using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class RuleDAL
    {
        public bool UpdateRules(int import, int MaximumBookLeft, int MinimumBookLeft, int MaximumOwe)
        {
            //MyRule rs = new MyRule(import, MaximumBookLeft, MinimumBookLeft,MaximumOwe);
            string SQL = "call USP_UpdateRules(" + import + "," + MaximumBookLeft + "," + MinimumBookLeft + "," + MaximumOwe + ")";
            try
            {
                DatabaseAccess.getInstance().getConnect();
                DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                DatabaseAccess.getInstance().getClose();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public MyRule GetRules()
        {
            string SQL = "CALL USP_GetRules()";
            MyRule rs = null;
            try
            {
                DatabaseAccess.getInstance().getConnect();
                DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                if (DatabaseAccess.getInstance().reader.Read())
                {
                    int NhaptoiThieu = DatabaseAccess.getInstance().reader.GetInt32("LuongNhapToiThieu");
                    int TonTruocKhiNhap = DatabaseAccess.getInstance().reader.GetInt32("LuongTonTruocKhiNhap");
                    int TonSauKhiBan = DatabaseAccess.getInstance().reader.GetInt32("LuongTonSauKhiBan");
                    int TienNoToiDa = DatabaseAccess.getInstance().reader.GetInt32("TienNoToiDa");
                    rs = new MyRule(NhaptoiThieu, TonTruocKhiNhap, TonSauKhiBan, TienNoToiDa);
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return rs;
        }
    }
}
