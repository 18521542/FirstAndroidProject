using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class AuthorBLL
    {
        private AuthorDAL authorDAL = null;
        public AuthorBLL()
        {
            authorDAL = new AuthorDAL();
        }
        public List<Author> GetAuthors()
        {
            return authorDAL.getAuthors();
        }

        public bool AddAuthor(string AuthorName)
        {
            return authorDAL.AddAuthor(AuthorName);
        }

        public string GetAuthorIDByName(string name)
        {
            return authorDAL.GetAuthorIDByName(name);
        }
    }
}
