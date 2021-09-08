using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class PersonInvitationPurpose
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int InvitationPurposeId { get; set; }
        public virtual Person Person { get; set; }
        public virtual InvitationPurpose InvitationPurpose { get; set; }
    }

    public class PersonInvitationPurposeActions : PersistentObjectActionsReference<AdoptiepuntContext, PersonInvitationPurpose>
    {
        public PersonInvitationPurposeActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
