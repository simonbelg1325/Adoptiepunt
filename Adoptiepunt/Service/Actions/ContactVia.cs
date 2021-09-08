using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class ContactVia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }

    public class ContactViaActions : PersistentObjectActionsReference<AdoptiepuntContext, ContactVia>
    {
        public ContactViaActions(AdoptiepuntContext context) : base(context) { }
    }
}
