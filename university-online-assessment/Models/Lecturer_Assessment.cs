//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace university_online_assessment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lecturer_Assessment
    {
        public System.Guid Id { get; set; }
        public System.Guid lecturerId { get; set; }
        public System.Guid assessmentId { get; set; }
    
        public virtual aspnet_Users aspnet_Users { get; set; }
        public virtual Assessment Assessment { get; set; }
    }
}