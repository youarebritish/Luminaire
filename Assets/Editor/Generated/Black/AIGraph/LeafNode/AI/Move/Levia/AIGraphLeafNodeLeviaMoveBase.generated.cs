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
            
			
			
			return fieldProperties;
        }

		
    }
}