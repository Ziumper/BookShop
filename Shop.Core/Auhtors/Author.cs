using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Auhtors
{
    public class Author : Entity
    {
        public Author()
        {

        }
        [MaxLength(255)]
        public virtual string Name { get; set; }
    }
}
