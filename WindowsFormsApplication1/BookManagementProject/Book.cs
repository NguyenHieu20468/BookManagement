//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookManagementProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int ID { get; set; }
        public string BookCode { get; set; }
        public string BookName { get; set; }
        public string AuthorCode { get; set; }
        public string Topic { get; set; }
    
        public virtual Author Author { get; set; }
    }
}