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
            
			fieldProperties.AddProperty(new Property("playPin_", 1036284367, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 312, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopPin_", 2226130577, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 408, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 504, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("playFinishedPin_", 140610713, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 600, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfEntityInput_", 531204709, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueInput_", 1426429715, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 784, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueListInput_", 2322996415, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 872, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("highlightListInput_", 3063560902, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 960, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetInput_", 1142920979, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceVisibleFlag_", 322326389, "bool", 1136, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("invisibleNoLabel_", 3737130168, "bool", 1137, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceInvisibleFlag_", 2836279738, "bool", 1138, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("invisibleFinish_", 3736634240, "bool", 1139, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("playOnlyNewLabel_", 3293904986, "bool", 1140, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelMethod_", 316246213, "Black.Sequence.Action.Menu.SequenceActionPlaySwfEntityBundle.LabelMethod", 1144, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusOrNormal_FocusFixID_", 1470673841, "SQEX.Ebony.Std.Fixid", 1148, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusOrNormal_NormalFixID_", 2764985978, "SQEX.Ebony.Std.Fixid", 1152, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_0FixID_", 2099867735, "SQEX.Ebony.Std.Fixid", 1156, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_1FixID_", 4049496064, "SQEX.Ebony.Std.Fixid", 1160, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_2FixID_", 2695934261, "SQEX.Ebony.Std.Fixid", 1164, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_3FixID_", 630186214, "SQEX.Ebony.Std.Fixid", 1168, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_4FixID_", 3183763939, "SQEX.Ebony.Std.Fixid", 1172, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_5FixID_", 2407580204, "SQEX.Ebony.Std.Fixid", 1176, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_6FixID_", 654138273, "SQEX.Ebony.Std.Fixid", 1180, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_7FixID_", 4057905922, "SQEX.Ebony.Std.Fixid", 1184, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_8FixID_", 1753446047, "SQEX.Ebony.Std.Fixid", 1188, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_9FixID_", 562437672, "SQEX.Ebony.Std.Fixid", 1192, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_10FixID_", 2533992654, "SQEX.Ebony.Std.Fixid", 1196, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_SmallFixID_", 2405839507, "SQEX.Ebony.Std.Fixid", 1200, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_EqualFixID_", 2231510028, "SQEX.Ebony.Std.Fixid", 1204, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_BigFixID_", 1358675118, "SQEX.Ebony.Std.Fixid", 1208, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusWithDisable_FocusFixID_", 234411109, "SQEX.Ebony.Std.Fixid", 1212, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusWithDisable_NormalFixID_", 695486350, "SQEX.Ebony.Std.Fixid", 1216, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusWithDisable_NormalDisableFixID_", 3371522756, "SQEX.Ebony.Std.Fixid", 1220, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusWithDisable_FocusDisableFixID_", 3666352621, "SQEX.Ebony.Std.Fixid", 1224, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusWithDisableAndHighlight_FocusFixID_", 8159786, "SQEX.Ebony.Std.Fixid", 1228, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusWithDisableAndHighlight_NormalFixID_", 2417710315, "SQEX.Ebony.Std.Fixid", 1232, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusWithDisableAndHighlight_NormalDisableFixID_", 2407403151, "SQEX.Ebony.Std.Fixid", 1236, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusWithDisableAndHighlight_FocusDisableFixID_", 879687152, "SQEX.Ebony.Std.Fixid", 1240, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelListInput_", 1912163776, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1248, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}