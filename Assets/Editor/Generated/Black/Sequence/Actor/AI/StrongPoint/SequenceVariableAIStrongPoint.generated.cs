using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.StrongPoint
{
    public partial class SequenceVariableAIStrongPoint : Black.Sequence.Actor.SequenceVariableLabeledActor
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin radius_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin freeSpace_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableAIStrongPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.StrongPoint.SequenceVariableAIStrongPoint", 0, Black.Sequence.Actor.AI.StrongPoint.SequenceVariableAIStrongPoint.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.StrongPoint.SequenceVariableAIStrongPoint", base.GetFieldProperties(), -674069201, 1698672718);
            
			
			
			return fieldProperties;
        }

		
    }
}