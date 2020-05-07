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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inBaseActor_", 3689150629, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inBasePosition_", 904266717, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inBaseRotate_", 695880733, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("baseSearchRange_", 279165762, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("baseOffsetLength_", 14236532, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("searchLaneType_", 187893044, "Black.Sequence.Action.Vehicle.SequenceActionSearchCurve.LaneType", 544, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSameDirection_", 3401669793, "bool", 548, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCurveSearchDetail_", 859127250, "bool", 549, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("inBaseOffsetLength_", 3352554729, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("limitSearchRange_", 1230274054, "float", 640, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableBackwardSearch_", 23044980, "bool", 644, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isIgnoreUserSearchCurveAttr_", 1370341933, "bool", 645, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignoreParkingCurve_", 1060684149, "bool", 646, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("limitIntersectionLength_", 1935093266, "float", 648, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("limitRangeFromInvalidPassingCurve_", 3953882471, "float", 652, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxFrontOffset_", 1125784863, "float", 656, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxBackwardOffset_", 753438433, "float", 660, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxWidth_", 26435171, "float", 664, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("disallowBoxOverOppsiteLane_", 1636779414, "bool", 668, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCurveDirXZ_", 3280832402, "bool", 669, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("success_", 867838301, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 672, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("failure_", 3824596522, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 768, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("failureForCondition_", 1700619818, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 864, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("curvePos_", 3538277075, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 960, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("curveRot_", 3476768642, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("curveDir_", 2284042044, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1136, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("curveRight_", 3558259779, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("roadWidth_", 3806788582, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("basePosLane_", 4219531701, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isTunnelFlag_", 3505283922, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}