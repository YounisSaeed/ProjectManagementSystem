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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public team()
        {
            this.CreateProjects = new HashSet<CreateProject>();
        }
    
        public int id { get; set; }
        public string lderUname { get; set; }
        public string memUname { get; set; }
        public string leader_name { get; set; }
        public string member_name { get; set; }
        public string usrname { get; set; }
        public string project_name { get; set; }
        public string state { get; set; }
        public IEnumerable<project> projects { get; set; }
        public IEnumerable<user> mt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreateProject> CreateProjects { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
        public virtual user user2 { get; set; }
    }
}
