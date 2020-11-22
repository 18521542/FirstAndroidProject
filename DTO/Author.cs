using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Author
    {
        private string id;
        private string name;

        public Author() { }
        public Author(string _id, string _name)
        {
            this.id = _id;
            this.name = _name;
        }

        public string Id() { return this.id; }
        public string Name() { return this.name; }

        
    }
}
