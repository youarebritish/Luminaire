using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetSuppressionAreaSuppressed : Black.Sequence.Action.Level.SequenceActionSuppressionAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSuppressed;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outAllSuppressed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin latestSuppressedAreaOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetSuppressionAreaSuppressed();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetSuppressionAreaSuppressed", 0, Black.Sequence.Action.Level.SequenceActionGetSuppressionAreaSuppressed.ObjectType, null, properties, 0, 1032);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetSuppressionAreaSuppressed", base.GetFieldProperties(), -320970487, -1967206220);
            
			
			
			return fieldProperties;
        }

		
    }
}