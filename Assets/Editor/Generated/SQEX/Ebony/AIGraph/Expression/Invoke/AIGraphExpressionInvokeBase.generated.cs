using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Expression.Invoke
{
    public partial class AIGraphExpressionInvokeBase : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase", 0, SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase", base.GetFieldProperties(), -1142270157, -1450192902);
            return fieldProperties;
        }

		
    }
}