using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionSetSlow : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin set_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin toggle_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int taskTimeRateLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin timeRatePin_;
		public float timeRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSlow();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionSetSlow", 0, Black.Sequence.Action.System.SequenceActionSetSlow.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionSetSlow", base.GetFieldProperties(), 892586365, -388074865);
            return fieldProperties;
        }

		
    }
}