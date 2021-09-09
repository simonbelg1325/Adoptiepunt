using System.Collections.Generic;

namespace Adoptiepunt.Service.Actions
{
    public class Person : EntityBase
    {
        public bool Anonymously { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }

        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Note { get; set; }
        public virtual ICollection<Relation> Relations { get; set; }
        public virtual ICollection<PersonCategory> PersonCategories { get; set; }
        public virtual ICollection<PersonCountryOfOrigin> PersonCountryOfOrigins { get; set; }
        public virtual ICollection<PersonInvitationPurpose> PersonInvitationPurposes { get; set; }

        public int RegistrationId { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }

    public class PersonActions : PersistentObjectActionsReference<AdoptiepuntContext, Person>
    {
        public PersonActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
