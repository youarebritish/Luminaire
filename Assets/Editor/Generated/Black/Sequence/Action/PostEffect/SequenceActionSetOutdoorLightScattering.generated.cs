using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.PostEffect
{
    public partial class SequenceActionSetOutdoorLightScattering : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public float rayleigh_;
		public UnityEngine.Color rayleighColor_;
		public float mie_;
		public UnityEngine.Color mieColor_;
		public float g_;
		public float sunIntensity_;
		public UnityEngine.Color sunColor_;
		public float sunDirectionUpDown_;
		public float sunDirectionRotation_;
		public float inScale_;
		public float outScale_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetOutdoorLightScattering();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.PostEffect.SequenceActionSetOutdoorLightScattering", 0, Black.Sequence.Action.PostEffect.SequenceActionSetOutdoorLightScattering.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.PostEffect.SequenceActionSetOutdoorLightScattering", base.GetFieldProperties(), 1736632942, -727044626);
            
			
			
			return fieldProperties;
        }

		
    }
}