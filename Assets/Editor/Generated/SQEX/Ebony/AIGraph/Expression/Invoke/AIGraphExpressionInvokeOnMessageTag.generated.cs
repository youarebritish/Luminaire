using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Expression.Invoke
{
    public partial class AIGraphExpressionInvokeOnMessageTag : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeOnMessageTag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeOnMessageTag", 0, SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeOnMessageTag.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeOnMessageTag", base.GetFieldProperties(), -473013992, -1701033547);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}