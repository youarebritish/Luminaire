using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke.Nifl
{
    public partial class AIGraphExpressionInvokeCanReinforcement : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeCanReinforcement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.Nifl.AIGraphExpressionInvokeCanReinforcement", 0, Black.AIGraph.Extend.Expression.Invoke.Nifl.AIGraphExpressionInvokeCanReinforcement.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.Nifl.AIGraphExpressionInvokeCanReinforcement", base.GetFieldProperties(), 329069752, 2022949884);
            
			
			
			return fieldProperties;
        }

		
    }
}