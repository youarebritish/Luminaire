using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionSearchCurve : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBaseActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBasePosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBaseRotate_;
		public float baseSearchRange_;
		public float baseOffsetLength_;
		public int searchLaneType_;
		public bool isSameDirection_;
		public bool isCurveSearchDetail_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBaseOffsetLength_;
		public float limitSearchRange_;
		public bool enableBackwardSearch_;
		public bool isIgnoreUserSearchCurveAttr_;
		public bool ignoreParkingCurve_;
		public float limitIntersectionLength_;
		public float limitRangeFromInvalidPassingCurve_;
		public float boxFrontOffset_;
		public float boxBackwardOffset_;
		public float boxWidth_;
		public bool disallowBoxOverOppsiteLane_;
		public bool isCurveDirXZ_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failureForCondition_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin curvePos_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin curveRot_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin curveDir_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin curveRight_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin roadWidth_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin basePosLane_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isTunnelFlag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSearchCurve();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionSearchCurve", 0, Black.Sequence.Action.Vehicle.SequenceActionSearchCurve.ObjectType, null, properties, 0, 1696);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionSearchCurve", base.GetFieldProperties(), -196027678, -1652073502);
            return fieldProperties;
        }

		
    }
}