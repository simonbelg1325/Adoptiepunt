﻿using System.Collections.Generic;

namespace Adoptiepunt.Service.Actions
{
    public class CountryOfOrigin : EntityBase
    {
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
