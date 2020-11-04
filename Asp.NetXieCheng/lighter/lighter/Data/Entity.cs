using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lighter.Data
{
    public class Entity
    {
        public string Id { get; set; }
        public string IdentityId { get; set; }
        public string TenantId { get; set; }
        public string UserId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime LastUpdatedAt { get; set; }
        public DateTime LastUpdateBy { get; set; }
    }
}
