using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.CondNode.AI
{
    public partial class AICondNodeCheckGlideLanding : SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorCondition
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AICondNodeCheckGlideLanding();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.CondNode.AI.AICondNodeCheckGlideLanding", 0, Black.AIGraph.CondNode.AI.AICondNodeCheckGlideLanding.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.CondNode.AI.AICondNodeCheckGlideLanding", base.GetFieldProperties(), -1840980939, -1910603433);
            return fieldProperties;
        }

		
    }
}