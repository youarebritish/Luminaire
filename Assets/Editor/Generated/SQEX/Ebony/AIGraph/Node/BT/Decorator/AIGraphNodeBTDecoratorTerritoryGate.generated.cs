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
            return fieldProperties;
        }

		
    }
}