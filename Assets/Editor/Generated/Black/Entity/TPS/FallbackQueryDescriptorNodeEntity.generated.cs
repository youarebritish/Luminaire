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
            
			
			
			return fieldProperties;
        }

		
    }
}