using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DatabaseAccess.getInstance().getConnect();
                Console.WriteLine("Ket noi thanh cong");
            }
            catch(Exception e)
            {
                Console.WriteLine("Ket noi that bai");
            }
            finally
            {
                DatabaseAccess.getInstance().getClose();
            }
            
            //MySqlConnection mySql = null;
            //try
            //{
            //    mySql = new MySqlConnection(strConn);
            //    mySql.Open();
            //    Console.WriteLine("Ket noi thanh cong");
            //}
            //catch
            //{
            //    Console.WriteLine("Ket noi that bai");
            //}
            //finally
            //{
            //    mySql.Close();
            //    mySql.Dispose();
            //}
            Console.ReadLine();
        }
    }
}
