using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetSpecularLightProbeEntity : Black.Sequence.Actor.SequenceActionEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin power_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSpecularLightProbeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetSpecularLightProbeEntity", 0, Black.Sequence.Action.Render.SequenceActionSetSpecularLightProbeEntity.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetSpecularLightProbeEntity", base.GetFieldProperties(), 1218876072, 1409283760);
            
			
			
			return fieldProperties;
        }

		
    }
}