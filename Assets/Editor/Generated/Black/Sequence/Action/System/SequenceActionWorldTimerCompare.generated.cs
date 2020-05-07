using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionWorldTimerCompare : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public int argumentNum_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin5_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin6_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notOutedPin_;
		public float fromHour1_;
		public float toHour1_;
		public float fromHour2_;
		public float toHour2_;
		public float fromHour3_;
		public float toHour3_;
		public float fromHour4_;
		public float toHour4_;
		public float fromHour5_;
		public float toHour5_;
		public float fromHour6_;
		public float toHour6_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionWorldTimerCompare();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionWorldTimerCompare", 0, Black.Sequence.Action.System.SequenceActionWorldTimerCompare.ObjectType, null, properties, 0, 1144);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionWorldTimerCompare", base.GetFieldProperties(), -408551304, -814545103);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.pinName_", 3330161590, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.name_", 192292993, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.connections_", 490033121, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayType_", 261766523, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayTime_", 1689218608, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayMaxTime_", 1529341114, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.pinName_", 3840578057, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.name_", 1571756820, "Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.connections_", 2564850026, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 320, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.delayType_", 1673337304, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.delayTime_", 946244883, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.delayMaxTime_", 3356122891, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.pinName_", 3835015824, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.name_", 1260203771, "Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.connections_", 1514737555, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 416, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.delayType_", 3037162365, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 448, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.delayTime_", 3186344010, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.delayMaxTime_", 3532913104, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.pinName_", 2108372239, "Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.name_", 51930346, "Base.String", 496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.connections_", 2102895720, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 512, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.delayType_", 3559438190, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 544, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.delayTime_", 1980050217, "float", 548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.delayMaxTime_", 428848789, "float", 552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.pinName_", 313276206, "Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.name_", 1630177705, "Base.String", 592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.connections_", 1564181273, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.delayType_", 1682814659, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 640, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.delayTime_", 1339094120, "float", 644, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.delayMaxTime_", 2802710946, "float", 648, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.pinName_", 2050397781, "Base.String", 672, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.name_", 929498832, "Base.String", 688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.connections_", 302849950, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 704, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.delayType_", 528860492, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 736, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.delayTime_", 24520063, "float", 740, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.delayMaxTime_", 1534969095, "float", 744, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.pinName_", 44210540, "Base.String", 768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.name_", 3391635415, "Base.String", 784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.connections_", 2463274423, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 800, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.delayType_", 2846700593, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 832, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.delayTime_", 349401190, "float", 836, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.delayMaxTime_", 3817562572, "float", 840, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("notOutedPin_.pinName_", 2956525406, "Base.String", 864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("notOutedPin_.name_", 113586457, "Base.String", 880, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("notOutedPin_.connections_", 4143782249, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 896, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("notOutedPin_.delayType_", 1930144979, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 928, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("notOutedPin_.delayTime_", 2502109368, "float", 932, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("notOutedPin_.delayMaxTime_", 4079824242, "float", 936, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("argumentNum_", 1806116595, "int", 272, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin1_", 1255203182, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin2_", 1254761897, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin3_", 1254908992, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin4_", 2328132155, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin5_", 2328279250, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin6_", 1254070349, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 760, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("notOutedPin_", 2255883979, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 856, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fromHour1_", 1789106799, "float", 952, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("toHour1_", 1193499946, "float", 956, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fromHour2_", 715192088, "float", 960, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("toHour2_", 1192955493, "float", 964, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fromHour3_", 715044993, "float", 968, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("toHour3_", 119438140, "float", 972, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fromHour4_", 1788665514, "float", 976, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("toHour4_", 1193941231, "float", 980, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fromHour5_", 714750803, "float", 984, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("toHour5_", 1194088326, "float", 988, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fromHour6_", 714603708, "float", 992, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("toHour6_", 119879425, "float", 996, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}