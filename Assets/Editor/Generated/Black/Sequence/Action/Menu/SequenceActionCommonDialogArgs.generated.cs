using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionCommonDialogArgs : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin openIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin closeIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin requestLoadIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin unloadIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin imageIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin openedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selectedYesOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selectedNoOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected1OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected2OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected3OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected4OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected5OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin canceledOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin loadFinishedOPin_;
		public float disableCloseSeconds_;
		public bool enablePause_;
		public bool disableCancelButton_;
		public int dialogType_;
		public uint captionTextId_;
		public string captionTextDebug_;
		public bool defaultSelectNo_;
		public uint select01TextId_;
		public uint select02TextId_;
		public uint select03TextId_;
		public uint select04TextId_;
		public uint select05TextId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select01TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select02TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select03TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select04TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select05TextPin_;
		public bool isAutoUnloadRequest_;
		public bool isUseSystemAll_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVariableInputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVariableInputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVariableInputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVariableInputPin1_;
		public int argsNum_;
		public bool closeOnlyIfOpener_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCommonDialogArgs();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionCommonDialogArgs", 0, Black.Sequence.Action.Menu.SequenceActionCommonDialogArgs.ObjectType, null, properties, 0, 2688);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionCommonDialogArgs", base.GetFieldProperties(), -1475402281, -316686165);
            
			fieldProperties.AddProperty(new Property("openIPin_", 1128097168, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("closeIPin_", 1685805310, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("requestLoadIPin_", 1555863237, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("unloadIPin_", 2263201757, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("imageIdIPin_", 3503864794, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outOPin_", 3584478464, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 648, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("openedOPin_", 3642562553, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 744, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("closedOPin_", 3921963998, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 840, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectedYesOPin_", 1018266176, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 936, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectedNoOPin_", 905011572, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1032, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selected1OPin_", 1597501504, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1128, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selected2OPin_", 1830674883, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1224, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selected3OPin_", 3475793886, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1320, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selected4OPin_", 4126044825, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1416, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selected5OPin_", 2505325588, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1512, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("canceledOPin_", 1201985083, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1608, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("loadFinishedOPin_", 2339924456, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1704, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disableCloseSeconds_", 3057605451, "float", 1800, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enablePause_", 759558965, "bool", 1804, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("disableCancelButton_", 3446458762, "bool", 1805, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dialogType_", 1072466506, "Black.Sequence.Action.Menu.SequenceActionCommonDialogArgs.DialogType", 1808, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("captionTextId_", 1670090420, "SQEX.Ebony.Std.Fixid", 1812, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("captionTextDebug_", 1217830754, "Ebony.Base.String", 1816, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultSelectNo_", 2665910334, "bool", 1832, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("select01TextId_", 2218232617, "SQEX.Ebony.Std.Fixid", 1836, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("select02TextId_", 2264615630, "SQEX.Ebony.Std.Fixid", 1840, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("select03TextId_", 53991275, "SQEX.Ebony.Std.Fixid", 1844, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("select04TextId_", 3371164808, "SQEX.Ebony.Std.Fixid", 1848, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("select05TextId_", 2281557997, "SQEX.Ebony.Std.Fixid", 1852, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("select01TextPin_", 3417811669, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("select02TextPin_", 2282582008, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1944, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("select03TextPin_", 2617705655, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2032, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("select04TextPin_", 2812554826, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2120, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("select05TextPin_", 3077204945, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2208, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAutoUnloadRequest_", 869869987, "bool", 2296, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseSystemAll_", 321176841, "bool", 2297, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVariableInputPin4_", 2289319956, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2304, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVariableInputPin3_", 3363926215, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVariableInputPin2_", 3364073310, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2480, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVariableInputPin1_", 3363528857, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("argsNum_", 1545783385, "int", 2656, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("closeOnlyIfOpener_", 422197842, "bool", 2660, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}