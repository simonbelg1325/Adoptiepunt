using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class RelationType
    {
        [Key]
        public int Id { get; set; }

        public int RelationId { get; set; }
        public string Description { get; set; }
        public virtual Relation Relation { get; set; }
    }


    public class RelationTypeActions : PersistentObjectActionsReference<AdoptiepuntContext, RelationType>
    {
        public RelationTypeActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
