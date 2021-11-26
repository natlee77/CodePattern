using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SOLID.Models
{
    public class Animal : IAnimal 
    {
        [Key]
        [Required]
        public int PetsId { get; set; }
        public int UserId { get; set; }
        public string PetsName { get; set; }
        public string TypeOfAnimal { get; set; }
        
        public Animal()
        {
            
        }

        public Animal(int petsId, int userId, string petsName, string typeOfAnimal)
        {
            PetsId = petsId;
            UserId = userId;
            PetsName = petsName;
            TypeOfAnimal = typeOfAnimal;
        }
        [ForeignKey("UserId")]
        public virtual User User{ get; set; }
        public virtual List<ExtraService> ExtraServices { get; set; }
        public virtual List<DayService> Schedules { get; set; }

    }

}
