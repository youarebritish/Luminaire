using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke.Nifl
{
    public partial class AIGraphExpressionInvokeGetAmmoRatio : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeGetAmmoRatio();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.Nifl.AIGraphExpressionInvokeGetAmmoRatio", 0, Black.AIGraph.Extend.Expression.Invoke.Nifl.AIGraphExpressionInvokeGetAmmoRatio.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.Nifl.AIGraphExpressionInvokeGetAmmoRatio", base.GetFieldProperties(), 1546198663, 1371063347);
            
			
			
			return fieldProperties;
        }

		
    }
}