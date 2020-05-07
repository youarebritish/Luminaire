using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionPlaySwfEntityBundle : Black.Sequence.Action.Menu.SequenceActionSwfEntityHierarchyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin playPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin playFinishedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueListInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin highlightListInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetInput_;
		public bool forceVisibleFlag_;
		public bool invisibleNoLabel_;
		public bool forceInvisibleFlag_;
		public bool invisibleFinish_;
		public bool playOnlyNewLabel_;
		public int labelMethod_;
		public uint focusOrNormal_FocusFixID_;
		public uint focusOrNormal_NormalFixID_;
		public uint index_0FixID_;
		public uint index_1FixID_;
		public uint index_2FixID_;
		public uint index_3FixID_;
		public uint index_4FixID_;
		public uint index_5FixID_;
		public uint index_6FixID_;
		public uint index_7FixID_;
		public uint index_8FixID_;
		public uint index_9FixID_;
		public uint index_10FixID_;
		public uint compare_SmallFixID_;
		public uint compare_EqualFixID_;
		public uint compare_BigFixID_;
		public uint focusWithDisable_FocusFixID_;
		public uint focusWithDisable_NormalFixID_;
		public uint focusWithDisable_NormalDisableFixID_;
		public uint focusWithDisable_FocusDisableFixID_;
		public uint focusWithDisableAndHighlight_FocusFixID_;
		public uint focusWithDisableAndHighlight_NormalFixID_;
		public uint focusWithDisableAndHighlight_NormalDisableFixID_;
		public uint focusWithDisableAndHighlight_FocusDisableFixID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelListInput_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlaySwfEntityBundle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionPlaySwfEntityBundle", 0, Black.Sequence.Action.Menu.SequenceActionPlaySwfEntityBundle.ObjectType, null, properties, 0, 1384);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionPlaySwfEntityBundle", base.GetFieldProperties(), -213018041, -1898978398);
            return fieldProperties;
        }

		
    }
}