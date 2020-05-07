using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionPlaySwfEntity : Black.Sequence.Action.Menu.SequenceActionSwfEntityHierarchyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin playPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin playFinishedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput_;
		public bool forceVisibleFlag_;
		public bool forceInvisibleFlag_;
		public bool invisibleFinish_;
		public bool playOnlyNewLabel_;
		public int labelMethod_;
		public uint swfLabelFixID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfLabelPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin value1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin value2Pin_;
		public uint equal_IsFixID_;
		public uint equal_IsNotFixID_;
		public uint compare_SmallFixID_;
		public uint compare_EqualFixID_;
		public uint compare_BigFixID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlaySwfEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionPlaySwfEntity", 0, Black.Sequence.Action.Menu.SequenceActionPlaySwfEntity.ObjectType, null, properties, 0, 1200);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionPlaySwfEntity", base.GetFieldProperties(), 903360200, -1834283824);
            return fieldProperties;
        }

		
    }
}