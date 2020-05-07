using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator
{
    public partial class SequenceOperatorSwitchValueIntToFixid : Black.Sequence.Operator.SequenceOperatorCalculateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputValuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputValue_;
		public int condition1_;
		public int condition2_;
		public int condition3_;
		public int condition4_;
		public int condition5_;
		public int condition6_;
		public int condition7_;
		public int condition8_;
		public int condition9_;
		public int condition10_;
		public int condition11_;
		public int condition12_;
		public int condition13_;
		public uint resultValue1_;
		public uint resultValue2_;
		public uint resultValue3_;
		public uint resultValue4_;
		public uint resultValue5_;
		public uint resultValue6_;
		public uint resultValue7_;
		public uint resultValue8_;
		public uint resultValue9_;
		public uint resultValue10_;
		public uint resultValue11_;
		public uint resultValue12_;
		public uint resultValue13_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorSwitchValueIntToFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.SequenceOperatorSwitchValueIntToFixid", 0, Black.Sequence.Operator.SequenceOperatorSwitchValueIntToFixid.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.SequenceOperatorSwitchValueIntToFixid", base.GetFieldProperties(), -1590707014, -252086618);
            
			fieldProperties.AddProperty(new Property("inputValuePin_", 235825496, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 136, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputValue_", 232220166, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition1_", 2303665382, "int", 312, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition2_", 3376888545, "int", 316, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition3_", 3377035640, "int", 320, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition4_", 3376594355, "int", 324, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition5_", 2302973834, "int", 328, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition6_", 2302532549, "int", 332, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition7_", 3376447260, "int", 336, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition8_", 3375902807, "int", 340, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition9_", 2302385454, "int", 344, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition10_", 2690813720, "int", 348, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition11_", 2690666625, "int", 352, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition12_", 3764875526, "int", 356, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition13_", 3764728431, "int", 360, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue1_", 1631665473, "SQEX.Ebony.Std.Fixid", 364, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue2_", 2705874374, "SQEX.Ebony.Std.Fixid", 368, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue3_", 2705727279, "SQEX.Ebony.Std.Fixid", 372, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue4_", 1631121020, "SQEX.Ebony.Std.Fixid", 376, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue5_", 2704741541, "SQEX.Ebony.Std.Fixid", 380, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue6_", 2705182826, "SQEX.Ebony.Std.Fixid", 384, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue7_", 1631268115, "SQEX.Ebony.Std.Fixid", 388, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue8_", 2704197088, "SQEX.Ebony.Std.Fixid", 392, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue9_", 2704049993, "SQEX.Ebony.Std.Fixid", 396, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue10_", 928135993, "SQEX.Ebony.Std.Fixid", 400, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue11_", 2002050704, "SQEX.Ebony.Std.Fixid", 404, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue12_", 928533351, "SQEX.Ebony.Std.Fixid", 408, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultValue13_", 928680446, "SQEX.Ebony.Std.Fixid", 412, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}