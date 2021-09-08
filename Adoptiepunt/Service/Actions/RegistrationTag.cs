using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class RegistrationTag
    {
        [Key]
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public int TagId { get; set; }
        public virtual Registration Registration { get; set; }
        public virtual Tag Tag { get; set; }
    }

    public class RegistrationTagActions : PersistentObjectActionsReference<AdoptiepuntContext, RegistrationTag>
    {
        public RegistrationTagActions(AdoptiepuntContext context) : base(context)
        {
        }
    }

}