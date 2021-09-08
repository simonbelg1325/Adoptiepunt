using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class Type
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ICollection<RegistrationTag> RegistrationTags { get; set; }
    }

    public class TypeActions : PersistentObjectActionsReference<AdoptiepuntContext, Type>
    {
        public TypeActions(AdoptiepuntContext context) : base(context) { }
    }
}
