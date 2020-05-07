using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS
{
    public partial class TacticalPointNodeEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isDebugDraw_;
		public int groupId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TacticalPointNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.TacticalPointNodeEntity", 0, Black.Entity.TPS.TacticalPointNodeEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.TacticalPointNodeEntity", base.GetFieldProperties(), -549509829, -463016054);
            return fieldProperties;
        }

		
    }
}