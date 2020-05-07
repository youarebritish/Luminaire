using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Status
{
    public partial class SequenceActionActorGetJobPoint : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int checkAbilityPoint_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin int_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin exist_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notExist_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetJobPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Status.SequenceActionActorGetJobPoint", 0, Black.Sequence.Action.Actor.Status.SequenceActionActorGetJobPoint.ObjectType, null, properties, 0, 784);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Status.SequenceActionActorGetJobPoint", base.GetFieldProperties(), 1014714196, 2084131621);
            return fieldProperties;
        }

		
    }
}