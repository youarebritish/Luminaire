using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Buddy
{
    public partial class AIGraphInvokeSetEventScriptExecutable : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isExecutable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetEventScriptExecutable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetEventScriptExecutable", 0, Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetEventScriptExecutable.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetEventScriptExecutable", base.GetFieldProperties(), -1209602279, 1737787274);
            return fieldProperties;
        }

		
    }
}