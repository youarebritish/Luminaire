using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke.System
{
    public partial class AIGraphExpressionInvokeGetGameFlag : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeGetGameFlag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.System.AIGraphExpressionInvokeGetGameFlag", 0, Black.AIGraph.Extend.Expression.Invoke.System.AIGraphExpressionInvokeGetGameFlag.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.System.AIGraphExpressionInvokeGetGameFlag", base.GetFieldProperties(), -1412135698, 1581157331);
            
			
			
			return fieldProperties;
        }

		
    }
}