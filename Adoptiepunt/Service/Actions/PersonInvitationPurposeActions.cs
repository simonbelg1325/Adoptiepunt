namespace Adoptiepunt.Service.Actions
{
    public class PersonInvitationPurpose : EntityBase
    {
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int InvitationPurposeId { get; set; }
        public virtual InvitationPurpose InvitationPurpose { get; set; }
    }

    public class PersonInvitationPurposeActions : PersistentObjectActionsReference<AdoptiepuntContext, PersonInvitationPurpose>
    {
        public PersonInvitationPurposeActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
