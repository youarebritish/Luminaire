using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Move
{
    public partial class BodyLeafNodeAircraft : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt mode_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt actionType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat finishDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat targetUpdateDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat horizontalSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat verticalSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeAircraft();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeAircraft", 0, Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeAircraft.ObjectType, null, properties, 0, 296);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeAircraft", base.GetFieldProperties(), -846461479, -593490724);
            return fieldProperties;
        }

		
    }
}