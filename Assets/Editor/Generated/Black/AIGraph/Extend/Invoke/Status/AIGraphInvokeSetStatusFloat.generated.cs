using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Status
{
    public partial class AIGraphInvokeSetStatusFloat : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int changeStatusType;
		public float statusValue;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetStatusFloat();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Status.AIGraphInvokeSetStatusFloat", 0, Black.AIGraph.Extend.Invoke.Status.AIGraphInvokeSetStatusFloat.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Status.AIGraphInvokeSetStatusFloat", base.GetFieldProperties(), 222225403, 406481842);
            
			
			
			return fieldProperties;
        }

		
    }
}