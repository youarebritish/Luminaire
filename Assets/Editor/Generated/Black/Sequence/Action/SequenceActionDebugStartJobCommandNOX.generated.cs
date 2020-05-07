using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action
{
    public partial class SequenceActionDebugStartJobCommandNOX : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin jobcommand_id;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugStartJobCommandNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.SequenceActionDebugStartJobCommandNOX", 0, Black.Sequence.Action.SequenceActionDebugStartJobCommandNOX.ObjectType, null, properties, 0, 648);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.SequenceActionDebugStartJobCommandNOX", base.GetFieldProperties(), 915869185, 1146942950);
            return fieldProperties;
        }

		
    }
}