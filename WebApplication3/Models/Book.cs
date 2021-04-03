﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Author { get; set; }
    }
}
