using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorSortListWithDistance : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin listPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin baseActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin sortedListPin_;
		public bool usePositionY_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSortListWithDistance();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorSortListWithDistance", 0, Black.Sequence.Actor.SequenceActionActorSortListWithDistance.ObjectType, null, properties, 0, 696);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorSortListWithDistance", base.GetFieldProperties(), 411961860, 850386936);
            return fieldProperties;
        }

		
    }
}