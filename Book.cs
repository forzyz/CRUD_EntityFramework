using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EntityFramework
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Sage> Sages { get; set; }
        public Book()
        {
            Sages = new List<Sage>();
        }
    }
}
