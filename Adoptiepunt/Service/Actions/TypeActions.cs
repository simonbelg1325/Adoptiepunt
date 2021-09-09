using System.Collections.Generic;

namespace Adoptiepunt.Service.Actions
{
    public class Type : EntityBase
    {
        public string Description { get; set; }
        public virtual ICollection<RegistrationTag> RegistrationTags { get; set; }
    }

    public class TypeActions : PersistentObjectActionsReference<AdoptiepuntContext, Type>
    {
        public TypeActions(AdoptiepuntContext context) : base(context) { }
    }
}
