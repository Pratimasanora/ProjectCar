using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace CarMVCProjectAss.Models
{
    public class Service
    {
        public int Id { get; set; }
        public double Miles { get; set; }
        public double Price { get; set; }
        public string Details { get; set; }
        public DateTime DateAdded { get; set; }
        public int CarId { get; set; }
        public int ServiceTypeId { get; set; }
        public virtual Car Car { get; set; }
        public ServiceType ServiceType { get; set; }

    }
}