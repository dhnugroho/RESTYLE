//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CONTRAST_WEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_m_arrange_cashallowance
    {
        public int id { get; set; }
        public string @class { get; set; }
        public Nullable<double> domestic_meal_allow { get; set; }
        public Nullable<double> overseas_meal_allow_jpn { get; set; }
        public Nullable<double> overseas_meal_allow_asia { get; set; }
        public Nullable<double> overseas_meal_allow_usa { get; set; }
        public Nullable<double> overseas_pre_1_14 { get; set; }
        public Nullable<double> overseas_pre_15_90 { get; set; }
        public Nullable<double> overseas_pre_90 { get; set; }
        public Nullable<double> winter_allow { get; set; }
        public string comm_allow { get; set; }
        public string laundry_allow { get; set; }
    }
}
