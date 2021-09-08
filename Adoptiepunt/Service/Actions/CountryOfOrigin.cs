using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class CountryOfOrigin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PersonCountryOfOrigin> PersonCountryOfOrigins { get; set; }
    }

    public class CountryOfOriginActions : PersistentObjectActionsReference<AdoptiepuntContext, CountryOfOrigin>
    {
        public CountryOfOriginActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
