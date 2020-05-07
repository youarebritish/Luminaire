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
            
			
			
			return fieldProperties;
        }

		
    }
}