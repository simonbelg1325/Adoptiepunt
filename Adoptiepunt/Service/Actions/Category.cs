using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
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


