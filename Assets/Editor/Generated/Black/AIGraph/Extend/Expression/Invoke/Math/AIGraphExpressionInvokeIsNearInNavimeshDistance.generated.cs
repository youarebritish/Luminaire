using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke.Math
{
    public partial class AIGraphExpressionInvokeIsNearInNavimeshDistance : Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeTargetSlotArgsBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeIsNearInNavimeshDistance();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeIsNearInNavimeshDistance", 0, Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeIsNearInNavimeshDistance.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeIsNearInNavimeshDistance", base.GetFieldProperties(), -57358056, 391573235);
            return fieldProperties;
        }

		
    }
}