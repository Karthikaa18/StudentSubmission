//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myproject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Register
    {
        public int studentid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string password { get; set; }
        public Nullable<int> active { get; set; }
    }
}
