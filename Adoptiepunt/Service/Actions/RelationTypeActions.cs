using System.Collections.Generic;

namespace Adoptiepunt.Service.Actions
{
    public class RelationType : EntityBase
    {
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
