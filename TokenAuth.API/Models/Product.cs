﻿using Microsoft.EntityFrameworkCore;

namespace TokenAuth.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        [Precision(18,2)]
        public decimal Price { get; set; }
    }
}
