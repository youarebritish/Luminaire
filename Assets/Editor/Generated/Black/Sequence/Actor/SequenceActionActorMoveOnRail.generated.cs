using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorMoveOnRail : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin stopped_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinMovingActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinAccel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinInitPos_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinMesh_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinShouldMoveTerrain_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinIdxBaselineCart_;
		public int movementType_;
		public float searchRadius_;
		public float speedKiloMeterPerHour_;
		public float maxAccelKmPerHourPerSec_;
		public bool autoFindNextCurve_;
		public float rollMaxDegree_;
		public float rollScale_;
		public float vibrationMaxX_;
		public float vibrationMaxY_;
		public float vibrationFreq_;
		public float vibrationDuration_;
		public int timerType_;
		public int idxBaselineCart_;
		public bool isDebuggingCurvature_;
		public bool isBogieFittingDisabled_;
		public bool isConnectorAnimDisabled_;
		public bool isRollingDisabled_;
		public bool isVibrationDisabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorMoveOnRail();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorMoveOnRail", 0, Black.Sequence.Actor.SequenceActionActorMoveOnRail.ObjectType, null, properties, 0, 1408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorMoveOnRail", base.GetFieldProperties(), -1524574949, -2111661878);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopped_", 2688852931, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inPinMovingActor_", 3248281857, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inPinSpeed_", 898262685, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inPinAccel_", 3724754420, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inPinInitPos_", 152170980, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 736, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inPinMesh_", 1865915177, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 824, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inPinShouldMoveTerrain_", 4220106477, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 912, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inPinIdxBaselineCart_", 2633836690, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1000, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("movementType_", 406888253, "Black.Sequence.Actor.SequenceActionActorMoveOnRail.TrainMovementType", 1088, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("searchRadius_", 751195416, "float", 1092, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("speedKiloMeterPerHour_", 2887163096, "float", 1096, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxAccelKmPerHourPerSec_", 3975277509, "float", 1100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoFindNextCurve_", 167995288, "bool", 1104, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rollMaxDegree_", 1535865389, "float", 1108, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rollScale_", 3715060793, "float", 1112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vibrationMaxX_", 2381098176, "float", 1116, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vibrationMaxY_", 2380951081, "float", 1120, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vibrationFreq_", 3474710412, "float", 1124, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vibrationDuration_", 843455906, "float", 1128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timerType_", 1026330487, "XPEC.Train.TimerType", 1132, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("idxBaselineCart_", 2411396354, "int", 1136, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("isDebuggingCurvature_", 3148183449, "bool", 1140, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isBogieFittingDisabled_", 3758516713, "bool", 1141, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConnectorAnimDisabled_", 392223246, "bool", 1142, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRollingDisabled_", 3562966207, "bool", 1143, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isVibrationDisabled_", 2015435954, "bool", 1144, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}