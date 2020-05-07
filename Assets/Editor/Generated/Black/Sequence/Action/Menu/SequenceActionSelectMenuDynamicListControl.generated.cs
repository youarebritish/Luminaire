using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSelectMenuDynamicListControl : Black.Sequence.Action.Menu.SequenceActionSelectMenuListControlBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin menuItemList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin menuItemList2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rootEntityPin_;
		public string filePath_;
		public uint textFieldFixid_;
		public uint textFieldFixid2_;
		public UnityEngine.Vector4 offset_;
		public int itemSkip_;
		public int maxDispItems_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSelectMenuDynamicListControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSelectMenuDynamicListControl", 0, Black.Sequence.Action.Menu.SequenceActionSelectMenuDynamicListControl.ObjectType, null, properties, 0, 1904);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSelectMenuDynamicListControl", base.GetFieldProperties(), -618532242, -1522347144);
            
			
			
			return fieldProperties;
        }

		
    }
}