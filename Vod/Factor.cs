//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vod
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factor
    {
        public int Id { get; set; }
        public System.DateTime DateTime { get; set; }
        public string TransactionId { get; set; }
        public int UserId { get; set; }
        public int MovieID { get; set; }
        public int Amount { get; set; }
        public bool Result { get; set; }
        public System.DateTime CompleteDateTime { get; set; }
    
        public virtual User User { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}