using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIChocoboGetStatus : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int target_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin floatPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin intPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin boolPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocoboPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIChocoboGetStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIChocoboGetStatus", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIChocoboGetStatus.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIChocoboGetStatus", base.GetFieldProperties(), 223948166, 1862390001);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("floatPin_.pinName_", 2851140008, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("floatPin_.name_", 3305865283, "Base.String", 216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("floatPin_.connections_", 2208844619, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 232, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("floatPin_.pinValueType_", 631695350, "Base.String", 264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("intPin_.pinName_", 1384764153, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("intPin_.name_", 2320908356, "Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("intPin_.connections_", 3380409850, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 320, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("intPin_.pinValueType_", 1524388025, "Base.String", 352, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("boolPin_.pinName_", 2542128832, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("boolPin_.name_", 737721771, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("boolPin_.connections_", 521507299, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("boolPin_.pinValueType_", 744765598, "Base.String", 440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("chocoboPin_.pinName_", 1962829841, "Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("chocoboPin_.name_", 1677913036, "Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("chocoboPin_.connections_", 1283861074, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 496, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("chocoboPin_.pinValueType_", 1788713505, "Base.String", 528, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("target_", 1693858869, "Black.Sequence.Actor.AI.Vehicle.SequenceActionAIChocoboGetStatus.Target", 184, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("floatPin_", 1989408561, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 192, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("intPin_", 2077177726, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("boolPin_", 4073925305, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("chocoboPin_", 2245674118, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}