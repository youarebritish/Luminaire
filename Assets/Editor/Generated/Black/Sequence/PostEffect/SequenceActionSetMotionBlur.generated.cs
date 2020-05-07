using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.PostEffect
{
    public partial class SequenceActionSetMotionBlur : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public bool useRef_;
		public bool enableDynamicParams_;
		public float shutterAngle_;
		public float shutterAngleDynamic_;
		public float cameraMotionStrength_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shutterAngle_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shutterAngleDynamic_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraMotionStrength_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useRef_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enableDynamicParams_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetMotionBlur();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetMotionBlur", 0, Black.Sequence.PostEffect.SequenceActionSetMotionBlur.ObjectType, null, properties, 0, 912);
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

            fieldProperties = new PropertyContainer("Black.Sequence.PostEffect.SequenceActionSetMotionBlur", base.GetFieldProperties(), -725579449, 1138465563);
            return fieldProperties;
        }

		
    }
}