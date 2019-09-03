using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstracts
{
    public abstract class BaseEntity<TKey> : AuditBase, IEntity<TKey>
    {
        [Key] // Yazmasakta olur ıd yi algılıyor zaten
        public TKey Id { get; set; }
    }
}
