using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableSwfDefEntity : Black.Sequence.Variable.SequenceVariableSwfConnector
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValue_;
		public SQEX.Ebony.Framework.Entity.Entity entityPointer_;
		public bool isSetTextFieldConfig_;
		public bool isSetLabelSound_;
		public IList<Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem> textFiledConfigList_;
		public IList<Black.Entity.Data.Menu.SwfLabelAccessoryArrayItem> labelAccessoryList_;
		public IList<Black.Entity.Data.Menu.SwfStringArrayItem> nameList_;
		public IList<Black.Entity.Data.Menu.SwfFixidArrayItem> fixidList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableSwfDefEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableSwfDefEntity", 0, Black.Sequence.Variable.SequenceVariableSwfDefEntity.ObjectType, null, properties, 0, 3624);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableSwfDefEntity", base.GetFieldProperties(), -101153703, -981291477);
            
			fieldProperties.AddProperty(new Property("outValue_", 2704623729, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 3456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("entityPointer_", 3527687820, "SQEX.Ebony.Framework.Entity.Entity", 3544, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			fieldProperties.AddProperty(new Property("isSetTextFieldConfig_", 2984682235, "bool", 3552, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSetLabelSound_", 2439029007, "bool", 3553, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("textFiledConfigList_", 3885649187, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem* >", 3560, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("labelAccessoryList_", 2486815510, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Menu.SwfLabelAccessoryArrayItem* >", 3576, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("nameList_", 1377118711, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Menu.SwfStringArrayItem* >", 3592, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("fixidList_", 4122648698, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Menu.SwfFixidArrayItem* >", 3608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			return fieldProperties;
        }

		
    }
}