﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DT102G_project.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public Category()
        {
        }
    }
}
