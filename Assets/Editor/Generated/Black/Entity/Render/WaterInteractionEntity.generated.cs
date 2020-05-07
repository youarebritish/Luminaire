using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class WaterInteractionEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public string ripplePath_;
		public string ripplePath1_;
		public string ripplePath2_;
		public string ripplePath3_;
		public float scaleHeight_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WaterInteractionEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.WaterInteractionEntity", 0, Black.Entity.Render.WaterInteractionEntity.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.WaterInteractionEntity", base.GetFieldProperties(), -373394928, 1273585722);
            
			
			
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 64, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ripplePath_", 2806033773, "Ebony.Base.String", 72, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("ripplePath1_", 1002449940, "Ebony.Base.String", 88, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("ripplePath2_", 1002597035, "Ebony.Base.String", 104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("ripplePath3_", 2076511746, "Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("scaleHeight_", 3088000587, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}