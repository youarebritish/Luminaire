using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.Buddy
{
    public partial class AILeafNodeRegisterActorNumQuery : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt queryIndex;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum distType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum distTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum angleType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum angleTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum startDirection;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat startAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum endDirection;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat endAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyA;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyB;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyC;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyD;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkNoctis;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkBuddy;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRegisterActorNumQuery();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.Buddy.AILeafNodeRegisterActorNumQuery", 0, Black.AIGraph.LeafNode.AI.Function.Buddy.AILeafNodeRegisterActorNumQuery.ObjectType, null, properties, 0, 600);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.Buddy.AILeafNodeRegisterActorNumQuery", base.GetFieldProperties(), 2028584718, 64550806);
            
			fieldProperties.AddProperty(new Property("queryIndex", 2825235961, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distType", 1816005345, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distTarget", 2390028988, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minDistance", 2940658544, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxDistance", 1654243094, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("angleType", 4161737328, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("angleTarget", 1930699009, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startDirection", 1384315384, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 280, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startAngle", 3663374774, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 312, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endDirection", 349937775, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 344, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endAngle", 2845693673, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 376, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkEnemyA", 3304042540, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 408, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkEnemyB", 3354375397, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 440, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkEnemyC", 3337597778, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 472, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkEnemyD", 3253709683, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 504, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkNoctis", 1212995023, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 536, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkBuddy", 651412069, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 568, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}