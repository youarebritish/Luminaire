using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Buddy
{
    public partial class AIGraphInvokeSetCalcCutInParameters : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool bOn;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetCalcCutInParameters();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetCalcCutInParameters", 0, Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetCalcCutInParameters.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetCalcCutInParameters", base.GetFieldProperties(), 1321575796, -2141246255);
            return fieldProperties;
        }

		
    }
}