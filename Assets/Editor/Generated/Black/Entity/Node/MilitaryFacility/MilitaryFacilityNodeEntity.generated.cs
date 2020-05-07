using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node.MilitaryFacility
{
    public partial class MilitaryFacilityNodeEntity : SQEX.Ebony.Framework.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float radius_;
		public bool isDebugDraw_;
		public float debugHeight_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MilitaryFacilityNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.MilitaryFacility.MilitaryFacilityNodeEntity", 0, Black.Entity.Node.MilitaryFacility.MilitaryFacilityNodeEntity.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.MilitaryFacility.MilitaryFacilityNodeEntity", base.GetFieldProperties(), 1021056588, -940286409);
            return fieldProperties;
        }

		
    }
}