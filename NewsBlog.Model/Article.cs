//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsBlog.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        public Article()
        {
            this.Comments = new HashSet<Comment>();
            this.Images = new HashSet<Image>();
            this.Votes = new HashSet<Vote>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public System.DateTime Date { get; set; }
        public int AuthorId { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
