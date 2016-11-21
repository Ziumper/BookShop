using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Eidtions
{
    public class Edition : Entity
    {
        public Edition()
        {

        }
       
        public virtual DateTime Release { get; set; }
    }
}
