using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableSwfConnector : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int pinNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin8_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin32_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin31_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin30_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin29_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin28_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin27_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin26_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin25_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin24_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin23_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin22_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin21_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin20_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin19_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin18_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin17_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin16_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin15_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin14_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin13_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin12_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin11_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin10_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin9_;
		public string prefix1_;
		public string prefix2_;
		public string prefix3_;
		public string prefix4_;
		public string prefix5_;
		public string prefix6_;
		public string prefix7_;
		public string prefix8_;
		public string prefix9_;
		public string prefix10_;
		public string prefix11_;
		public string prefix12_;
		public string prefix13_;
		public string prefix14_;
		public string prefix15_;
		public string prefix16_;
		public string prefix17_;
		public string prefix18_;
		public string prefix19_;
		public string prefix20_;
		public string prefix21_;
		public string prefix22_;
		public string prefix23_;
		public string prefix24_;
		public string prefix25_;
		public string prefix26_;
		public string prefix27_;
		public string prefix28_;
		public string prefix29_;
		public string prefix30_;
		public string prefix31_;
		public string prefix32_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableSwfConnector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableSwfConnector", 0, Black.Sequence.Variable.SequenceVariableSwfConnector.ObjectType, null, properties, 0, 3456);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableSwfConnector", base.GetFieldProperties(), -1655035652, -1705851642);
            
			fieldProperties.AddProperty(new Property("pinNum_", 2027049857, "int", 88, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin8_", 941291293, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin7_", 2017471670, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin6_", 943556959, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 304, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin5_", 943409864, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin4_", 2017030385, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 480, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin3_", 2016883290, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin2_", 942968579, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin1_", 2016485932, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin32_", 2195376514, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin31_", 2194935229, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin30_", 1121314708, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin29_", 3598517886, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin28_", 3598370791, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin27_", 377612396, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin26_", 377465301, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin25_", 377906586, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin24_", 3598959171, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin23_", 3599503624, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1624, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin22_", 378053681, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1712, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin21_", 378598134, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin20_", 3599650719, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin19_", 2829245627, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin18_", 2829392722, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2064, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin17_", 2830922913, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin16_", 2831070008, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin15_", 1757449487, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2328, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin14_", 1757596582, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2416, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin13_", 1756463749, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin12_", 2830378460, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin11_", 2830525555, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin10_", 1757008202, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicVarInputPin9_", 2015206004, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix1_", 1054310805, "Ebony.Base.String", 2944, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix2_", 1054855258, "Ebony.Base.String", 2960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix3_", 4275907843, "Ebony.Base.String", 2976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix4_", 4276349128, "Ebony.Base.String", 2992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix5_", 1055002353, "Ebony.Base.String", 3008, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix6_", 1055443638, "Ebony.Base.String", 3024, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix7_", 4276496223, "Ebony.Base.String", 3040, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix8_", 1053177972, "Ebony.Base.String", 3056, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix9_", 4274230557, "Ebony.Base.String", 3072, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix10_", 3079881077, "Ebony.Base.String", 3088, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix11_", 3080028172, "Ebony.Base.String", 3104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix12_", 4153942883, "Ebony.Base.String", 3120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix13_", 3080322362, "Ebony.Base.String", 3136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix14_", 3080469457, "Ebony.Base.String", 3152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix15_", 4154384168, "Ebony.Base.String", 3168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix16_", 4154531263, "Ebony.Base.String", 3184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix17_", 3081013910, "Ebony.Base.String", 3200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix18_", 4152265597, "Ebony.Base.String", 3216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix19_", 3078748244, "Ebony.Base.String", 3232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix20_", 4266041748, "Ebony.Base.String", 3248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix21_", 1044694973, "Ebony.Base.String", 3264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix22_", 1045136258, "Ebony.Base.String", 3280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix23_", 4266188843, "Ebony.Base.String", 3296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix24_", 4266733296, "Ebony.Base.String", 3312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix25_", 1045283353, "Ebony.Base.String", 3328, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix26_", 1045827806, "Ebony.Base.String", 3344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix27_", 1045680711, "Ebony.Base.String", 3360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix28_", 4267321676, "Ebony.Base.String", 3376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix29_", 4267174581, "Ebony.Base.String", 3392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix30_", 2449410463, "Ebony.Base.String", 3408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix31_", 3523325174, "Ebony.Base.String", 3424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefix32_", 3522780721, "Ebony.Base.String", 3440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}