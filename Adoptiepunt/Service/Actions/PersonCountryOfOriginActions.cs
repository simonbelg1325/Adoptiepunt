﻿using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class PersonCountryOfOrigin
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int CountryOfOriginId { get; set; }

        public virtual Person Person { get; set; }
        public virtual CountryOfOrigin CountryOfOrigin { get; set; }
    }

    public class PersonCountryOfOriginActions : PersistentObjectActionsReference<AdoptiepuntContext, PersonCountryOfOrigin>
    {
        public PersonCountryOfOriginActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
