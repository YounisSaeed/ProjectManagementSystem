//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class team
    {
        public int id { get; set; }
        public string lderUname { get; set; }
        public string memUname { get; set; }
        public string leader_name { get; set; }
        public string member_name { get; set; }
        public string usrname { get; set; }
    
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
        public virtual user user2 { get; set; }
    }
}
