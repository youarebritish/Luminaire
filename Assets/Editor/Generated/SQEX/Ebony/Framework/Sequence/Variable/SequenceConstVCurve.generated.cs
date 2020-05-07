using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceConstVCurve : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstCurveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valuePinZ_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valuePinY_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valuePinX_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valuePinVector_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstVCurve();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstVCurve", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceConstVCurve.ObjectType, null, properties, 0, 648);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstVCurve", base.GetFieldProperties(), -815233650, -201796759);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("timePin_", 1829901092, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 88, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timePin_.pinName_", 1111181931, "Base.String", 96, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timePin_.name_", 1640943846, "Base.String", 112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timePin_.connections_", 2610342556, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 128, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("timePin_.pinValueType_", 4126225215, "Base.String", 160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isEndPin_", 3349276442, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isEndPin_.pinName_", 1551032973, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isEndPin_.name_", 3925926168, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isEndPin_.connections_", 550020790, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("isEndPin_.pinValueType_", 4127537245, "Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("time_", 2171152225, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("anchorPointList_", 915962875, "SQEX.Ebony.Framework.TimeControl.AnchorPointList", 272, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("anchorPointList_.anchorPoints_", 273432090, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.TimeControl.AnchorPoint* >", 280, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinZ_.pinName_", 888271485, "Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinZ_.name_", 1096358024, "Base.String", 320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinZ_.connections_", 470025670, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 336, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinZ_.pinValueType_", 1699442125, "Base.String", 368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinY_.pinName_", 2111818996, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinY_.name_", 3770313743, "Base.String", 408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinY_.connections_", 1371233951, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 424, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinY_.pinValueType_", 4040651026, "Base.String", 456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinX_.pinName_", 1886909875, "Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinX_.name_", 1188587742, "Base.String", 496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinX_.connections_", 1701684292, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 512, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinX_.pinValueType_", 2647206423, "Base.String", 544, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinVector_.pinName_", 1896173542, "Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinVector_.name_", 2833082929, "Base.String", 584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinVector_.connections_", 3998708401, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 600, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("valuePinVector_.pinValueType_", 3449433448, "Base.String", 632, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("valuePinZ_", 2798771114, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 296, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valuePinY_", 2798226661, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 384, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valuePinX_", 1724709308, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valuePinVector_", 714251875, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}