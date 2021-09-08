using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ICollection<RegistrationTag> RegistrationTags { get; set; }
    }

    public class TagActions : PersistentObjectActionsReference<AdoptiepuntContext, Tag>
    {
        public TagActions(AdoptiepuntContext context) : base(context) { }
    }
}
