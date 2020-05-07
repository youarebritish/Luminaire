using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Move
{
    public partial class BodyLeafNodeMoveController : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat AbsDegreeForCounterInLocomotion;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat AbsDegreeForCounterInCounter;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat MaskingTimeForReturningIdleInStarting;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool IsCheckMoveStop;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeMoveController();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeMoveController", 0, Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeMoveController.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeMoveController", base.GetFieldProperties(), -1190219961, -1074410515);
            
			
			
			return fieldProperties;
        }

		
    }
}