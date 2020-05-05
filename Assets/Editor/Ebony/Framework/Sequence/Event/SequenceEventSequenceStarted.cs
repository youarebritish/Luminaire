using Ebony.Framework.Node;
using Ebony.Framework.Sequence;
using Luminous.Core.Object;
using System.Collections.Generic;

namespace Ebony.Framework.Sequence.Event
{
    public class SequenceEventSequenceStarted : SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;

        public GraphTriggerOutputPin out_ { get; set; } = new GraphTriggerOutputPin();

        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventSequenceStarted();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Event.SequenceEventSequenceStarted", 0, SequenceEvent.ObjectType, Construct, properties, 1, 88);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Event.SequenceEventSequenceStarted", base.GetFieldProperties(), -1818037369, -2072216373);
            fieldProperties.AddProperty(new Property("out_", 291734708, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 96, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
            return fieldProperties;
        }

        private static BaseObject Construct()
        {
            return new SequenceEventSequenceStarted();
        }
    }
}
