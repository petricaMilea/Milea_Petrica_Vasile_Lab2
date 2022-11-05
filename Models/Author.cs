using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Milea_Petrica_Vasile_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
