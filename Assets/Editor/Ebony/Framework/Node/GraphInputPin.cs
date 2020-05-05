using Ebony.Framework.Sequence;
using Luminous.Core.Object;
using System.Collections.Generic;

namespace Ebony.Framework.Node
{
    public class GraphInputPin : GraphPin
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;

        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GraphInputPin();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Node.GraphInputPin", 0, GraphPin.ObjectType, Construct, properties, 1, 88);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Node.GraphInputPin", base.GetFieldProperties(), -1818037369, -2072216373);
            return fieldProperties;
        }

        private static BaseObject Construct()
        {
            return new GraphInputPin();
        }
    }
}
