using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator
{
    public partial class SequenceOperatorSwitchValueStringToFixid : Black.Sequence.Operator.SequenceOperatorCalculateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputValuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin next_;
		public string condition1_;
		public string condition2_;
		public string condition3_;
		public string condition4_;
		public string condition5_;
		public string condition6_;
		public string condition7_;
		public string condition8_;
		public string condition9_;
		public string condition10_;
		public string condition11_;
		public string condition12_;
		public string condition13_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue1_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue2_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue3_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue4_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue5_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue6_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue7_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue8_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue9_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue10_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue11_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue12_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData resultValue13_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorSwitchValueStringToFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.SequenceOperatorSwitchValueStringToFixid", 0, Black.Sequence.Operator.SequenceOperatorSwitchValueStringToFixid.ObjectType, null, properties, 0, 816);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.SequenceOperatorSwitchValueStringToFixid", base.GetFieldProperties(), -681382879, -1894785155);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.pinName_", 3951781431, "Base.String", 144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.name_", 3208503266, "Base.String", 160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.connections_", 711615536, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 176, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.pinValueType_", 3717016939, "Base.String", 208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.pinName_", 1332032657, "Base.String", 232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.name_", 67830092, "Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.connections_", 1068318418, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 264, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.pinValueType_", 2971852705, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("next_.pinName_", 515319748, "Base.String", 320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("next_.name_", 3298011871, "Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("next_.connections_", 540653455, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 352, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("next_.pinValueType_", 1233410594, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue1_.value_", 3431658791, "SQEX.Ebony.Std.Fixid", 616, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue2_.value_", 310858658, "SQEX.Ebony.Std.Fixid", 632, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue3_.value_", 4175683709, "SQEX.Ebony.Std.Fixid", 648, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue4_.value_", 459331928, "SQEX.Ebony.Std.Fixid", 664, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue5_.value_", 2948385683, "SQEX.Ebony.Std.Fixid", 680, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue6_.value_", 3475942350, "SQEX.Ebony.Std.Fixid", 696, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue7_.value_", 369929401, "SQEX.Ebony.Std.Fixid", 712, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue8_.value_", 523290948, "SQEX.Ebony.Std.Fixid", 728, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue9_.value_", 4261428143, "SQEX.Ebony.Std.Fixid", 744, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue10_.value_", 1125779679, "SQEX.Ebony.Std.Fixid", 760, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue11_.value_", 2417753332, "SQEX.Ebony.Std.Fixid", 776, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue12_.value_", 1291602965, "SQEX.Ebony.Std.Fixid", 792, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resultValue13_.value_", 4069186010, "SQEX.Ebony.Std.Fixid", 808, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("inputValuePin_", 235825496, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 136, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputValue_", 232220166, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("next_", 2858489621, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition1_", 2303665382, "Ebony.Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition2_", 3376888545, "Ebony.Base.String", 416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition3_", 3377035640, "Ebony.Base.String", 432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition4_", 3376594355, "Ebony.Base.String", 448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition5_", 2302973834, "Ebony.Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition6_", 2302532549, "Ebony.Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition7_", 3376447260, "Ebony.Base.String", 496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition8_", 3375902807, "Ebony.Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition9_", 2302385454, "Ebony.Base.String", 528, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition10_", 2690813720, "Ebony.Base.String", 544, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition11_", 2690666625, "Ebony.Base.String", 560, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition12_", 3764875526, "Ebony.Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition13_", 3764728431, "Ebony.Base.String", 592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue1_", 1631665473, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 608, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue2_", 2705874374, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 624, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue3_", 2705727279, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 640, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue4_", 1631121020, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 656, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue5_", 2704741541, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 672, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue6_", 2705182826, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 688, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue7_", 1631268115, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 704, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue8_", 2704197088, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 720, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue9_", 2704049993, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 736, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue10_", 928135993, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 752, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue11_", 2002050704, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 768, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue12_", 928533351, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 784, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue13_", 928680446, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 800, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}