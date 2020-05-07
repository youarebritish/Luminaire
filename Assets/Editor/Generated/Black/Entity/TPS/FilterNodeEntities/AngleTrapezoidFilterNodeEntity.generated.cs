using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS.FilterNodeEntities
{
    public partial class AngleTrapezoidFilterNodeEntity : Black.Entity.TPS.FilterDescriptorNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int subject_;
		public float weight_;
		public float innerArcAngle_;
		public float outerArcAngle_;
		public float offset_;
		public bool useWeightFlag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AngleTrapezoidFilterNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.FilterNodeEntities.AngleTrapezoidFilterNodeEntity", 0, Black.Entity.TPS.FilterNodeEntities.AngleTrapezoidFilterNodeEntity.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.FilterNodeEntities.AngleTrapezoidFilterNodeEntity", base.GetFieldProperties(), 221376936, -718567739);
            return fieldProperties;
        }

		
    }
}