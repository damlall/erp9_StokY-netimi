using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstracts
{
    public abstract class AuditBase //Bu nesneden nesne oluşsun istemiyorum ama kaltım için kullanmak istiyorum
    {

        [StringLength(50)]
        public int CreatedUser { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [StringLength(50)]
        public int UpdateUser { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
