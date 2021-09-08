using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class InvitationPurpose
    {
        [Key]
        public int Id { get; set; }
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
