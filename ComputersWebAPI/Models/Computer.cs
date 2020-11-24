using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputersWebAPI.Models
{
    public class Computer
    {
        [Key] // create unique id field
        public int Id { get; set; }
        // store company name
        public string Company { get; set; }
        // store description like specs ram cpu etc
        public string Description { get; set; }
        // and price of computer
        public double Price { get; set; }
    }
}
