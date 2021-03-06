namespace Adoptiepunt.Service.Actions
{
    public class Relation : EntityBase
    {
        public int ParentPersonId { get; set; }
        public virtual Person ParentPerson { get; set; }
        public int ChildPersonId { get; set; }
        public virtual Person ChildPerson { get; set; }
        public int RelationTypeId { get; set; }
        public virtual RelationType RelationType { get; set; }
    }

    public class RelationActions : PersistentObjectActionsReference<AdoptiepuntContext, Relation>
    {
        public RelationActions(AdoptiepuntContext context) : base(context)
        {
        }
    }
}
