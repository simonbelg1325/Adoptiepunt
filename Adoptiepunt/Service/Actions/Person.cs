using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public int RelationId { get; set; }

        public bool Anonymously { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Name { get; set; }

        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string Note { get; set; }
        public virtual Relation Relation { get; set; }
        public virtual ICollection<PersonCategory> PersonCategories { get; set; }
        public virtual ICollection<PersonCountryOfOrigin> PersonCountryOfOrigins { get; set; }
        public virtual ICollection<PersonInvitationPurpose> PersonInvitationPurposes { get; set; }
    }

    public class PersonActions : PersistentObjectActionsReference<AdoptiepuntContext, Person>
    {
        public PersonActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
