//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KSA_MOTOR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class quotation
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public string VPicture { get; set; }
        public string PartsNumber { get; set; }
        public string PartsName { get; set; }
        public string PartsDescription { get; set; }
        public string PPicture { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public string Status { get; set; }
    }
}
