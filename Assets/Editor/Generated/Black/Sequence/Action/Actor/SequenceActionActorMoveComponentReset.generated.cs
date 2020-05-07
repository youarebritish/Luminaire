using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorMoveComponentReset : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorMoveComponentReset();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorMoveComponentReset", 0, Black.Sequence.Action.Actor.SequenceActionActorMoveComponentReset.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorMoveComponentReset", base.GetFieldProperties(), 2056138805, -1644646272);
            return fieldProperties;
        }

		
    }
}