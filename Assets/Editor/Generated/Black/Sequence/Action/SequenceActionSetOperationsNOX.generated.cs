using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action
{
    public partial class SequenceActionSetOperationsNOX : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint operationUpId_;
		public uint operationLeftId_;
		public uint operationRightId_;
		public uint operationDownId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_down;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_right;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_left;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_up;
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

            var dummy = new SequenceActionSetOperationsNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.SequenceActionSetOperationsNOX", 0, Black.Sequence.Action.SequenceActionSetOperationsNOX.ObjectType, null, properties, 0, 928);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.SequenceActionSetOperationsNOX", base.GetFieldProperties(), 404723061, 1028481869);
            
			
			
			return fieldProperties;
        }

		
    }
}