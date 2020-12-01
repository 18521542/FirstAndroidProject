using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CustomerDAL
    {
        public List<Customer> getCustomers()
        {
            string SQL = "CALL USP_GetCustomer()";
            List<Customer> list = new List<Customer>();
            try
            {
                DatabaseAccess.getInstance().getConnect();
                DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                while (DatabaseAccess.getInstance().reader.Read())
                {
                    string id = DatabaseAccess.getInstance().reader.GetString("MaKhachHang");
                    string name = DatabaseAccess.getInstance().reader.GetString("TenKhachHang");
                    string phone = DatabaseAccess.getInstance().reader.GetString("SoDienThoai");
                    string email = DatabaseAccess.getInstance().reader.GetString("Email");
                    string address = DatabaseAccess.getInstance().reader.GetString("DiaChi");
                    float owe = (float)Math.Round(float.Parse(DatabaseAccess.getInstance().reader.GetString("SoTienNo")));
                    list.Add(new Customer(id, name, phone, email, address, owe));
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return list;
        }

        public Customer getCustomerByID(string customerID)
        {
            string SQL = "CALL USP_GetCustomerByID(\"" + customerID + "\")";
            Customer customer = null;
            try
            {
                DatabaseAccess.getInstance().getConnect();
                DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                while (DatabaseAccess.getInstance().reader.Read())
                {
                    string id = DatabaseAccess.getInstance().reader.GetString("MaKhachHang");
                    string name = DatabaseAccess.getInstance().reader.GetString("TenKhachHang");
                    string phone = DatabaseAccess.getInstance().reader.GetString("SoDienThoai");
                    string email = DatabaseAccess.getInstance().reader.GetString("Email");
                    string address = DatabaseAccess.getInstance().reader.GetString("DiaChi");
                    float owe = (float)Math.Round(float.Parse(DatabaseAccess.getInstance().reader.GetString("SoTienNo")));
                    customer = new Customer(id, name, phone, email, address, owe);
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return customer;
        }

        public bool AddCustomer(string name, string phone, string email, string address)
        {
            string SQL = "call USP_AddCusTomer('" + name + "','" + phone + "','" + email + "','" + address + "')";
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

        public bool UpdateCustomer(string id, string name, string phone, string email, string address)
        {
            string SQL = "call USP_UpdateCusTomer('" + id + "','" + name + "','" + phone + "','" + email + "','" + address + "')";
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

        public string GetCustomerIDByName(string name)
        {
            string SQL = "Select * from KHACHHANG where TenKhachHang = '" + name +"'";
            string rs = "";
            try
            {
                DatabaseAccess.getInstance().getConnect();
                DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                while (DatabaseAccess.getInstance().reader.Read())
                {
                    rs = DatabaseAccess.getInstance().reader.GetString("MaKhachHang");
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return rs;
        }
    }
}
