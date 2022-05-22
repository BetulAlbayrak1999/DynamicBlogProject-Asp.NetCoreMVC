using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string ImageOne { get; set; }
        public string ImageTwo { get; set; }
        public string DetailsOne { get; set; }
        public string DetailsTwo { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
