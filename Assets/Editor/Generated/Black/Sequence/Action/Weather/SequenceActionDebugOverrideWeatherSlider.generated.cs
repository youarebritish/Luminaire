using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionDebugOverrideWeatherSlider : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reqNext;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reqPrev;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin slideNumber;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inEnd_;
		public float transitionTime_;
		public int weatherIndex;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugOverrideWeatherSlider();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionDebugOverrideWeatherSlider", 0, Black.Sequence.Action.Weather.SequenceActionDebugOverrideWeatherSlider.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionDebugOverrideWeatherSlider", base.GetFieldProperties(), -1111330858, -1615131487);
            
			
			
			return fieldProperties;
        }

		
    }
}