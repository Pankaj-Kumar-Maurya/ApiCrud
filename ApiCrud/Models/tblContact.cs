using System.ComponentModel.DataAnnotations;

namespace ApiCrud.Models
{
    public class tblContact
    {
        int ContactID { get; set; }
        [Required]
        string? Name { get; set; }
        string? City { get; set; }
        [Required]
        string? Email { get; set; }
        DateTime DOB { get; set; }
        string? ContactNo { get; set; }
       
    }
}
