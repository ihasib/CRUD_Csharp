//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Level2_DatabaseByCsharp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        public string CourseID { get; set; }
        public string TraineeID { get; set; }
        public string Id { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
