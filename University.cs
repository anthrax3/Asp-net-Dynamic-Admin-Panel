//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamicDataTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class University
    {
        public University()
        {
            this.CoachORStaffs = new HashSet<CoachORStaff>();
        }
        
        public long UniversityID { get; set; }
        [DisplayName("A fancy column name")]
        public string UniversityName { get; set; }
        public string UniversityURL { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ChangeDate { get; set; }
        public string Title { get; set; }
        public string UniversityLogo { get; set; }
        public string UniversityLink { get; set; }
        [DisplayName("Is this active?")]
        public Nullable<bool> IsActive { get; set; }
        public string UniversityKey { get; set; }
        public Nullable<bool> IsAdmission { get; set; }
        public string UniversityFullName { get; set; }
        public string State { get; set; }
        public Nullable<bool> DKIM { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<long> IpedID { get; set; }
    
        public virtual ICollection<CoachORStaff> CoachORStaffs { get; set; }
    }
}