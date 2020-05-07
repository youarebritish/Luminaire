using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke.Buddy
{
    public partial class AIGraphExpressionInvokeGetElementToleranceWithAbsorption : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeGetElementToleranceWithAbsorption();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.Buddy.AIGraphExpressionInvokeGetElementToleranceWithAbsorption", 0, Black.AIGraph.Extend.Expression.Invoke.Buddy.AIGraphExpressionInvokeGetElementToleranceWithAbsorption.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.Buddy.AIGraphExpressionInvokeGetElementToleranceWithAbsorption", base.GetFieldProperties(), 125968911, -1987366487);
            return fieldProperties;
        }

		
    }
}