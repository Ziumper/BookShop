using Abp.Domain.Entities;
using Shop.Auhtors;
using Shop.PublishingHauses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Books
{
    public class Book : Entity<long>
    {
        public Book()
        {
        }

        [MaxLength(255)]
        public virtual string Name { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual double Price { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        public virtual int AuthorId { get; set; }
        [ForeignKey("PublishingHauseId")]
        public virtual PublishingHause PublishingHause { get; set; }
        public virtual int PublishingHauseId { get; set; }
        public virtual int Type { get; set; }
        public virtual bool SpecialOccasion { get; set; }
    
    }
}
