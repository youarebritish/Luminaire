using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientSmartLocationEntity : Black.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool useSpawnActivator_;
		public int spawnActivatorPeriod_;
		public int scheduleBeginHour_;
		public int scheduleBeginMinute_;
		public int scheduleEndHour_;
		public int scheduleEndMinute_;
		public bool debugDraw_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientSmartLocationEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientSmartLocationEntity", 0, Black.AI.Ambient.AmbientSmartLocationEntity.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientSmartLocationEntity", base.GetFieldProperties(), -2019663088, -1469277910);
            
			
			
			return fieldProperties;
        }

		
    }
}