using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Expression.Invoke
{
    public partial class AIGraphExpressionInvokeAbsoluteValue : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeAbsoluteValue();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeAbsoluteValue", 0, SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeAbsoluteValue.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeAbsoluteValue", base.GetFieldProperties(), 146678547, 975331913);
            
			
			
			return fieldProperties;
        }

		
    }
}