using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class DynamicWeatherEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool update_;
		public float weatherTransitionTime_;
		public string weatherFilePath_;
		public bool reload_;
		public uint defaultClimateId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DynamicWeatherEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.DynamicWeatherEntity", 0, Black.Entity.Data.DynamicWeatherEntity.ObjectType, null, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.DynamicWeatherEntity", base.GetFieldProperties(), 1129578747, 593791143);
            return fieldProperties;
        }

		
    }
}