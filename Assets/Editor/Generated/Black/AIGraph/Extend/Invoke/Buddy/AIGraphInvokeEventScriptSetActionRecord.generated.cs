using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Buddy
{
    public partial class AIGraphInvokeEventScriptSetActionRecord : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int slotType_;
		public int actionType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeEventScriptSetActionRecord();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeEventScriptSetActionRecord", 0, Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeEventScriptSetActionRecord.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeEventScriptSetActionRecord", base.GetFieldProperties(), -1108547880, -2060113100);
            return fieldProperties;
        }

		
    }
}