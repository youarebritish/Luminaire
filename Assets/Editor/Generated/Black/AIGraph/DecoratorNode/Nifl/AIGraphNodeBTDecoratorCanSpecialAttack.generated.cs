using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.DecoratorNode.Nifl
{
    public partial class AIGraphNodeBTDecoratorCanSpecialAttack : SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTDecoratorCanSpecialAttack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.DecoratorNode.Nifl.AIGraphNodeBTDecoratorCanSpecialAttack", 0, Black.AIGraph.DecoratorNode.Nifl.AIGraphNodeBTDecoratorCanSpecialAttack.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.DecoratorNode.Nifl.AIGraphNodeBTDecoratorCanSpecialAttack", base.GetFieldProperties(), -502160621, -417598771);
            return fieldProperties;
        }

		
    }
}