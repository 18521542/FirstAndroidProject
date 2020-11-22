using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Book
    {
        private string id;
        private string name;
        private List<Author> authors;
        private Category category;
        private string publishCompany;
        private int publishYear;
        private int count;
        private float price;

        public Book() { }
        public Book(string id, string name, List<Author> authors, Category category, string publishCompany, int publishYear, int count, float price)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.authors = authors;
            this.price = price;
            this.count = count;
            this.publishCompany = publishCompany;
            this.publishYear = publishYear;
        }

        public string Id()
        {
            return id;
        }
        public string Name()
        {
            return name;
        }
        public List<Author> Authors()
        {
            return authors;
        }
        public Category Category()
        {
            return category;
        }
        public String PublishCompany()
        {
            return publishCompany;
        }
        public int PublishYear()
        {
            return publishYear;
        }
        public int Count()
        {
            return count;
        }
        public float Price()
        {
            return price;
        }
    }
}
