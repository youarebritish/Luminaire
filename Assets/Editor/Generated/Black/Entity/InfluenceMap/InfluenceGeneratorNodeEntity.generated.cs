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
            return fieldProperties;
        }

		
    }
}