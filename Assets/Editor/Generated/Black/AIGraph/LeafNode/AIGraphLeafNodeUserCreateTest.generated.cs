using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode
{
    public partial class AIGraphLeafNodeUserCreateTest : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat time;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt atkType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid questId;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid animBBParam;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid bodyMessage;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum runStatus_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeUserCreateTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AIGraphLeafNodeUserCreateTest", 0, Black.AIGraph.LeafNode.AIGraphLeafNodeUserCreateTest.ObjectType, null, properties, 0, 248);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AIGraphLeafNodeUserCreateTest", base.GetFieldProperties(), -1915527401, -1917051943);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("time.propertyId_", 3228462299, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("time.indexOfLinkedProperty_", 2680208548, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("time.value_", 3952842656, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atkType.propertyId_", 395894166, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atkType.indexOfLinkedProperty_", 1777394547, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atkType.value_", 1959011863, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("questId.propertyId_", 2481838415, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("questId.indexOfLinkedProperty_", 1629551488, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("questId.value_", 2835864332, "SQEX.Ebony.Std.Fixid", 144, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParam.propertyId_", 3690357794, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParam.indexOfLinkedProperty_", 1013713495, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParam.value_", 2982589515, "SQEX.Ebony.Std.Fixid", 176, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage.propertyId_", 2119891499, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage.indexOfLinkedProperty_", 4149836596, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage.value_", 2521746896, "SQEX.Ebony.Std.Fixid", 208, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("runStatus_.propertyId_", 2206490070, "int", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("runStatus_.indexOfLinkedProperty_", 865550003, "int", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("runStatus_.value_", 1693055063, "int", 240, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("time", 1564253156, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("atkType", 1740275313, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("questId", 3161124712, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animBBParam", 2906189981, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bodyMessage", 1019129940, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("runStatus_", 2145749809, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}