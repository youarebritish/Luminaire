using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionOverrideExposure : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inEnd_;
		public float exposure_;
		public bool enableAutoExposure_;
		public float autoExposureUp_;
		public float autoExposureDown_;
		public float autoExposureBrightness_;
		public float autoExposureSpeedUp_;
		public float autoExposureSpeedDown_;
		public float transitionTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionOverrideExposure();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionOverrideExposure", 0, Black.Sequence.Action.Weather.SequenceActionOverrideExposure.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionOverrideExposure", base.GetFieldProperties(), 1643185255, -687313045);
            
			
			
			return fieldProperties;
        }

		
    }
}