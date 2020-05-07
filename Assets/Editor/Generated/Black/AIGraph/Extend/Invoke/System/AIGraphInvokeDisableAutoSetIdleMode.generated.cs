using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.System
{
    public partial class AIGraphInvokeDisableAutoSetIdleMode : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeDisableAutoSetIdleMode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.System.AIGraphInvokeDisableAutoSetIdleMode", 0, Black.AIGraph.Extend.Invoke.System.AIGraphInvokeDisableAutoSetIdleMode.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.System.AIGraphInvokeDisableAutoSetIdleMode", base.GetFieldProperties(), -816689491, -2015377760);
            
			
			
			return fieldProperties;
        }

		
    }
}