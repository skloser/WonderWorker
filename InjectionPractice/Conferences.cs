//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InjectionPractice
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conferences
    {
        public int ConferenceId { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int FreeSeats { get; set; }
        public string Venue { get; set; }
        public int CompanyId { get; set; }
    
        public virtual Companies Companies { get; set; }
    }
}