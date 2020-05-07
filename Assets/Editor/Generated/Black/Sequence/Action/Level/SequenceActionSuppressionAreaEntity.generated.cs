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
            
			
			
			return fieldProperties;
        }

		
    }
}