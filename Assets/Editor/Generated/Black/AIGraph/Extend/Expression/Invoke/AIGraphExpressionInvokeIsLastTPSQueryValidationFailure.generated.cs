using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke
{
    public partial class AIGraphExpressionInvokeIsLastTPSQueryValidationFailure : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeIsLastTPSQueryValidationFailure();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.AIGraphExpressionInvokeIsLastTPSQueryValidationFailure", 0, Black.AIGraph.Extend.Expression.Invoke.AIGraphExpressionInvokeIsLastTPSQueryValidationFailure.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.AIGraphExpressionInvokeIsLastTPSQueryValidationFailure", base.GetFieldProperties(), -545535685, 2044117980);
            return fieldProperties;
        }

		
    }
}