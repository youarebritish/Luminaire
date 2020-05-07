using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke
{
    public partial class AIGraphInvokeSetForceTarget : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string label_;
		public int targetSlotType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetForceTarget();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.AIGraphInvokeSetForceTarget", 0, Black.AIGraph.Extend.Invoke.AIGraphInvokeSetForceTarget.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.AIGraphInvokeSetForceTarget", base.GetFieldProperties(), -1926097644, 1670464350);
            return fieldProperties;
        }

		
    }
}