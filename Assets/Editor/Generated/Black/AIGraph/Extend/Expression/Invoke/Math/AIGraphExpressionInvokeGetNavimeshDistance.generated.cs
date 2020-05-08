using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke.Math
{
    public partial class AIGraphExpressionInvokeGetNavimeshDistance : Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeTargetSlotArgsBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeGetNavimeshDistance();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeGetNavimeshDistance", 0, Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeGetNavimeshDistance.ObjectType, Construct, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeGetNavimeshDistance", base.GetFieldProperties(), 503732574, -190869106);
            
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphExpressionInvokeGetNavimeshDistance();
        }
		
    }
}