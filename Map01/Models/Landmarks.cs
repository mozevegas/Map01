using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Map01.Models
{
    public class Landmarks
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
    }
}