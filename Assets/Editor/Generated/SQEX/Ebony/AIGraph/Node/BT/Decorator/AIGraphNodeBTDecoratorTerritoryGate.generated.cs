using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Decorator
{
    public partial class AIGraphNodeBTDecoratorTerritoryGate : SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isCheckOnTerritory_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeOutOfTerritory_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isCheckTargetOnTerritory_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isCheckTargetOnBattleArea_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTDecoratorTerritoryGate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorTerritoryGate", 0, SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorTerritoryGate.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorTerritoryGate", base.GetFieldProperties(), 713232689, 1021477227);
            
			fieldProperties.AddProperty(new Property("isCheckOnTerritory_", 4160427017, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 200, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeOutOfTerritory_", 805934574, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 232, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCheckTargetOnTerritory_", 2757722308, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 264, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCheckTargetOnBattleArea_", 3836270661, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 296, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetSlotType_", 102733177, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 328, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}