using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrProvincesAPI.Models
{
    public class Province
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Capital { get; set; }
        [Required]
        public string Region { get; set; }
        public string Department { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
        public double Density { get; set; }
        public string Map { get; set; }
        public string CoatOfArms { get; set; }
        public DateTime Created { get; set; }


    }
}
