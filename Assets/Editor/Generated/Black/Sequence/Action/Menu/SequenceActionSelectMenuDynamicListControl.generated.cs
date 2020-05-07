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
            
			fieldProperties.AddProperty(new Property("menuItemList_", 895356870, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("menuItemList2_", 2605014758, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rootEntityPin_", 638392090, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("filePath_", 956091201, "Ebony.Base.String", 1832, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("textFieldFixid_", 1480614613, "SQEX.Ebony.Std.Fixid", 1848, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("textFieldFixid2_", 3061103907, "SQEX.Ebony.Std.Fixid", 1852, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("offset_", 1294275471, "Luminous.Math.VectorA", 1856, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("itemSkip_", 79495334, "int", 1872, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxDispItems_", 666648396, "int", 1876, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}