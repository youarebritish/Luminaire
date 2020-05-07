using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke
{
    public partial class AIGraphInvokeSetMaterialParameterFloat : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string materialName_;
		public string parameterName_;
		public float parameterValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetMaterialParameterFloat();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.AIGraphInvokeSetMaterialParameterFloat", 0, Black.AIGraph.Extend.Invoke.AIGraphInvokeSetMaterialParameterFloat.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.AIGraphInvokeSetMaterialParameterFloat", base.GetFieldProperties(), 1602564626, 1003789265);
            return fieldProperties;
        }

		
    }
}