using System.ComponentModel.DataAnnotations;

namespace Mission06_yiywu.Models
{
    //Get info of the categories id and name
    public class Category
    {
        
            [Key]
            [Required]
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        
    }
}
