using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class Action
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }

    }

    public class ActionActions : PersistentObjectActionsReference<AdoptiepuntContext, Action>
    {
        public ActionActions(AdoptiepuntContext context) : base(context) { }
    }
}
