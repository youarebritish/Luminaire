using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSelectRolesControl : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin open_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin changeLeft_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin changeRight;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin up_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin right_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin left_;
		public bool useDefaultInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin01_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin02_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin03_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin04_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin05_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin06_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin07_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin charaNamePinNoct_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin charaNamePinGladio_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin charaNamePinIgnis_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin charaNamePinPrompt_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin charaNamePinGuest_;
		public uint swfPartsNormalLabelFixID_;
		public uint swfPartsForcusLabelFixID_;
		public uint swfPartsFocusLeftLabelFixID_;
		public uint swfPartsFocusRightFixID_;
		public uint swfRoleNameFieldFixID_;
		public uint swfRoleLevelFieldFixID_;
		public uint swfCharaNameFieldFixID_;
		public UnityEngine.Vector4 rolesSelectOffset_;
		public UnityEngine.Vector4 rolesCharaOffset_;
		public UnityEngine.Vector4 lineOffset_;
		public uint swfSelectInLabelFixID_;
		public uint swfSelectLoopLabelFixID_;
		public uint swfSelectOutLabelFixID_;
		public uint swfSelectMoveLeftFixID_;
		public uint swfSelectMoveRightFixID_;
		public uint swfMcRolesSelectFixID_;
		public uint swfCharaInLabelFixID_;
		public uint swfCharaLoopLabelFixID_;
		public uint swfCharaOutLabelFixID_;
		public uint swfLineInLabelFixID_;
		public uint swfLineLoopLabelFixID_;
		public uint swfLineOutLabelFixID_;
		public uint swfLineMoveTopFixID_;
		public uint swfLineMoveBottomFixID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin connectedSwfPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin linePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin roloesSelectListPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin L1pushed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin R1pushed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin Decide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSelectValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSelectRolesControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSelectRolesControl", 0, Black.Sequence.Action.Menu.SequenceActionSelectRolesControl.ObjectType, null, properties, 0, 3104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSelectRolesControl", base.GetFieldProperties(), 1653901104, 367657963);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("open_.pinName_", 2248472069, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("open_.name_", 3725083840, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("open_.connections_", 2539276142, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("open_.delayType_", 1665110236, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("open_.delayTime_", 2816974415, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("open_.delayMaxTime_", 1731560535, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("close_.pinName_", 2217308955, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("close_.name_", 886440022, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("close_.connections_", 2487720812, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("close_.delayType_", 2553504418, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("close_.delayTime_", 1666045733, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("close_.delayMaxTime_", 1495987969, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeLeft_.pinName_", 3732215252, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeLeft_.name_", 4228163631, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeLeft_.connections_", 1149479487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("changeLeft_.delayType_", 3992180457, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeLeft_.delayTime_", 1767931758, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeLeft_.delayMaxTime_", 2519914628, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeRight.pinName_", 2641714316, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeRight.name_", 3081429047, "Base.String", 488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeRight.connections_", 2696631063, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 504, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("changeRight.delayType_", 531941457, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 536, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeRight.delayTime_", 4052583942, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeRight.delayMaxTime_", 3910054444, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("up_.pinName_", 2863165708, "Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("up_.name_", 35835319, "Base.String", 584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("up_.connections_", 2569744279, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 600, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("up_.delayType_", 174928081, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 632, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("up_.delayTime_", 3695570566, "float", 636, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("up_.delayMaxTime_", 2166804396, "float", 640, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("down_.pinName_", 2411248377, "Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("down_.name_", 2343172164, "Base.String", 680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("down_.connections_", 1152540154, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 696, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("down_.delayType_", 2261886568, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 728, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("down_.delayTime_", 613199907, "float", 732, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("down_.delayMaxTime_", 2831537243, "float", 736, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("right_.pinName_", 1681655273, "Base.String", 760, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("right_.name_", 2484554804, "Base.String", 776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("right_.connections_", 3744435594, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 792, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("right_.delayType_", 2193643832, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 824, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("right_.delayTime_", 1042093939, "float", 828, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("right_.delayMaxTime_", 2934602027, "float", 832, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("left_.pinName_", 2517177276, "Base.String", 856, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("left_.name_", 2506257767, "Base.String", 872, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("left_.connections_", 3482199335, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 888, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("left_.delayType_", 3148274529, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 920, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("left_.delayTime_", 733997014, "float", 924, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("left_.delayMaxTime_", 2436772732, "float", 928, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin01_.pinName_", 2129936403, "Base.String", 960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin01_.name_", 3992983550, "Base.String", 976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin01_.connections_", 3139589604, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 992, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin01_.pinValueType_", 1049600183, "Base.String", 1024, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin02_.pinName_", 3516195990, "Base.String", 1048, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin02_.name_", 4249205281, "Base.String", 1064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin02_.connections_", 2328873857, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1080, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin02_.pinValueType_", 1479886232, "Base.String", 1112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin03_.pinName_", 929910493, "Base.String", 1136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin03_.name_", 294809512, "Base.String", 1152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin03_.connections_", 939106534, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1168, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin03_.pinValueType_", 1762256621, "Base.String", 1200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin04_.pinName_", 4157402680, "Base.String", 1224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin04_.name_", 1372902547, "Base.String", 1240, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin04_.connections_", 3924878971, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1256, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin04_.pinValueType_", 977481926, "Base.String", 1288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin05_.pinName_", 3693826775, "Base.String", 1312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin05_.name_", 1338278722, "Base.String", 1328, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin05_.connections_", 625861136, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1344, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin05_.pinValueType_", 4246257739, "Base.String", 1376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin06_.pinName_", 1330695578, "Base.String", 1400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin06_.name_", 1549692517, "Base.String", 1416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin06_.connections_", 3348422653, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1432, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin06_.pinValueType_", 1853292780, "Base.String", 1464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin07_.pinName_", 3454749169, "Base.String", 1488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin07_.name_", 2152590060, "Base.String", 1504, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin07_.connections_", 2830700658, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1520, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rolePin07_.pinValueType_", 3960204225, "Base.String", 1552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinNoct_.pinName_", 1425559426, "Base.String", 1576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinNoct_.name_", 3164009021, "Base.String", 1592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinNoct_.connections_", 490655557, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinNoct_.pinValueType_", 3694956132, "Base.String", 1640, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinGladio_.pinName_", 179785808, "Base.String", 1664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinGladio_.name_", 3669095611, "Base.String", 1680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinGladio_.connections_", 983980627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1696, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinGladio_.pinValueType_", 3904301934, "Base.String", 1728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinIgnis_.pinName_", 169617988, "Base.String", 1752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinIgnis_.name_", 821994079, "Base.String", 1768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinIgnis_.connections_", 193749519, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1784, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinIgnis_.pinValueType_", 1017561506, "Base.String", 1816, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinPrompt_.pinName_", 2080666864, "Base.String", 1840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinPrompt_.name_", 2217479195, "Base.String", 1856, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinPrompt_.connections_", 2233550771, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1872, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinPrompt_.pinValueType_", 2497587790, "Base.String", 1904, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinGuest_.pinName_", 2525615346, "Base.String", 1928, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinGuest_.name_", 340995501, "Base.String", 1944, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinGuest_.connections_", 3286229909, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1960, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("charaNamePinGuest_.pinValueType_", 946608148, "Base.String", 1992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("connectedSwfPin_.pinName_", 424445003, "Base.String", 2160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("connectedSwfPin_.name_", 1290921350, "Base.String", 2176, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("connectedSwfPin_.connections_", 260624188, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2192, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("connectedSwfPin_.pinValueType_", 360158943, "Base.String", 2224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("linePin_.pinName_", 889590950, "Base.String", 2248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("linePin_.name_", 4121996273, "Base.String", 2264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("linePin_.connections_", 3262648689, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2280, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("linePin_.pinValueType_", 4206662696, "Base.String", 2312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("roloesSelectListPin_.pinName_", 519783834, "Base.String", 2336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("roloesSelectListPin_.name_", 2287654501, "Base.String", 2352, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("roloesSelectListPin_.connections_", 628021245, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2368, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("roloesSelectListPin_.pinValueType_", 748185836, "Base.String", 2400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changed_.pinName_", 1399487843, "Base.String", 2424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changed_.name_", 867246158, "Base.String", 2440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changed_.connections_", 1061995668, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2456, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("changed_.delayType_", 2798371386, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2488, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changed_.delayTime_", 3291111949, "float", 2492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changed_.delayMaxTime_", 3822853721, "float", 2496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("L1pushed_.pinName_", 1392542055, "Base.String", 2520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("L1pushed_.name_", 2185431890, "Base.String", 2536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("L1pushed_.connections_", 582230976, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2552, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("L1pushed_.delayType_", 1274828438, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2584, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("L1pushed_.delayTime_", 3761785249, "float", 2588, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("L1pushed_.delayMaxTime_", 3174461757, "float", 2592, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("R1pushed_.pinName_", 4132986613, "Base.String", 2616, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("R1pushed_.name_", 3222938160, "Base.String", 2632, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("R1pushed_.connections_", 832892542, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2648, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("R1pushed_.delayType_", 734407532, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2680, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("R1pushed_.delayTime_", 2801956639, "float", 2684, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("R1pushed_.delayMaxTime_", 4114100071, "float", 2688, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Decide_.pinName_", 2330946861, "Base.String", 2712, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Decide_.name_", 97026808, "Base.String", 2728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Decide_.connections_", 3142858390, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2744, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("Decide_.delayType_", 3406789524, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2776, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Decide_.delayTime_", 3095329399, "float", 2780, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Decide_.delayMaxTime_", 848136079, "float", 2784, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closed_.pinName_", 909346057, "Base.String", 2808, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closed_.name_", 4030665748, "Base.String", 2824, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closed_.connections_", 3062211690, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2840, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("closed_.delayType_", 1685505240, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2872, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closed_.delayTime_", 958412819, "float", 2876, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closed_.delayMaxTime_", 1929410571, "float", 2880, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outSelectValue_.pinName_", 3292975896, "Base.String", 2904, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outSelectValue_.name_", 263752115, "Base.String", 2920, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outSelectValue_.connections_", 4211780763, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2936, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outSelectValue_.pinValueType_", 1351054182, "Base.String", 2968, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("open_", 1412397090, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("close_", 552510516, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("changeLeft_", 3228656965, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("changeRight", 733568877, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("up_", 1636505837, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("down_", 1969139582, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("right_", 127990734, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("left_", 4210150909, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useDefaultInput_", 1534227088, "bool", 944, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin01_", 1060403100, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin02_", 1060550195, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin03_", 4281896970, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin04_", 1060844385, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin05_", 1060991480, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1304, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin06_", 4282441423, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin07_", 4282588518, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1480, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaNamePinNoct_", 756561671, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaNamePinGladio_", 2157582569, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaNamePinIgnis_", 3481578133, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaNamePinPrompt_", 3675151497, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaNamePinGuest_", 1210677079, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfPartsNormalLabelFixID_", 2331598665, "SQEX.Ebony.Std.Fixid", 2008, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfPartsForcusLabelFixID_", 156789812, "SQEX.Ebony.Std.Fixid", 2012, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfPartsFocusLeftLabelFixID_", 1745505013, "SQEX.Ebony.Std.Fixid", 2016, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfPartsFocusRightFixID_", 522270874, "SQEX.Ebony.Std.Fixid", 2020, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfRoleNameFieldFixID_", 2755226171, "SQEX.Ebony.Std.Fixid", 2024, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfRoleLevelFieldFixID_", 779096866, "SQEX.Ebony.Std.Fixid", 2028, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfCharaNameFieldFixID_", 2795397648, "SQEX.Ebony.Std.Fixid", 2032, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolesSelectOffset_", 3225544954, "Luminous.Math.VectorA", 2048, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolesCharaOffset_", 4235052619, "Luminous.Math.VectorA", 2064, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("lineOffset_", 3007963065, "Luminous.Math.VectorA", 2080, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfSelectInLabelFixID_", 665328489, "SQEX.Ebony.Std.Fixid", 2096, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfSelectLoopLabelFixID_", 3998518578, "SQEX.Ebony.Std.Fixid", 2100, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfSelectOutLabelFixID_", 2311975214, "SQEX.Ebony.Std.Fixid", 2104, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfSelectMoveLeftFixID_", 3128765128, "SQEX.Ebony.Std.Fixid", 2108, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfSelectMoveRightFixID_", 4054135835, "SQEX.Ebony.Std.Fixid", 2112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfMcRolesSelectFixID_", 4170224055, "SQEX.Ebony.Std.Fixid", 2116, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfCharaInLabelFixID_", 3660646898, "SQEX.Ebony.Std.Fixid", 2120, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfCharaLoopLabelFixID_", 3151777653, "SQEX.Ebony.Std.Fixid", 2124, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfCharaOutLabelFixID_", 4282202811, "SQEX.Ebony.Std.Fixid", 2128, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLineInLabelFixID_", 2034173955, "SQEX.Ebony.Std.Fixid", 2132, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLineLoopLabelFixID_", 711215072, "SQEX.Ebony.Std.Fixid", 2136, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLineOutLabelFixID_", 2742180116, "SQEX.Ebony.Std.Fixid", 2140, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLineMoveTopFixID_", 3393681788, "SQEX.Ebony.Std.Fixid", 2144, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLineMoveBottomFixID_", 3325589540, "SQEX.Ebony.Std.Fixid", 2148, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("connectedSwfPin_", 3223910404, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("linePin_", 3458259875, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("roloesSelectListPin_", 3033171663, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2328, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("changed_", 939093132, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2416, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("L1pushed_", 1582319208, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2512, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("R1pushed_", 3372510962, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2608, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Decide_", 2465472314, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2704, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("closed_", 36233838, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2800, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outSelectValue_", 507372225, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}