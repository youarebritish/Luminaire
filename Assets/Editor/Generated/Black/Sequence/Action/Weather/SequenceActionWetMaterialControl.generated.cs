using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionWetMaterialControl : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public bool enableWeather_;
		public float depthMapCullSize_;
		public float wetnessScale_;
		public float wetSpeedScale_;
		public float drySpeedScale_;
		public float surfaceWetOffset_;
		public float crackWetOffset_;
		public float wetFadeStart_;
		public float wetFadeEnd_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionWetMaterialControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionWetMaterialControl", 0, Black.Sequence.Action.Weather.SequenceActionWetMaterialControl.ObjectType, null, properties, 0, 504);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionWetMaterialControl", base.GetFieldProperties(), 64200845, 315845610);
            return fieldProperties;
        }

		
    }
}