//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlutoDbFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseSection
    {
        public int SectionID { get; set; }
        public int CourseID { get; set; }
        public string Title { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
