using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetVWVignette : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public bool enableWeather_;
		public float amount_;
		public float yScale_;
		public float cornerAttenuation_;
		public float corner_r_;
		public float corner_g_;
		public float corner_b_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin yScale_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cornerAttenuation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin corner_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin corner_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin corner_b_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVWVignette();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetVWVignette", 0, Black.Sequence.ScreenEffect.SequenceActionSetVWVignette.ObjectType, null, properties, 0, 1016);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetVWVignette", base.GetFieldProperties(), 953834213, 839510471);
            
			
			
			return fieldProperties;
        }

		
    }
}