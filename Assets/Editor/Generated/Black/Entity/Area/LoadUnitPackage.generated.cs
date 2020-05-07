using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Area
{
    public partial class LoadUnitPackage : Black.Entity.EntityPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 min_;
		public UnityEngine.Vector4 max_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LoadUnitPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Area.LoadUnitPackage", 0, Black.Entity.Area.LoadUnitPackage.ObjectType, null, properties, 0, 688);
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

            fieldProperties = new PropertyContainer("Black.Entity.Area.LoadUnitPackage", base.GetFieldProperties(), 609042719, -1283553562);
            return fieldProperties;
        }

		
    }
}