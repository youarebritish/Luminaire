using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control
{
    public partial class SequenceActionControlStartSequenceFixid : SQEX.Ebony.Framework.Sequence.Control.SequenceControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin playInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin owner_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin lastSceneKeepPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actor1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actor2Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin vector1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin float1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin int1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin animationIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin animationDurationPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin commandSetPin_;
		public uint label_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlStartSequenceFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.SequenceActionControlStartSequenceFixid", 0, Black.Sequence.Control.SequenceActionControlStartSequenceFixid.ObjectType, null, properties, 0, 1584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.SequenceActionControlStartSequenceFixid", base.GetFieldProperties(), -1766638776, 1078423038);
            
			fieldProperties.AddProperty(new Property("playInputPin_", 2496327421, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopInputPin_", 783642039, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopPin_", 2226130577, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("owner_", 3701309137, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastSceneKeepPin_", 2018536486, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor1Pin_", 2407986413, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 736, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor2Pin_", 3478505912, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 824, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("vector1Pin_", 1087191029, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 912, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("float1Pin_", 467152076, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1000, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("int1Pin_", 554980921, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1088, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animationIdPin_", 2814382568, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animationDurationPin_", 3940092225, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("commandSetPin_", 1145493554, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("label_", 3520738310, "SQEX.Ebony.Std.Fixid", 1440, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}