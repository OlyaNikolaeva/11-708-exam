﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class Dishe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Desc { get; set; }
        public int RestaurantId { get; set; }
    }
}
