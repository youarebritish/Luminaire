using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Levia
{
    public partial class AIGraphLeafNodeLeviaMoveBase : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isResetMoveSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat startMoveSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool rayCastEnable_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool inverseTurnFailed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat angularVelocityYaw_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat angularVelocityPitch_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat distanceThresholdRelay_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat relayBezierDistanceRate_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat relayDistanceRate_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat tangentLengthOfBezierCurve_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isRandomAim_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeLeviaMoveBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveBase", 0, Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveBase.ObjectType, null, properties, 0, 1016);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveBase", base.GetFieldProperties(), -1441237939, -869668761);
            
			fieldProperties.AddProperty(new Property("moveSpeed_", 113149984, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 568, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetMoveSpeed_", 3950738965, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 600, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startMoveSpeed_", 2661695330, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 632, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalDistance_", 1191306130, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 664, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rayCastEnable_", 958477568, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 696, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inverseTurnFailed_", 1953375590, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 728, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("angularVelocityYaw_", 2615577818, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 760, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("angularVelocityPitch_", 4159639577, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 792, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distanceThresholdRelay_", 4226670367, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 824, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("relayBezierDistanceRate_", 2746749901, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 856, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("relayDistanceRate_", 1452941900, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 888, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("tangentLengthOfBezierCurve_", 3511573776, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 920, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRandomAim_", 1204717816, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 952, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeOut_", 3487830293, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 984, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}