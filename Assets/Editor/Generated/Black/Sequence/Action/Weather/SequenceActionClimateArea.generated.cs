using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionClimateArea : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inEnd_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin entity_;
		public bool enabled_;
		public uint climateId_;
		public string weatherKey_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionClimateArea();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionClimateArea", 0, Black.Sequence.Action.Weather.SequenceActionClimateArea.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionClimateArea", base.GetFieldProperties(), 762369215, -1799435774);
            
			
			
			return fieldProperties;
        }

		
    }
}