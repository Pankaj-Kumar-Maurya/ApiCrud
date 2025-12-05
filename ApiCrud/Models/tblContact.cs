using System.ComponentModel.DataAnnotations;

namespace ApiCrud.Models
{
    public class tblContact
    {
        [Key]
        public int ContactID { get; set; }
         [Required]
        public string? Name { get; set; }
        public string? City { get; set; }
        [Required]
        public string? Email { get; set; }
        public DateTime DOB { get; set; }
        public string? ContactNo { get; set; }       
    }
}
