using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecLeviaModeGoTo : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actionTypeIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPointIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin homingOffsetRotationIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin bodyMessageIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin angularVelocityYawIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin angularVelocityPitchIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin movingHeightOffsetIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moveSpeedMinIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moveSpeedMaxIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin distanceThresholdRelayIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin relayBezierDistanceRateIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin relayDistanceRateIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tangentLengthOfBezierCurveIPin_;
		public int actionType_;
		public uint bodyMessage_;
		public bool isResetMoveSpeed_;
		public bool notInverseTurn_;
		public float angularVelocityYaw_;
		public float angularVelocityPitch_;
		public float movingHeightOffset_;
		public float distanceThresholdRelay_;
		public float relayBezierDistanceRate_;
		public float relayDistanceRate_;
		public float tangentLengthOfBezierCurve_;
		public float timeOut_;
		public bool isHomingMode_;
		public UnityEngine.Vector4 homingOffsetRotation_;
		public bool isOverwriteMovement_;
		public float moveSpeedMin_;
		public float moveSpeedMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecLeviaModeGoTo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaModeGoTo", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaModeGoTo.ObjectType, null, properties, 0, 2560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaModeGoTo", base.GetFieldProperties(), 1896495122, 1906994913);
            
			fieldProperties.AddProperty(new Property("actionTypeIPin_", 2818250, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetPointIPin_", 2939402113, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("homingOffsetRotationIPin_", 1538591083, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bodyMessageIPin_", 1215298339, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("angularVelocityYawIPin_", 1961568216, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1576, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("angularVelocityPitchIPin_", 237528411, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("movingHeightOffsetIPin_", 2787794710, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1752, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveSpeedMinIPin_", 3876374848, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1840, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveSpeedMaxIPin_", 1154458490, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1928, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distanceThresholdRelayIPin_", 1192799829, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2016, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("relayBezierDistanceRateIPin_", 2191125479, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2104, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("relayDistanceRateIPin_", 1018763078, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2192, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("tangentLengthOfBezierCurveIPin_", 17362082, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actionType_", 3416588776, "int", 2368, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("bodyMessage_", 2871992657, "SQEX.Ebony.Std.Fixid", 2372, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetMoveSpeed_", 3950738965, "bool", 2376, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("notInverseTurn_", 3035104650, "bool", 2377, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("angularVelocityYaw_", 2615577818, "float", 2380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("angularVelocityPitch_", 4159639577, "float", 2384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("movingHeightOffset_", 953172476, "float", 2388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("distanceThresholdRelay_", 4226670367, "float", 2392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("relayBezierDistanceRate_", 2746749901, "float", 2396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("relayDistanceRate_", 1452941900, "float", 2400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tangentLengthOfBezierCurve_", 3511573776, "float", 2404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeOut_", 3487830293, "float", 2408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isHomingMode_", 3506369307, "bool", 2412, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("homingOffsetRotation_", 3033060937, "Luminous.Math.VectorA", 2416, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("isOverwriteMovement_", 3242978740, "bool", 2432, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveSpeedMin_", 1930294194, "float", 2436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveSpeedMax_", 1283190456, "float", 2440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}