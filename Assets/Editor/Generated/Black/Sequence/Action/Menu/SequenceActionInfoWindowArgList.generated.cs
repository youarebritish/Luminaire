using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionInfoWindowArgList : SQEX.Ebony.Framework.Sequence.SequenceAction
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
		public string dialogString_;
		public UnityEngine.Vector4 dialogPos_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueListInputPin_;
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

            var dummy = new SequenceActionInfoWindowArgList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionInfoWindowArgList", 0, Black.Sequence.Action.Menu.SequenceActionInfoWindowArgList.ObjectType, null, properties, 0, 1472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionInfoWindowArgList", base.GetFieldProperties(), 473848333, 823578298);
            return fieldProperties;
        }

		
    }
}