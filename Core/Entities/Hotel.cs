﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }

        public double Rating { get; set; }

        [ForeignKey(nameof(PhotosHotel))]
        public int PhotosHotelID { get; set; }
        public PhotosHotel PhotosHotel { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
