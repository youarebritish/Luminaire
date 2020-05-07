using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke.Buddy
{
    public partial class AIGraphExpressionInvokeHasAccessory : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeHasAccessory();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.Buddy.AIGraphExpressionInvokeHasAccessory", 0, Black.AIGraph.Extend.Expression.Invoke.Buddy.AIGraphExpressionInvokeHasAccessory.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.Buddy.AIGraphExpressionInvokeHasAccessory", base.GetFieldProperties(), -755617264, -1749287531);
            
			
			
			return fieldProperties;
        }

		
    }
}