using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace CRUD_EntityFramework
{
    internal class MyContextInitializer : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            //Insert Books And Sages 

            // Books 
            Book b1 = new Book() { Title = "Book1" };
            Book b2 = new Book() { Title = "Book2" };
            Book b3 = new Book() { Title = "Book3" };
            Book b4 = new Book() { Title = "Book4" };
            context.Books.Add(b1);
            context.Books.Add(b2);
            context.Books.Add(b3);
            context.Books.Add(b4);
            // context.Books.AddRange(new List<Book> { b1, b2, b3, b4 }); 
            context.SaveChanges();

            byte[] blob = null;
            using (FileStream stream = new FileStream("C:/Users/PC/Pictures/1_1323387.jpg", FileMode.Open))
            {
                blob = new byte[stream.Length];
                stream.Read(blob, 0, (int)stream.Length);
            }

            // Sages 
            Sage s1 = new Sage { Name = "Sage1", Birthday = new DateTime(2000, 4, 7), Image = blob};
            s1.Books.Add(b1);
            s1.Books.Add(b2);
            Sage s2 = new Sage { Name = "Sage2", Birthday = new DateTime(1988, 12, 26) };
            s2.Books.Add(b3);
            Sage s3 = new Sage { Name = "Sage3", Birthday = new DateTime(1970, 11, 14) };
            context.Sages.Add(s1);
            context.Sages.Add(s2);
            context.Sages.Add(s3);
            context.SaveChanges();
        }
    }
}