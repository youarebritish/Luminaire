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
            
			fieldProperties.AddProperty(new Property("inPin_", 3408135614, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 312, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 408, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfEntityInput_", 531204709, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueInput_", 1426429715, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("visibleListInput_", 1834128420, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetInput_", 1142920979, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("visibleMethod_", 703761185, "Black.Sequence.Action.Menu.SequenceActionSetVisibleSwfEntityBundle.VisibleMethod", 856, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusOrNormal_FocusBool_", 3391988551, "bool", 860, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusOrNormal_NormalBool_", 187559154, "bool", 861, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_0Bool_", 622516665, "bool", 862, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_1Bool_", 4128221876, "bool", 863, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_2Bool_", 3107753787, "bool", 864, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_3Bool_", 92373614, "bool", 865, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_4Bool_", 2547650581, "bool", 866, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_5Bool_", 848402512, "bool", 867, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_6Bool_", 1149850551, "bool", 868, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_7Bool_", 804335658, "bool", 869, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_8Bool_", 3839094961, "bool", 870, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_9Bool_", 2729005068, "bool", 871, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_10Bool_", 436815878, "bool", 872, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_SmallBool_", 32273797, "bool", 873, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_EqualBool_", 2156982576, "bool", 874, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_BigBool_", 1622507238, "bool", 875, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}