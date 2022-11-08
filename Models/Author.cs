using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Milea_Petrica_Vasile_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
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
