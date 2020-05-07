using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Decorator
{
    public partial class AIGraphNodeBTDecoratorBase : SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTControlBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTDecoratorBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorBase", 0, SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorBase.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorBase", base.GetFieldProperties(), -861491124, -190445394);
            
			
			
			return fieldProperties;
        }

		
    }
}