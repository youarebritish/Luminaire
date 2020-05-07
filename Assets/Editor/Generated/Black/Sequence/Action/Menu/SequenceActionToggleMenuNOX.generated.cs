using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionToggleMenuNOX : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinShow_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinHide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinPause_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinResume_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinConfig_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinAddTime_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinSetBonus_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin pinOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin pinOnClosed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelAddTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelPinCurrentTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelPinBonusTime_;
		public int menuType_;
		public int countdownTime_;
		public float stopTime_;
		public float currentTime_;
		public float addTime_;
		public float bonusTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionToggleMenuNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionToggleMenuNOX", 0, Black.Sequence.Action.Menu.SequenceActionToggleMenuNOX.ObjectType, null, properties, 0, 1392);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionToggleMenuNOX", base.GetFieldProperties(), -1626555324, 471423118);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinShow_.pinName_", 2004415361, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinShow_.name_", 737781500, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinShow_.connections_", 3648909666, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinShow_.delayType_", 3458218688, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinShow_.delayTime_", 3542185771, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinShow_.delayMaxTime_", 2969301523, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinHide_.pinName_", 1893760936, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinHide_.name_", 3306383939, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinHide_.connections_", 360888651, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinHide_.delayType_", 2428992773, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinHide_.delayTime_", 1241698690, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinHide_.delayMaxTime_", 2139241368, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinPause_.pinName_", 335892374, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinPause_.name_", 1965628193, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinPause_.connections_", 43771521, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinPause_.delayType_", 215409243, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinPause_.delayTime_", 3324362384, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinPause_.delayMaxTime_", 3738608090, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinResume_.pinName_", 1920924455, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinResume_.name_", 3174337298, "Base.String", 488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinResume_.connections_", 3607861888, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 504, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinResume_.delayType_", 1430000982, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 536, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinResume_.delayTime_", 46447969, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinResume_.delayMaxTime_", 467155197, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinConfig_.pinName_", 4170729266, "Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinConfig_.name_", 3807979501, "Base.String", 584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinConfig_.connections_", 3542130133, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 600, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinConfig_.delayType_", 2782235871, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 632, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinConfig_.delayTime_", 2665517260, "float", 636, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinConfig_.delayMaxTime_", 2940436214, "float", 640, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinAddTime_.pinName_", 208326582, "Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinAddTime_.name_", 2412471425, "Base.String", 680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinAddTime_.connections_", 1784095713, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 696, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinAddTime_.delayType_", 2754277755, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 728, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinAddTime_.delayTime_", 4181729840, "float", 732, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinAddTime_.delayMaxTime_", 3345522874, "float", 736, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinSetBonus_.pinName_", 1340315275, "Base.String", 760, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinSetBonus_.name_", 4083799238, "Base.String", 776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinSetBonus_.connections_", 642943100, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 792, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinSetBonus_.delayType_", 1924946162, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 824, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinSetBonus_.delayTime_", 3730419445, "float", 828, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinSetBonus_.delayMaxTime_", 1437154897, "float", 832, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.pinName_", 3987307508, "Base.String", 856, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.name_", 1989875983, "Base.String", 872, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.connections_", 1949367711, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 888, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.delayType_", 1110488073, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 920, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.delayTime_", 3181206670, "float", 924, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.delayMaxTime_", 939163492, "float", 928, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOnClosed_.pinName_", 1430657905, "Base.String", 952, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOnClosed_.name_", 4150914924, "Base.String", 968, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOnClosed_.connections_", 21985778, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 984, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinOnClosed_.delayType_", 2154956432, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1016, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOnClosed_.delayTime_", 2719911547, "float", 1020, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOnClosed_.delayMaxTime_", 2276239971, "float", 1024, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelAddTime_.pinName_", 491449265, "Base.String", 1048, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelAddTime_.name_", 2891091372, "Base.String", 1064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelAddTime_.connections_", 872469042, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1080, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("labelAddTime_.pinValueType_", 1099505281, "Base.String", 1112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelPinCurrentTime_.pinName_", 947840092, "Base.String", 1136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelPinCurrentTime_.name_", 2615172807, "Base.String", 1152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelPinCurrentTime_.connections_", 3085898759, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1168, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("labelPinCurrentTime_.pinValueType_", 3115424714, "Base.String", 1200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelPinBonusTime_.pinName_", 4205717306, "Base.String", 1224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelPinBonusTime_.name_", 3219362373, "Base.String", 1240, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelPinBonusTime_.connections_", 2665162333, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1256, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("labelPinBonusTime_.pinValueType_", 3276720716, "Base.String", 1288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("pinShow_", 3937235990, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinHide_", 949596465, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinPause_", 1541889843, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinResume_", 3773294248, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinConfig_", 3452352023, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinAddTime_", 1028610515, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinSetBonus_", 3994408388, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinOut_", 3329024485, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinOnClosed_", 2637522406, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelAddTime_", 2535321766, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelPinCurrentTime_", 3938438173, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelPinBonusTime_", 2984958575, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("menuType_", 969717087, "Black.Sequence.Action.Menu.NoxMenuType", 1304, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("countdownTime_", 2125693714, "unsigned int", 1308, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopTime_", 621907553, "float", 1312, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("currentTime_", 3151480428, "float", 1316, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("addTime_", 436626334, "float", 1320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bonusTime_", 594230222, "float", 1324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}