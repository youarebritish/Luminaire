using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceVariableActorVector : Black.Sequence.Actor.SequenceVariableActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outZ_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outY_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outX_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin vector_;
		public int kind_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableActorVector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceVariableActorVector", 0, Black.Sequence.Actor.SequenceVariableActorVector.ObjectType, null, properties, 0, 592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceVariableActorVector", base.GetFieldProperties(), 1145273089, 412994880);
            
			fieldProperties.AddProperty(new Property("outZ_", 1988621440, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outY_", 3062536151, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 320, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outX_", 1989018798, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 408, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("vector_", 1394133607, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 496, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("kind_", 3595366932, "Black.Sequence.Actor.SequenceVariableActorVector.ValueKind", 584, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}