//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstate_Management.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class PerfectPropertyMaster
    {
        [Key]
        public int Perfectproid { get; set; }
        [DisplayName("Property Heading")]
        public string Property_heading { get; set; }
        [DisplayName("Property Description")]
        public string Property_description { get; set; }
        [DisplayName("Property Point1")]
        public string Property_Point1 { get; set; }
        [DisplayName("Property Point2")]
        public string Property_Point2 { get; set; }
        [DisplayName("Property Point3")]
        public string Property_Point3 { get; set; }
        [DisplayName("Property Image")]
        public string Property_Image { get; set; }
    }
}