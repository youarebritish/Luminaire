using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class NaviCurveProgressPointEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint labelId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NaviCurveProgressPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.NaviCurveProgressPointEntity", 0, Black.Entity.Node.NaviCurveProgressPointEntity.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.NaviCurveProgressPointEntity", base.GetFieldProperties(), 1073746251, -75145605);
            return fieldProperties;
        }

		
    }
}