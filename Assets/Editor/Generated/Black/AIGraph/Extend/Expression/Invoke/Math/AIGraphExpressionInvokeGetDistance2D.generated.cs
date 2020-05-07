using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke.Math
{
    public partial class AIGraphExpressionInvokeGetDistance2D : Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeTargetSlotArgsBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeGetDistance2D();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeGetDistance2D", 0, Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeGetDistance2D.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.Math.AIGraphExpressionInvokeGetDistance2D", base.GetFieldProperties(), -1228829058, -14548109);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}