using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSetTextSwfEntityBundle : Black.Sequence.Action.Menu.SequenceActionSwfEntityHierarchyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin messagePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetPin_;
		public bool forceVisibleFlag_;
		public uint textFieldFixid_;
		public string message_;
		public bool setEmptyText_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetTextSwfEntityBundle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSetTextSwfEntityBundle", 0, Black.Sequence.Action.Menu.SequenceActionSetTextSwfEntityBundle.ObjectType, null, properties, 0, 800);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSetTextSwfEntityBundle", base.GetFieldProperties(), 1163920092, 1401431363);
            return fieldProperties;
        }

		
    }
}