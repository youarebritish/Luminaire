using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionCameraBattleMultiTargetInfo : Black.Sequence.Action.Angle.SequenceActionCameraAngleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin judgePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin clearPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fovPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin heightPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin radiusPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin centerPosPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin heightOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin distancePin_;
		public int autoCompositionBaseType_;
		public float fovDegree_;
		public float marginDistance_;
		public float minDistance_;
		public float maxDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraBattleMultiTargetInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionCameraBattleMultiTargetInfo", 0, Black.Sequence.Action.Angle.SequenceActionCameraBattleMultiTargetInfo.ObjectType, null, properties, 0, 2096);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionCameraBattleMultiTargetInfo", base.GetFieldProperties(), -34829617, -649240472);
            return fieldProperties;
        }

		
    }
}