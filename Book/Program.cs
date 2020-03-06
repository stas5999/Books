using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        public static List<Book> books;
        static void Main(string[] args)
        {
            //List<Book> books = new List<Book>(10);
            //books.Add(new Book("Лев Толстой", "Война и Мир"));
            //books.Add(new Book("Владимир Набоков", "Лолита"));
            //books.Add(new Book("Ф. Скотт Фицджеральд", "Великий Гэтсби"));
            //books.Add(new Book("Дублинцы", "Джеймс Джойс"));
            //books.Add(new Book("Сто лет одиночества", "Габриэль Гарсиа Маркес"));
            //books.Add(new Book("Анна Каренина", "Лев Толстой"));
            //books.Add(new Book("Мадам Бовари", "Гюстав Флобер"));
            //books.Add(new Book("Моби Дик", "Герман Мелвилл"));
            //books.Add(new Book("Большие надежды", "Чарльз Диккенс"));
            //books.Add(new Book("Эмма", "Джейн Остин"));
            Console.WriteLine("1.Добавить");
            Console.WriteLine("2.Поиск");
            books = new List<Book>();
            bool q = true;
            while (q)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Имя автора, название книги");
                        string readLine = Console.ReadLine();
                        if (readLine != null)
                        {
                            string[] temp = readLine.Split(',');
                            Add(temp[0], temp[1]);
                        }
                        break;

                    case "2":
                        {
                            foreach (Book book in books)
                            {
                                Console.WriteLine("Автор : "+book.Autor);
                                Console.WriteLine("Книга : "+book.Title);
                            }
                        }
                        break;
                }
            }
        }
        public static void Print()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("Название: {0}, Автор: {1}", book.Autor, book.Title);
            }
        }


        public static void Add(string autor,string title)
        {
            books.Add(new Book(autor, title));
        }
    }
}

