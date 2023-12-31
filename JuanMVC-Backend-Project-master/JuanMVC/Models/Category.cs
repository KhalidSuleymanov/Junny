﻿using System.ComponentModel.DataAnnotations;

namespace JuanMVC.Models
{
    public class Category
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
