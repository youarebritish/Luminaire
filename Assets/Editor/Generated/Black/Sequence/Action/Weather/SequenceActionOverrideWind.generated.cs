using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionOverrideWind : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inEnd_;
		public bool overrideCloudWind_;
		public float cloudWindDirection_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cloudWindDirectionPin_;
		public float cloudWindSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cloudWindSpeedPin_;
		public float windMultiplier_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin windMultiplierPin_;
		public float speedMultiplier_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin speedMultiplierPin_;
		public float windDirection_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin windDirectionPin_;
		public float transitionTime_;
		public bool endOverrideOnUnloded_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionOverrideWind();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionOverrideWind", 0, Black.Sequence.Action.Weather.SequenceActionOverrideWind.ObjectType, null, properties, 0, 856);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionOverrideWind", base.GetFieldProperties(), -650943787, 431228295);
            return fieldProperties;
        }

		
    }
}