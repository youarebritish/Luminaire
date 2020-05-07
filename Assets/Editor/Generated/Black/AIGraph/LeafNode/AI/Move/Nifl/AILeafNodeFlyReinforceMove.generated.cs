using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Nifl
{
    public partial class AILeafNodeFlyReinforceMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat goalHeightOffset_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat goalOffsetHorizonal_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat destinationUpdateTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool forceUseReinforceDestination_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool noUpdateReinfoceDestination_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid queryFixid_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat descendingPointLockDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat destinationRefreshTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat destinationRefreshDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt combatEnemiesObservationModeCount_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool ignoreObservationMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFlyReinforceMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyReinforceMove", 0, Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyReinforceMove.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyReinforceMove", base.GetFieldProperties(), 247789990, -1131115834);
            
			fieldProperties.AddProperty(new Property("goalHeightOffset_", 2639828727, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 568, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("goalOffsetHorizonal_", 1465071618, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 600, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("destinationUpdateTime_", 3239339432, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 632, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceUseReinforceDestination_", 2599091349, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 664, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noUpdateReinfoceDestination_", 787242323, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 696, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("queryFixid_", 264473220, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 728, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("descendingPointLockDistance_", 1466274648, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 760, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("destinationRefreshTime_", 2947351604, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 792, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("destinationRefreshDistance_", 641800514, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 824, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("combatEnemiesObservationModeCount_", 2954933688, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 856, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignoreObservationMode_", 1763367721, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 888, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}