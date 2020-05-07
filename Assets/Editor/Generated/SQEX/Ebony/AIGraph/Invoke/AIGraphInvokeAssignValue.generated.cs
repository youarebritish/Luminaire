using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Invoke
{
    public partial class AIGraphInvokeAssignValue : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string compiledExpression_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeAssignValue();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeAssignValue", 0, SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeAssignValue.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeAssignValue", base.GetFieldProperties(), -696634918, 430917582);
            return fieldProperties;
        }

		
    }
}