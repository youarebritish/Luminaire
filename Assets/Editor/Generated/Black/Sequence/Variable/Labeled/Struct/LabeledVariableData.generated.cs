using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.Labeled.Struct
{
    public partial class LabeledVariableData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint label_;
		public int labelType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LabeledVariableData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.Labeled.Struct.LabeledVariableData", 0, Black.Sequence.Variable.Labeled.Struct.LabeledVariableData.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.Labeled.Struct.LabeledVariableData", base.GetFieldProperties(), -2121011631, 655723835);
            
			
			
			fieldProperties.AddProperty(new Property("label_", 3520738310, "SQEX.Ebony.Std.Fixid", 8, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelType_", 3504579550, "SQEX.Ebony.Framework.Sequence.SequenceValue.ValueType", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}