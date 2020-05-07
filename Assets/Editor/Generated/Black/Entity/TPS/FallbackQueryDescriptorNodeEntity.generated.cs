using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS
{
    public partial class FallbackQueryDescriptorNodeEntity : Black.Entity.TPS.ValidatorDescriptorNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int pointFulfillment_;
		public int generatorType_;
		public int generatorSubject_;
		public float cellSize_;
		public int resolution_;
		public uint StaticSetfixId_;
		public int areaType_;
		public bool allowAIGraphOverride;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FallbackQueryDescriptorNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.FallbackQueryDescriptorNodeEntity", 0, Black.Entity.TPS.FallbackQueryDescriptorNodeEntity.ObjectType, null, properties, 0, 256);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.FallbackQueryDescriptorNodeEntity", base.GetFieldProperties(), 350278845, 1106426966);
            
			fieldProperties.AddProperty(new Property("pointFulfillment_", 937673006, "int", 208, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("generatorType_", 1382636183, "Black.Entity.TPS.FallbackQueryDescriptorNodeEntity.GeneratorType", 212, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("generatorSubject_", 2467175755, "Black.Entity.TPS.FallbackQueryDescriptorNodeEntity.SubjectType", 216, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("cellSize_", 1757174793, "float", 220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("resolution_", 2877627248, "uint32_t", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("StaticSetfixId_", 511699482, "SQEX.Ebony.Std.Fixid", 228, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("areaType_", 3864051017, "Black.Map.AreaManager.AREA_TYPE", 232, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("allowAIGraphOverride", 3076222124, "bool", 236, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}