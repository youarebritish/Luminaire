using Luminous.Core.Object;

namespace Ebony.Framework.Node
{
    public class GraphNode : Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;

        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GraphNode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Actor.ActorPackageBase", 0, Luminous.Core.Object.Object.ObjectType, Construct, properties, 1, 16);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Node.GraphNode", base.GetFieldProperties(), 2064925350, -133472657);
            return fieldProperties;
        }

        private static BaseObject Construct()
        {
            return new GraphNode();
        }
    }
}
