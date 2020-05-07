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
            
			fieldProperties.AddProperty(new Property("playPin_", 1036284367, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 312, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopPin_", 2226130577, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 408, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 504, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("failedPin_", 2744079412, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 600, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("playFinishedPin_", 140610713, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 696, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfEntityInput_", 531204709, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceVisibleFlag_", 322326389, "bool", 880, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceInvisibleFlag_", 2836279738, "bool", 881, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("invisibleFinish_", 3736634240, "bool", 882, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("playOnlyNewLabel_", 3293904986, "bool", 883, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelMethod_", 316246213, "Black.Sequence.Action.Menu.SequenceActionPlaySwfEntity.LabelMethod", 884, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLabelFixID_", 3767198276, "SQEX.Ebony.Std.Fixid", 888, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLabelPin_", 1079616719, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("value1Pin_", 1619962493, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("value2Pin_", 450029448, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1072, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("equal_IsFixID_", 650060451, "SQEX.Ebony.Std.Fixid", 1160, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("equal_IsNotFixID_", 1837732522, "SQEX.Ebony.Std.Fixid", 1164, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_SmallFixID_", 2405839507, "SQEX.Ebony.Std.Fixid", 1168, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_EqualFixID_", 2231510028, "SQEX.Ebony.Std.Fixid", 1172, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_BigFixID_", 1358675118, "SQEX.Ebony.Std.Fixid", 1176, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}