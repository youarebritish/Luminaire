using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorSetWireHookEnable : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enablePin_;
		public bool enable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetWireHookEnable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorSetWireHookEnable", 0, Black.Sequence.Action.Actor.SequenceActionActorSetWireHookEnable.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorSetWireHookEnable", base.GetFieldProperties(), 322433684, 499386725);
            return fieldProperties;
        }

		
    }
}