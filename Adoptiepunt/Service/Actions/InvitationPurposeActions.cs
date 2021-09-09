using System.Collections.Generic;

namespace Adoptiepunt.Service.Actions
{
    public class InvitationPurpose : EntityBase
    {
        public string Description { get; set; }
        public virtual ICollection<PersonInvitationPurpose> PersonInvitationPurposes { get; set; }
    }

    public class InvitationPurposeActions : PersistentObjectActionsReference<AdoptiepuntContext, InvitationPurpose>
    {
        public InvitationPurposeActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
