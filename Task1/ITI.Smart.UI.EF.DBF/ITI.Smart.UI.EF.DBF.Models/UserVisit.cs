//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITI.Smart.UI.EF.DBF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserVisit
    {
        public int UserId { get; set; }
        public int CityId { get; set; }
        public Nullable<System.DateTime> when { get; set; }
    
        public virtual City City { get; set; }
        public virtual User User { get; set; }
    }
}
