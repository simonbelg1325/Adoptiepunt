using System.Collections.Generic;

namespace Adoptiepunt.Service.Actions
{
    public class ContactVia : EntityBase
    {
        public string Description { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }

    public class ContactViaActions : PersistentObjectActionsReference<AdoptiepuntContext, ContactVia>
    {
        public ContactViaActions(AdoptiepuntContext context) : base(context) { }
    }
}
