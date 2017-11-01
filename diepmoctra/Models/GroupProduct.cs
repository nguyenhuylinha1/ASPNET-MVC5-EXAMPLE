//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace diepmoctra.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupProduct
    {
        public GroupProduct()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public string Level { get; set; }
        public Nullable<byte> Priority { get; set; }
        public Nullable<byte> Main { get; set; }
        public Nullable<byte> Hot { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public Nullable<byte> Active { get; set; }
        public Nullable<int> Ord { get; set; }
        public string Lang { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}