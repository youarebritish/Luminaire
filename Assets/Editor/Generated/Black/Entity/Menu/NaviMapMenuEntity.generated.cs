using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class NaviMapMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float timeMorning_;
		public float timeNoon_;
		public float timeEvening_;
		public float timeNight_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NaviMapMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.NaviMapMenuEntity", 0, Black.Entity.Menu.NaviMapMenuEntity.ObjectType, null, properties, 0, 2304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.NaviMapMenuEntity", base.GetFieldProperties(), 713013883, -1302053610);
            
			
			
			return fieldProperties;
        }

		
    }
}