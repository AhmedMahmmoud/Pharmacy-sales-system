//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacytask
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cus_Category
    {
        public int Ca_id { get; set; }
        public int Cus_id { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
