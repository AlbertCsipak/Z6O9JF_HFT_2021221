﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6O9JF_HFT_2021221.Models
{
    public class Mechanic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MechanicId { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public virtual CarService CarService { get; set; }

        [ForeignKey(nameof(CarService))]
        public int ServiceNumber { get; set; }

        [NotMapped]
        public virtual ICollection<Car> Cars { get; set; }

        public Mechanic()
        {
            Cars = new HashSet<Car>();
        }
    }
}