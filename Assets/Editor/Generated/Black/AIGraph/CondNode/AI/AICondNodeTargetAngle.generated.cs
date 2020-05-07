using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.CondNode.AI
{
    public partial class AICondNodeTargetAngle : SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorCondition
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum compareType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum dir4Type_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum dirLRType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool Not_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AICondNodeTargetAngle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.CondNode.AI.AICondNodeTargetAngle", 0, Black.AIGraph.CondNode.AI.AICondNodeTargetAngle.ObjectType, null, properties, 0, 504);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.CondNode.AI.AICondNodeTargetAngle", base.GetFieldProperties(), 2083356863, -1108957010);
            
			
			
			return fieldProperties;
        }

		
    }
}