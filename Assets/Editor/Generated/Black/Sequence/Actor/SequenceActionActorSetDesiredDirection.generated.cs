using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorSetDesiredDirection : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin focusActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin yawPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tiltPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetDesiredDirection();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorSetDesiredDirection", 0, Black.Sequence.Actor.SequenceActionActorSetDesiredDirection.ObjectType, null, properties, 0, 744);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorSetDesiredDirection", base.GetFieldProperties(), -1093630138, -449649323);
            return fieldProperties;
        }

		
    }
}