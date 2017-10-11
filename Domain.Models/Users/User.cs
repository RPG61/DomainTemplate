using Domain.Models.BaseModels;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.POCOs
{
    public class User : Base.Entity
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string Surname { get; set; }
    }
}
