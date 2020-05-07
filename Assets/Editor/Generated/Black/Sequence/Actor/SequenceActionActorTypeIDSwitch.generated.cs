using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorTypeIDSwitch : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPlayer_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outEnemy_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outNpc_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOther_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueActor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorTypeIDSwitch();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorTypeIDSwitch", 0, Black.Sequence.Actor.SequenceActionActorTypeIDSwitch.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorTypeIDSwitch", base.GetFieldProperties(), 482617509, -1417446678);
            
			
			
			return fieldProperties;
        }

		
    }
}