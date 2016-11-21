using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Carriers
{
    public class Carrier : Entity
    {
        public Carrier()
        {

        }
        [MaxLength(255)]
        public virtual string Name { get; set; }
    }
}
