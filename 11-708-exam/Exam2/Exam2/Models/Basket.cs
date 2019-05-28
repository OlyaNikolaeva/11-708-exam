using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class Basket
    {
        [Key]
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<string> DishesId { get; private set; }
        public int Cost { get; set; }
        public void AddDish(Dishe dish)
        {
            DishesId.Add(dish.Id);
            Cost += dish.Cost;
        }
    }
}
