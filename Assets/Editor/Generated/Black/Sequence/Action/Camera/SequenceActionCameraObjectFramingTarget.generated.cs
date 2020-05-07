using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionCameraObjectFramingTarget : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin release_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin aggressorPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin victimPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin deadPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin accelPin_;
		public float accel_;
		public float minRadius_;
		public float maxRadius_;
		public int baseActorType_;
		public float validRadiusFromBaseActor_;
		public bool isPCKeep_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraObjectFramingTarget();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionCameraObjectFramingTarget", 0, Black.Sequence.Action.Camera.SequenceActionCameraObjectFramingTarget.ObjectType, null, properties, 0, 864);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionCameraObjectFramingTarget", base.GetFieldProperties(), 488605631, -883895308);
            return fieldProperties;
        }

		
    }
}