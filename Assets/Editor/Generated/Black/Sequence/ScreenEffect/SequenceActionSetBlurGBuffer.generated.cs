using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetBlurGBuffer : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public float normalBlur_;
		public float roughnessBoost_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_enabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_normalBlur_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_roughnessBoost_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBlurGBuffer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetBlurGBuffer", 0, Black.Sequence.ScreenEffect.SequenceActionSetBlurGBuffer.ObjectType, null, properties, 0, 648);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetBlurGBuffer", base.GetFieldProperties(), 1764341121, 1896623955);
            return fieldProperties;
        }

		
    }
}