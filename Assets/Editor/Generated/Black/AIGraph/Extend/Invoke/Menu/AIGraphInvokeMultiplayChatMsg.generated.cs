using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Menu
{
    public partial class AIGraphInvokeMultiplayChatMsg : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint chatMsgId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeMultiplayChatMsg();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Menu.AIGraphInvokeMultiplayChatMsg", 0, Black.AIGraph.Extend.Invoke.Menu.AIGraphInvokeMultiplayChatMsg.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Menu.AIGraphInvokeMultiplayChatMsg", base.GetFieldProperties(), -870793499, 970426235);
            return fieldProperties;
        }

		
    }
}