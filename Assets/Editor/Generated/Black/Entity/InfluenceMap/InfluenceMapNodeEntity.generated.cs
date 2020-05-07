using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.InfluenceMap
{
    public partial class InfluenceMapNodeEntity : SQEX.Ebony.Framework.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint fixId_;
		public int decayType_;
		public int subject_;
		public int CellsPerAxis;
		public float CellSize;
		public float DecayRate;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InfluenceMapNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.InfluenceMap.InfluenceMapNodeEntity", 0, Black.Entity.InfluenceMap.InfluenceMapNodeEntity.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("Black.Entity.InfluenceMap.InfluenceMapNodeEntity", base.GetFieldProperties(), -644769796, 196132152);
            
			fieldProperties.AddProperty(new Property("fixId_", 861493870, "SQEX.Ebony.Std.Fixid", 208, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("decayType_", 1306619198, "Black.Entity.InfluenceMap.InfluenceMapNodeEntity.DecayType", 212, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("subject_", 3903058736, "Black.Entity.TPS.FallbackQueryDescriptorNodeEntity.SubjectType", 216, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("CellsPerAxis", 3797297648, "uint32_t", 220, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("CellSize", 149408908, "float", 224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("DecayRate", 436311455, "float", 228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}