using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class LightMapBakeEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string saveFolder_;
		public string uvSaveFolder_;
		public float texelPerMeter_;
		public int bounceCount_;
		public int rayBandleCount_;
		public int bakeSetNumber_;
		public bool doBake_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LightMapBakeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.LightMapBakeEntity", 0, Black.Entity.Render.LightMapBakeEntity.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.LightMapBakeEntity", base.GetFieldProperties(), -921493706, -1709025812);
            
			
			
			return fieldProperties;
        }

		
    }
}