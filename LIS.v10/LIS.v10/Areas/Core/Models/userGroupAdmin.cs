//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIS.v10.Areas.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class userGroupAdmin
    {
        public int Id { get; set; }
        public int userGroupId { get; set; }
        public string UserId { get; set; }
    
        public virtual userGroup userGroup { get; set; }
    }
}
