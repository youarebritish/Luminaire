using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeWarpToTarget : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum positionType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum warpTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool obstructed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useNearestPointOnNavMesh;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector warpOffset;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxMoveDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useRotateTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rotationType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rotateTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt divisionNumber;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool resetMotion;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeWarpToTarget();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeWarpToTarget", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeWarpToTarget.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeWarpToTarget", base.GetFieldProperties(), 415373291, 1099973546);
            
			fieldProperties.AddProperty(new Property("targetType", 414363200, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("positionType", 3936293514, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("warpTarget", 2093075602, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("obstructed", 3601986444, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useNearestPointOnNavMesh", 1996145159, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("warpOffset", 2382928468, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 224, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxMoveDistance", 731086771, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 288, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useRotateTarget", 2371988758, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 320, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationType", 4014891207, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 352, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotateTarget", 183939723, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 384, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("divisionNumber", 1375336243, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 416, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resetMotion", 1512651906, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 448, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}