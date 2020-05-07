using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionTutorialInfoWindowArgs : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin opened_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public float dispTime_;
		public float dispFixTime_;
		public bool flagSkipPermit_;
		public bool flagPause_;
		public int messageSpecificationType_;
		public uint dialogFixId_;
		public string dialogString_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin argsPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin argsPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin argsPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin argsPin1_;
		public int numArgs_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTutorialInfoWindowArgs();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionTutorialInfoWindowArgs", 0, Black.Sequence.Action.Menu.SequenceActionTutorialInfoWindowArgs.ObjectType, null, properties, 0, 1104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionTutorialInfoWindowArgs", base.GetFieldProperties(), 307801839, -585010848);
            return fieldProperties;
        }

		
    }
}