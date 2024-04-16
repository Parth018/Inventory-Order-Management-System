﻿using Indotalent.Models.Contracts;

namespace Indotalent.Models.Entities
{
    public class Product : _Base
    {
        public Product() { }
        public required string Name { get; set; }
        public string? Number { get; set; }
        public string? Description { get; set; }
        public required double UnitPrice { get; set; }
        public bool Physical { get; set; } = true;
        public required int UnitMeasureId { get; set; }
        public UnitMeasure? UnitMeasure { get; set; }
        public required int ProductGroupId { get; set; }
        public ProductGroup? ProductGroup { get; set; }
    }
}
