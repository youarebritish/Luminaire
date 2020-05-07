using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Move
{
    public partial class BodyLeafNodeJumpController : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat YTransScale;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat MinTimeInVelocityInterpolation;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat MaxTimeInVelocityInterpolation;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat MaxCorrectionVelocity;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat TimeInTurning;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool KeepYTransConstant;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeJumpController();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeJumpController", 0, Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeJumpController.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeJumpController", base.GetFieldProperties(), -1139370473, -503639187);
            return fieldProperties;
        }

		
    }
}