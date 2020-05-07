using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetSuppressionAreaVisible : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public bool visible_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSuppressionAreaVisible();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetSuppressionAreaVisible", 0, Black.Sequence.Action.Level.SequenceActionSetSuppressionAreaVisible.ObjectType, null, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetSuppressionAreaVisible", base.GetFieldProperties(), 972475079, -720461736);
            return fieldProperties;
        }

		
    }
}