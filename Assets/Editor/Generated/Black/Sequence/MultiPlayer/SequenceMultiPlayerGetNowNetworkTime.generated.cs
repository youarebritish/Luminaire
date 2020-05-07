using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerGetNowNetworkTime : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueOffset_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueWithoutSecond_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueSecond_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueYear_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueDifferenceSecond_;
		public bool isLocalTime_;
		public bool isMachineTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerGetNowNetworkTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetNowNetworkTime", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerGetNowNetworkTime.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetNowNetworkTime", base.GetFieldProperties(), -1929633700, 622981554);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inValueOffset_.pinName_", 2763644152, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inValueOffset_.name_", 3734618195, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inValueOffset_.connections_", 2034210619, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("inValueOffset_.pinValueType_", 1688367494, "Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueWithoutSecond_.pinName_", 1851412752, "Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueWithoutSecond_.name_", 4165565051, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueWithoutSecond_.connections_", 559486483, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 304, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outValueWithoutSecond_.pinValueType_", 1823874606, "Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueSecond_.pinName_", 98051276, "Base.String", 360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueSecond_.name_", 1283861879, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueSecond_.connections_", 862137943, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 392, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outValueSecond_.pinValueType_", 1323181050, "Base.String", 424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueYear_.pinName_", 1743601033, "Base.String", 448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueYear_.name_", 2088791444, "Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueYear_.connections_", 1849844970, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 480, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outValueYear_.pinValueType_", 1813379785, "Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueDifferenceSecond_.pinName_", 3371928951, "Base.String", 536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueDifferenceSecond_.name_", 2957013026, "Base.String", 552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueDifferenceSecond_.connections_", 586935408, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 568, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outValueDifferenceSecond_.pinValueType_", 3074080427, "Base.String", 600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("inValueOffset_", 1339032737, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueWithoutSecond_", 3986074921, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueSecond_", 2297177389, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueYear_", 3412223982, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueDifferenceSecond_", 2206953752, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLocalTime_", 2284894410, "bool", 616, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isMachineTime_", 2751215032, "bool", 617, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}