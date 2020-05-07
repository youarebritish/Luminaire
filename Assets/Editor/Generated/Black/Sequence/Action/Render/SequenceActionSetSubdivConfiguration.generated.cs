using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetSubdivConfiguration : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float tessellationFactor_;
		public float displacementScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tessellationFactor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin displacementScale_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSubdivConfiguration();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetSubdivConfiguration", 0, Black.Sequence.Action.Render.SequenceActionSetSubdivConfiguration.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetSubdivConfiguration", base.GetFieldProperties(), -937630141, 973175560);
            
			
			
			return fieldProperties;
        }

		
    }
}