using Luminous.Core.Object;
using System.Collections.Generic;

namespace Ebony.Framework.Node
{
    public class GraphPin : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;

        public string pinName_ { get; set; }
        public string name_ { get; set; }
        public List<GraphPin> connections_ { get; set; } = new List<GraphPin>();

        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GraphPin();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Node.GraphPin", 0, GraphNode.ObjectType, Construct, properties, 1, 72);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Node.GraphPin", base.GetFieldProperties(), -1720989610, 895607396);
            fieldProperties.AddProperty(new Property("pinName_", 1657142480, "Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
            fieldProperties.AddProperty(new Property("name_", 182823483, "Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
            fieldProperties.AddProperty(new Property("connections_", 1444105939, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
            return fieldProperties;
        }

        private static BaseObject Construct()
        {
            return new GraphNode();
        }
    }
}
