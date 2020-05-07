using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSetVisibleSwfEntityBundle : Black.Sequence.Action.Menu.SequenceActionSwfEntityHierarchyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin visibleListInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetInput_;
		public int visibleMethod_;
		public bool focusOrNormal_FocusBool_;
		public bool focusOrNormal_NormalBool_;
		public bool index_0Bool_;
		public bool index_1Bool_;
		public bool index_2Bool_;
		public bool index_3Bool_;
		public bool index_4Bool_;
		public bool index_5Bool_;
		public bool index_6Bool_;
		public bool index_7Bool_;
		public bool index_8Bool_;
		public bool index_9Bool_;
		public bool index_10Bool_;
		public bool compare_SmallBool_;
		public bool compare_EqualBool_;
		public bool compare_BigBool_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVisibleSwfEntityBundle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSetVisibleSwfEntityBundle", 0, Black.Sequence.Action.Menu.SequenceActionSetVisibleSwfEntityBundle.ObjectType, null, properties, 0, 896);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSetVisibleSwfEntityBundle", base.GetFieldProperties(), -723190041, -1070119838);
            return fieldProperties;
        }

		
    }
}