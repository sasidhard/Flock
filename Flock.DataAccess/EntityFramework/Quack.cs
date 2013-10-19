//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flock.DataAccess.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quack
    {
        public Quack()
        {
            this.Quack1 = new HashSet<Quack>();
        }
    
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ContentID { get; set; }
        public int QuackTypeID { get; set; }
        public int ConversationID { get; set; }
        public Nullable<int> ParentQuackID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
    
        public virtual ICollection<Quack> Quack1 { get; set; }
        public virtual Quack Quack2 { get; set; }
        public virtual QuackContent QuackContent { get; set; }
        public virtual QuackType QuackType { get; set; }
        public virtual User User { get; set; }
    }
}
