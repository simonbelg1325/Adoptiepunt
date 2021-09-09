﻿namespace Adoptiepunt.Service.Actions
{
    public class PersonCategory : EntityBase
    {
        public int CategoryId { get; set; }
        public int PersonId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Person Person { get; set; }
    }

    public class PersonCategoryActions : PersistentObjectActionsReference<AdoptiepuntContext, PersonCategory>
    {
        public PersonCategoryActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
