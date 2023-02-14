using System.ComponentModel.DataAnnotations;

//Get and set the form variables and also set what type they are 
namespace Mission06_yiywu.Models
{
    public class ApplicationResponse
    {
        //Ensure that requirments for the forms are being met
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}
