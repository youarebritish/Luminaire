using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionCameraAngleCrossDirection : Black.Sequence.Action.Angle.SequenceActionCameraAngleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin calcPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin clearPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin preOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin leftOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rightOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1NearOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1FarOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1NearRightOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1NearLeftOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1FarRightOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1FarLeftOutPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor2Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorsDirectionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin crossDirectionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isRightPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin nearActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin farActorPin_;
		public bool isUseBasePC_;
		public bool isUseTargetPCTarget_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraAngleCrossDirection();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionCameraAngleCrossDirection", 0, Black.Sequence.Action.Angle.SequenceActionCameraAngleCrossDirection.ObjectType, null, properties, 0, 3280);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionCameraAngleCrossDirection", base.GetFieldProperties(), -428476733, 1967878863);
            return fieldProperties;
        }

		
    }
}