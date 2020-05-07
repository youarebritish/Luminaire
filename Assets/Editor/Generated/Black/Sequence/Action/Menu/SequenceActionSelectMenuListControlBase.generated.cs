using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSelectMenuListControlBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin open_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin next_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin prev_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin onDecide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin onCancel_;
		public bool useDefaultInput_;
		public int listType_;
		public uint swfListInLabelFixID_;
		public uint swfListOutLabelFixID_;
		public uint swfListNormalLabelFixID_;
		public uint swfListFocusLabelFixID_;
		public uint swfListDecideLabelFixID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin connectedSwfPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin initialIndexPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin opened_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin decide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSelectValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSelectMenuListControlBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSelectMenuListControlBase", 0, Black.Sequence.Action.Menu.SequenceActionSelectMenuListControlBase.ObjectType, null, properties, 0, 1568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSelectMenuListControlBase", base.GetFieldProperties(), 762194623, -1088716418);
            return fieldProperties;
        }

		
    }
}