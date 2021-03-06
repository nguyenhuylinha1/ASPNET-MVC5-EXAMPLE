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
    
    public partial class Product
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public Nullable<int> GroupProductId { get; set; }
        public string Image { get; set; }
        public string FileAttach1 { get; set; }
        public string FileAttach2 { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public string ContentDetail { get; set; }
        public string ContentDetail2 { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> PriceNew { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> Views { get; set; }
        public Nullable<byte> Priority { get; set; }
        public Nullable<byte> Main { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public Nullable<byte> Active { get; set; }
        public Nullable<int> Ord { get; set; }
        public string Lang { get; set; }
    
        public virtual GroupProduct GroupProduct { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
