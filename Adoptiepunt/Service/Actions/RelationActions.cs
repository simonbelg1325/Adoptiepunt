﻿using System.ComponentModel.DataAnnotations;

namespace Adoptiepunt.Service.Actions
{
    public class Relation
    {
        [Key]
        public int Id { get; set; }
        public int ParentPersonId { get; set; }
        public int ChildPersonId { get; set; }
        public virtual Person Person { get; set; }
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
