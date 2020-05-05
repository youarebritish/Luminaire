using Ebony.Framework.Node;
using Luminous.Core.Object;
using System.Collections.Generic;

namespace Ebony.Framework.Sequence
{
    public class SequenceNode : GraphNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;

        public List<GraphPin> refInPorts_ { get; set; } = new List<GraphPin>();
        public List<GraphPin> refOutPorts_ { get; set; } = new List<GraphPin>();

        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceNode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.SequenceNode", 0, GraphNode.ObjectType, Construct, properties, 1, 88);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.SequenceNode", base.GetFieldProperties(), -480397013, -1124064336);
            fieldProperties.AddProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
            fieldProperties.AddProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
            return fieldProperties;
        }

        private static BaseObject Construct()
        {
            return new SequenceNode();
        }
    }
}
