using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class RelationType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Relation> Relations { get; set; }
    }


    public class RelationTypeActions : PersistentObjectActionsReference<AdoptiepuntContext, RelationType>
    {
        public RelationTypeActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
