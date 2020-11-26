using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class ImportBookCardBLL
    {
        private ImportBookCardDAL importBookCardDAL = null;
        public ImportBookCardBLL()
        {
            importBookCardDAL = new ImportBookCardDAL();
        }
        public bool AddImportBookCard(DateTime date, float value, ListView ListBookImport)
        {
            if (importBookCardDAL.AddImportBookCard(date, value))
            {
                try
                {
                    foreach (ListViewItem book in ListBookImport.Items)
                    {
                        string id = book.SubItems[1].Text;
                        int count = Int32.Parse(book.SubItems[3].Text);
                        float price = float.Parse(book.SubItems[4].Text);
                        float total = float.Parse(book.SubItems[5].Text);
                        if (!importBookCardDAL.AddImportBookCardInfo(id, count, price, total))
                            return false;
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
