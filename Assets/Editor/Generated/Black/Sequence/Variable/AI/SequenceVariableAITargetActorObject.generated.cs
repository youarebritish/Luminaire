using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.AI
{
    public partial class SequenceVariableAITargetActorObject : Black.Sequence.Actor.SequenceVariableActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int targetSlot_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outActor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableAITargetActorObject();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.AI.SequenceVariableAITargetActorObject", 0, Black.Sequence.Variable.AI.SequenceVariableAITargetActorObject.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.AI.SequenceVariableAITargetActorObject", base.GetFieldProperties(), 917336394, -901309237);
            
			
			
			return fieldProperties;
        }

		
    }
}