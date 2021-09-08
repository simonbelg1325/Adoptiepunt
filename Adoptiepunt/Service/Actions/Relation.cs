using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class Relation
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<RelationType> RelationTypes { get; set; }
    }

    public class RelationActions : PersistentObjectActionsReference<AdoptiepuntContext, Relation>
    {
        public RelationActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
