using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke.Enemy
{
    public partial class AIGraphExpressionInvokeIsEnemyPartsOnGround : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeIsEnemyPartsOnGround();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.Enemy.AIGraphExpressionInvokeIsEnemyPartsOnGround", 0, Black.AIGraph.Extend.Expression.Invoke.Enemy.AIGraphExpressionInvokeIsEnemyPartsOnGround.ObjectType, Construct, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.Enemy.AIGraphExpressionInvokeIsEnemyPartsOnGround", base.GetFieldProperties(), -419164251, 277917568);
            
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphExpressionInvokeIsEnemyPartsOnGround();
        }
		
    }
}