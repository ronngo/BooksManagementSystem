using System;

namespace BooksManagementSystem
{
    interface IBook
    {
        public int ID { set; get; }
        public string Name { set; get; } 
        public DateTime PublishDate { set; get; } 
        public string Author { set; get; } 
        public string Language { set; get; } 
        public float AveragePrice { set; get; }

        public void Display();
    }
}