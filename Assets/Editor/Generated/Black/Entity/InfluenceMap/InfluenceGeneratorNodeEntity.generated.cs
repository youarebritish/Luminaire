using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.InfluenceMap
{
    public partial class InfluenceGeneratorNodeEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int subject_;
		public int type_;
		public int functionType_;
		public float heatStrength_;
		public float coneLength_;
		public float coneAngle_;
		public float radius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InfluenceGeneratorNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.InfluenceMap.InfluenceGeneratorNodeEntity", 0, Black.Entity.InfluenceMap.InfluenceGeneratorNodeEntity.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Entity.InfluenceMap.InfluenceGeneratorNodeEntity", base.GetFieldProperties(), 789233922, 1867069826);
            
			
			
			fieldProperties.AddProperty(new Property("subject_", 3903058736, "Black.Entity.TPS.FallbackQueryDescriptorNodeEntity.SubjectType", 64, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("type_", 3554705238, "Black.AI.InfluenceMap.InfluenceGeneratorDescriptor.InfluencerType", 68, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("functionType_", 1481648570, "Black.Entity.InfluenceMap.InfluenceGeneratorNodeEntity.GeneratorFunctionType", 72, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("heatStrength_", 2180386987, "float", 76, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("coneLength_", 4060966883, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("coneAngle_", 588901954, "float", 84, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}