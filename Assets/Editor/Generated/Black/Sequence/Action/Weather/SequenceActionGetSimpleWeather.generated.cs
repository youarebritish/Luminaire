using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionGetSimpleWeather : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public int weatherType_;
		public float cloudCoverageThreshold_;
		public float rainParticleEmitRateThreshold_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin true_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin false_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changedToTrue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changedToFalse_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetSimpleWeather();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionGetSimpleWeather", 0, Black.Sequence.Action.Weather.SequenceActionGetSimpleWeather.ObjectType, null, properties, 0, 680);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionGetSimpleWeather", base.GetFieldProperties(), -779167149, 1635705280);
            return fieldProperties;
        }

		
    }
}