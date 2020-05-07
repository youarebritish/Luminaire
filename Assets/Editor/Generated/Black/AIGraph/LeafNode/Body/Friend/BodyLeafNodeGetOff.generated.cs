using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Friend
{
    public partial class BodyLeafNodeGetOff : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rideTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum matchTrigger_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rootRotationType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rootTranslationType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool freezeSource_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool freezeTarget_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool noAnimFacingRecompute_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool noAnimOriginRecompute_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool lockAnimFacing_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool lockAnimOrigin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeGetOff();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Friend.BodyLeafNodeGetOff", 0, Black.AIGraph.LeafNode.Body.Friend.BodyLeafNodeGetOff.ObjectType, null, properties, 0, 424);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Friend.BodyLeafNodeGetOff", base.GetFieldProperties(), 1500020008, -976951307);
            
			fieldProperties.AddProperty(new Property("rideTarget", 4176235954, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("matchTrigger_", 4001753971, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rootRotationType_", 739220712, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rootTranslationType_", 3221812513, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("freezeSource_", 3813934752, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("freezeTarget_", 38250036, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noAnimFacingRecompute_", 3561541146, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noAnimOriginRecompute_", 3545419306, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 280, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lockAnimFacing_", 4015675870, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 312, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lockAnimOrigin_", 4232392878, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 344, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}