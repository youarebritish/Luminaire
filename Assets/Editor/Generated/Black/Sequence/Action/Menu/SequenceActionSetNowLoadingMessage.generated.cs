using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSetNowLoadingMessage : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public string bgSwfPath_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin bgSwfPathPin_;
		public uint titleId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin titleIdPin_;
		public uint messageId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin messageIdPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetNowLoadingMessage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSetNowLoadingMessage", 0, Black.Sequence.Action.Menu.SequenceActionSetNowLoadingMessage.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSetNowLoadingMessage", base.GetFieldProperties(), -1963319231, -541656501);
            
			
			
			return fieldProperties;
        }

		
    }
}