using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSuppressionAreaEntity : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Entity.Node.SuppressionAreaEntity entityPointer_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin entityOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin activeMessageOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin suppressedMessageOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin determineStatusOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin progressOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSuppressionAreaEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSuppressionAreaEntity", 0, Black.Sequence.Action.Level.SequenceActionSuppressionAreaEntity.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSuppressionAreaEntity", base.GetFieldProperties(), -464940982, 1732895603);
            
			fieldProperties.AddProperty(new Property("entityPointer_", 3527687820, "Black.Entity.Node.SuppressionAreaEntity", 176, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			fieldProperties.AddProperty(new Property("entityOut_", 549713923, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("activeMessageOut_", 3335436887, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("suppressedMessageOut_", 3778338271, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("determineStatusOut_", 2380942249, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressOut_", 2318921551, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}