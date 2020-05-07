using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionInfoWindowArgs : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin closePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin opened_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin canceled_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin pressButtonDecided_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin pressButtonOther_;
		public uint dialogFixId_;
		public uint keyHelpFixId_;
		public string dialogString_;
		public UnityEngine.Vector4 dialogPos_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVariableInputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVariableInputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVariableInputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVariableInputPin1_;
		public int argsNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dialogFixIdPin_;
		public float dialogSeconds_;
		public int messageSpecificationType_;
		public bool forceDisp_;
		public bool enablePause_;
		public bool enableCancelClose_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionInfoWindowArgs();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionInfoWindowArgs", 0, Black.Sequence.Action.Menu.SequenceActionInfoWindowArgs.ObjectType, null, properties, 0, 1760);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionInfoWindowArgs", base.GetFieldProperties(), -628920633, -1672125801);
            return fieldProperties;
        }

		
    }
}