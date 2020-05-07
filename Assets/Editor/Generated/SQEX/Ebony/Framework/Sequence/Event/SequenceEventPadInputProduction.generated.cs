using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Event
{
    public partial class SequenceEventPadInputProduction : SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInput
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventPadInputProduction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInputProduction", 0, SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInputProduction.ObjectType, null, properties, 0, 3568);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInputProduction", base.GetFieldProperties(), -1522255945, -833794091);
            return fieldProperties;
        }

		
    }
}