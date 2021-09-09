using System.Collections.Generic;

namespace Adoptiepunt.Service.Actions
{
    public class Category : EntityBase
    {
        public string Description { get; set; }
        public virtual ICollection<PersonCategory> PersonCategories { get; set; }

    }

    public class CategoryActions : PersistentObjectActionsReference<AdoptiepuntContext, Category>
    {
        public CategoryActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}


