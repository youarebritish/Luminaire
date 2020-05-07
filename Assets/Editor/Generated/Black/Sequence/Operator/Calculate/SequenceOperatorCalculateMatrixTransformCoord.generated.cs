using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator.Calculate
{
    public partial class SequenceOperatorCalculateMatrixTransformCoord : Black.Sequence.Operator.SequenceOperatorCalculateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin matrixPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin plusSignPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin resultPin_;
		public int useMatrixType_;
		public UnityEngine.Vector4 offset_;
		public bool plusSign_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorCalculateMatrixTransformCoord();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.Calculate.SequenceOperatorCalculateMatrixTransformCoord", 0, Black.Sequence.Operator.Calculate.SequenceOperatorCalculateMatrixTransformCoord.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.Calculate.SequenceOperatorCalculateMatrixTransformCoord", base.GetFieldProperties(), 2068505923, -394840808);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("matrixPin_.pinName_", 714055763, "Base.String", 144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("matrixPin_.name_", 378248766, "Base.String", 160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("matrixPin_.connections_", 1920509988, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 176, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("matrixPin_.pinValueType_", 26180343, "Base.String", 208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetPin_.pinName_", 3857530301, "Base.String", 232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetPin_.name_", 1495859656, "Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetPin_.connections_", 62799878, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 264, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("offsetPin_.pinValueType_", 3124797965, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("plusSignPin_.pinName_", 1130167291, "Base.String", 320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("plusSignPin_.name_", 334420214, "Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("plusSignPin_.connections_", 4076515596, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 352, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("plusSignPin_.pinValueType_", 3414900943, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultPin_.pinName_", 2322612779, "Base.String", 408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultPin_.name_", 1595647398, "Base.String", 424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultPin_.connections_", 3755067484, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 440, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("resultPin_.pinValueType_", 623771647, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("matrixPin_", 1650836828, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 136, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetPin_", 3742051434, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("plusSignPin_", 22502164, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultPin_", 858122852, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMatrixType_", 2102416110, "Black.Sequence.Operator.Calculate.SequenceOperatorCalculateMatrixTransformCoord.PresetMatrixType", 488, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("offset_", 1294275471, "SQEX.Luminous.Math.VectorA", 496, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("plusSign_", 2337032721, "bool", 512, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}