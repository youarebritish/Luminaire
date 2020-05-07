using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetChatInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chatTabIdxPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin categoryTextMsgIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin battleMenuCategoryIndexPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin chatTabsCountPin_;
		public int chatTabIndex_;
		public bool useItemOrderList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetChatInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetChatInfo", 0, Black.Sequence.Action.Level.SequenceActionGetChatInfo.ObjectType, null, properties, 0, 728);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetChatInfo", base.GetFieldProperties(), 1953055066, -1703074087);
            return fieldProperties;
        }

		
    }
}