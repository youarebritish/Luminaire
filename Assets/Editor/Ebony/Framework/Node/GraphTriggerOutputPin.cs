using Ebony.Framework.Sequence;
using Luminous.Core.Object;
using System.Collections.Generic;

namespace Ebony.Framework.Node
{
    public class GraphTriggerOutputPin : GraphOutputPin
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;

        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GraphTriggerOutputPin();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 0, GraphOutputPin.ObjectType, Construct, properties, 1, 88);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", base.GetFieldProperties(), -1818037369, -2072216373);
            return fieldProperties;
        }

        private static BaseObject Construct()
        {
            return new GraphTriggerOutputPin();
        }
    }
}
