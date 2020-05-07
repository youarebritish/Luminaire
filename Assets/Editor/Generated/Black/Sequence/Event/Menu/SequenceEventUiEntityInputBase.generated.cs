using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu
{
    public partial class SequenceEventUiEntityInputBase : Black.Sequence.Event.Menu.SequenceEventUiBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin0_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin7_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventUiEntityInputBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase", 0, Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase.ObjectType, null, properties, 0, 1088);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase", base.GetFieldProperties(), 2110746992, 1607532894);
            
			fieldProperties.AddProperty(new Property("pin0_", 1260278025, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 384, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin1_", 1260425120, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin2_", 186804599, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin3_", 1260719310, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin4_", 1259586477, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 736, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin5_", 1259733572, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 824, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin6_", 186216219, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 912, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pin7_", 186363314, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1000, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}