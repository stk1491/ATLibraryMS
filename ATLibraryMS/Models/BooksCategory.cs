using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATLibraryMS.Models
{
    public class BooksCategory
    {
        [Key]
        public int BK_ID { get; set; }

        public string Name { get; set; }

        [ForeignKey("Categories")]
        public int Category_ID { get; set; }

        public virtual Category Categories { get; set; }

    }
}
