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
    
    public partial class Hostel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hostel()
        {
            this.LeaveAndBookeds = new HashSet<LeaveAndBooked>();
            this.RoombookingInfoes = new HashSet<RoombookingInfo>();
            this.Rooms = new HashSet<Room>();
            this.Payments = new HashSet<Payment>();
        }
    
        public int hostelId { get; set; }
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public Nullable<System.DateTime> IsCreatedOn { get; set; }
        public Nullable<int> IsUpdateBy { get; set; }
        public Nullable<System.DateTime> IsUpdateON { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> IsCreatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveAndBooked> LeaveAndBookeds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoombookingInfo> RoombookingInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}