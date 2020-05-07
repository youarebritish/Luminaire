using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionSetExposure : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public bool isEnabled_;
		public bool enableWeather_;
		public float exposure_;
		public bool enableAutoExposure_;
		public float autoExposureUp_;
		public float autoExposureDown_;
		public float autoExposureBase_;
		public bool useRelativeValueForMeasureMinMax_;
		public float autoExposureMin_;
		public float autoExposureMax_;
		public float autoExposureSpeedUp_;
		public float autoExposureSpeedDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin refreshframe_pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin restoreframe_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin isEnabledPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enableAutoExposurePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin autoexposurebase_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin autoexposuredown_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin autoexposureup_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin exposure_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetExposure();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionSetExposure", 0, Black.Sequence.Render.SequenceActionSetExposure.ObjectType, null, properties, 0, 1040);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionSetExposure", base.GetFieldProperties(), 315990, -163526350);
            
			
			
			return fieldProperties;
        }

		
    }
}