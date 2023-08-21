using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ATLibraryMS.Models
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }
        public String  Category_Name { get; set; }
    }
}
