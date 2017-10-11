using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.BaseModels
{
    public static class Base
    {
        public abstract class Entity
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ID { get; set; }
        }

        public abstract class Dto { }

        public abstract class ViewModel { }
    }
}
