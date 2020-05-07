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
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetType.propertyId_", 3734264599, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetType.indexOfLinkedProperty_", 1847653832, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetType.value_", 1252748644, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("positionType.propertyId_", 4016536501, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("positionType.indexOfLinkedProperty_", 2635380270, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("positionType.value_", 3130714414, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("warpTarget.propertyId_", 3532832525, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("warpTarget.indexOfLinkedProperty_", 1061535334, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("warpTarget.value_", 2664712182, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("obstructed.propertyId_", 4049781651, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("obstructed.indexOfLinkedProperty_", 844615804, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("obstructed.value_", 3189754088, "bool", 176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useNearestPointOnNavMesh.propertyId_", 2267740160, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useNearestPointOnNavMesh.indexOfLinkedProperty_", 3655001941, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useNearestPointOnNavMesh.value_", 3294643957, "bool", 208, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("warpOffset.propertyId_", 1541456939, "int", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("warpOffset.indexOfLinkedProperty_", 3269552436, "int", 236, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("warpOffset.value_", 2346662864, "Luminous.Math.VectorA", 256, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveDistance.propertyId_", 4243939260, "int", 296, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveDistance.indexOfLinkedProperty_", 2667239753, "int", 300, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveDistance.value_", 2607799961, "float", 312, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useRotateTarget.propertyId_", 2301576481, "int", 328, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useRotateTarget.indexOfLinkedProperty_", 823373234, "int", 332, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useRotateTarget.value_", 3650506674, "bool", 344, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationType.propertyId_", 4210950720, "int", 360, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationType.indexOfLinkedProperty_", 3472041621, "int", 364, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationType.value_", 3411654453, "int", 376, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotateTarget.propertyId_", 3917172420, "int", 392, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotateTarget.indexOfLinkedProperty_", 243348337, "int", 396, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotateTarget.value_", 3932650673, "int", 408, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("divisionNumber.propertyId_", 81411900, "int", 424, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("divisionNumber.indexOfLinkedProperty_", 54764489, "int", 428, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("divisionNumber.value_", 3260614937, "int", 440, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resetMotion.propertyId_", 1951199581, "int", 456, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resetMotion.indexOfLinkedProperty_", 1659506230, "int", 460, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resetMotion.value_", 1854383590, "bool", 472, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
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