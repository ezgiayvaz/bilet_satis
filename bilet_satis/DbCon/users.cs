//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bilet_satis.DbCon
{
    using System;
    using System.Collections.Generic;
    
    public partial class users
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public Nullable<System.DateTime> B_DAY { get; set; }
        public string MAIL { get; set; }
        public string PHONE { get; set; }
        public string PASSWORD { get; set; }

        public override string ToString()
        {
            return NAME + "\t" + PHONE;
        }
    }
}