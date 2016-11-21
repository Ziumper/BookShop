using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.PublishingHauses
{
    public class PublishingHause : Entity
    {
        public PublishingHause()
        {

        }
        [MaxLength(255)]
        public virtual string Name { get; set; }
    }
}
