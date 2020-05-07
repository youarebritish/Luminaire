using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Expression.Invoke.Buddy
{
    public partial class AIGraphExpressionInvokeHasAbility : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeHasAbility();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Expression.Invoke.Buddy.AIGraphExpressionInvokeHasAbility", 0, Black.AIGraph.Extend.Expression.Invoke.Buddy.AIGraphExpressionInvokeHasAbility.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Expression.Invoke.Buddy.AIGraphExpressionInvokeHasAbility", base.GetFieldProperties(), 728471482, -1157702281);
            return fieldProperties;
        }

		
    }
}