using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.DecoratorNode.Nifl
{
    public partial class AIGraphNodeBTDecoratorCanShootWire : SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTDecoratorCanShootWire();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.DecoratorNode.Nifl.AIGraphNodeBTDecoratorCanShootWire", 0, Black.AIGraph.DecoratorNode.Nifl.AIGraphNodeBTDecoratorCanShootWire.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.DecoratorNode.Nifl.AIGraphNodeBTDecoratorCanShootWire", base.GetFieldProperties(), -204456453, 1560551489);
            return fieldProperties;
        }

		
    }
}