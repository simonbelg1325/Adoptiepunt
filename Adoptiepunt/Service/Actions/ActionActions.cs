using System;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class Action
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int RegistrationId { get; set; }
        public virtual Registration Registration { get; set; }

    }

    public class ActionActions : PersistentObjectActionsReference<AdoptiepuntContext, Action>
    {
        public ActionActions(AdoptiepuntContext context) : base(context) { }
    }
}
