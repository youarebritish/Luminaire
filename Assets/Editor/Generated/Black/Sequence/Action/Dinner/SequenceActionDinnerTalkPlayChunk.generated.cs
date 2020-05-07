using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Dinner
{
    public partial class SequenceActionDinnerTalkPlayChunk : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin decide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin training_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin indexInput_;
		public int state_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDinnerTalkPlayChunk();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Dinner.SequenceActionDinnerTalkPlayChunk", 0, Black.Sequence.Action.Dinner.SequenceActionDinnerTalkPlayChunk.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Dinner.SequenceActionDinnerTalkPlayChunk", base.GetFieldProperties(), 28071210, -347652521);
            return fieldProperties;
        }

		
    }
}