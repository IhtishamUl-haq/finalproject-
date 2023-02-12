//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostelManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoombookingInfo
    {
        public int bookingId { get; set; }
        public Nullable<System.DateTime> bookingDate { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> roomId { get; set; }
        public Nullable<int> hostelId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> updateBy { get; set; }
    
        public virtual Hostel Hostel { get; set; }
        public virtual User User { get; set; }
        public virtual Room Room { get; set; }
    }
}
