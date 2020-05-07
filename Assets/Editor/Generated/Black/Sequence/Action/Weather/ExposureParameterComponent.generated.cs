using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class ExposureParameterComponent : Black.Sequence.Action.Weather.ParameterComponentBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int category_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ExposureParameterComponent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.ExposureParameterComponent", 0, Black.Sequence.Action.Weather.ExposureParameterComponent.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.ExposureParameterComponent", base.GetFieldProperties(), -111571852, -619954316);
            return fieldProperties;
        }

		
    }
}