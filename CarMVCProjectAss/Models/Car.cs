using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarMVCProjectAss.Models
{
    public class Car
    {
      
        public int Id { get; set; }
       
        public string VIN { get; set; }
       
        public string Make { get; set; }
       
        public string Model { get; set; }
        public string Style { get; set; }
        
        public int Year { get; set; }
     
        public double Miles { get; set; }
        public string Color { get; set; }

        public string ConsumerId { get; set; }


        
        public Consumer Consumer { get; set; }
}

    }
