using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class Order
    {
        public string Id { get; set; }
        public IEnumerable<Dishe> Dishes { get; set; }
    }
}
