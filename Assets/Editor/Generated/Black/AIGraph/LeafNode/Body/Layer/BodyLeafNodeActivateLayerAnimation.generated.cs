using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Layer
{
    public partial class BodyLeafNodeActivateLayerAnimation : Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeRequestLayerAnimation
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString graphId;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat beginBlendTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isMirrored;
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

            var dummy = new BodyLeafNodeActivateLayerAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeActivateLayerAnimation", 0, Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeActivateLayerAnimation.ObjectType, null, properties, 0, 688);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeActivateLayerAnimation", base.GetFieldProperties(), -1151088719, 419368791);
            
			fieldProperties.AddProperty(new Property("graphId", 3376006442, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString", 272, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("beginBlendTime", 1166606572, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 328, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isMirrored", 1314853667, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 360, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("matchTrigger_", 4001753971, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 392, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rootRotationType_", 739220712, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 424, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rootTranslationType_", 3221812513, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 456, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("freezeSource_", 3813934752, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 488, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("freezeTarget_", 38250036, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 520, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noAnimFacingRecompute_", 3561541146, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 552, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noAnimOriginRecompute_", 3545419306, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 584, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lockAnimFacing_", 4015675870, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 616, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lockAnimOrigin_", 4232392878, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 648, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}