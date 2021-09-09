using System.Collections.Generic;

namespace Adoptiepunt.Service.Actions
{
    public class Tag : EntityBase
    {
        public string Description { get; set; }
        public virtual ICollection<RegistrationTag> RegistrationTags { get; set; }
    }

    public class TagActions : PersistentObjectActionsReference<AdoptiepuntContext, Tag>
    {
        public TagActions(AdoptiepuntContext context) : base(context) { }
    }
}
