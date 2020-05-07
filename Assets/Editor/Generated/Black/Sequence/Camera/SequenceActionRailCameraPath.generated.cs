using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Camera
{
    public partial class SequenceActionRailCameraPath : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int usageType_;
		public SQEX.Ebony.Framework.Entity.EntityGroup entityPointer_;
		public float pathMovePrecision_;
		public float pathMoveSafeDistanceFactor_;
		public float forwardDistance_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin nextPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin directionPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionRailCameraPath();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Camera.SequenceActionRailCameraPath", 0, Black.Sequence.Camera.SequenceActionRailCameraPath.ObjectType, null, properties, 0, 1040);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Camera.SequenceActionRailCameraPath", base.GetFieldProperties(), -1130546026, 402737076);
            return fieldProperties;
        }

		
    }
}