using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Nav
{
    public partial class SmartWaypointEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourceFileName_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SmartWaypointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Nav.SmartWaypointEntity", 0, Black.Entity.Nav.SmartWaypointEntity.ObjectType, null, properties, 0, 168);
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

            fieldProperties = new PropertyContainer("Black.Entity.Nav.SmartWaypointEntity", base.GetFieldProperties(), -713741991, 1436506583);
            
			
			
			return fieldProperties;
        }

		
    }
}