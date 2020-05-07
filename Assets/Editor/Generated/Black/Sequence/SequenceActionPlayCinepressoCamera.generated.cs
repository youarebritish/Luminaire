using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence
{
    public partial class SequenceActionPlayCinepressoCamera : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin seamlessPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin yawAnglePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pitchAnglePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fovLevelPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shotSizePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin subjectSubPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin subjectMainPin_;
		public int shotType_;
		public int shotSize_;
		public int fovLevel_;
		public int pitchAngle_;
		public int yawAngle_;
		public int offsetPan_;
		public int offsetTilt_;
		public int offsetRoll_;
		public int subjectSide_;
		public bool seamless_;
		public bool enableFollowPan_;
		public bool enableFollowTrack_;
		public bool enableAnimation_;
		public int animPan_;
		public int animTilt_;
		public int animAroundH_;
		public int animAroundV_;
		public int animTrack_;
		public int animBoom_;
		public int animDolly_;
		public int animZoom_;
		public float animationLength_;
		public int easeStart_;
		public int easeEnd_;
		public Black.Camera.Struct.CameraControlTurn controlTurn_;
		public bool isCheckCollision_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayCinepressoCamera();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.SequenceActionPlayCinepressoCamera", 0, Black.Sequence.SequenceActionPlayCinepressoCamera.ObjectType, null, properties, 0, 1440);
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

            fieldProperties = new PropertyContainer("Black.Sequence.SequenceActionPlayCinepressoCamera", base.GetFieldProperties(), 1872084990, -1145470894);
            return fieldProperties;
        }

		
    }
}