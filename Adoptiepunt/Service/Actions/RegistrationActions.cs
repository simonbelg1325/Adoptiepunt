using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class Registration : EntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Owner { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public int ContactViaId { get; set; }
        public virtual ContactVia ContactVia { get; set; }
        public int TypeId { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<RegistrationTag> RegistrationTags { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

    }

    public class RegistrationActions : PersistentObjectActionsReference<AdoptiepuntContext, Registration>
    {
        public RegistrationActions(AdoptiepuntContext context) : base(context) { }
    }
}
