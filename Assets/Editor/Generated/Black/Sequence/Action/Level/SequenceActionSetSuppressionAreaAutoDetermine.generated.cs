using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetSuppressionAreaAutoDetermine : Black.Sequence.Action.Level.SequenceActionSuppressionAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool autoDetermineStatus_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSuppressionAreaAutoDetermine();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetSuppressionAreaAutoDetermine", 0, Black.Sequence.Action.Level.SequenceActionSetSuppressionAreaAutoDetermine.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetSuppressionAreaAutoDetermine", base.GetFieldProperties(), 958334875, -191023260);
            return fieldProperties;
        }

		
    }
}