﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPSTracking.Domain.Entities
{
    public class VehicleDriveType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }



        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}