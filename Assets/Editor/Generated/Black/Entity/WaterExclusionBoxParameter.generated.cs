using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class WaterExclusionBoxParameter : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 localPosition_;
		public UnityEngine.Vector4 scale_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WaterExclusionBoxParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WaterExclusionBoxParameter", 0, Black.Entity.WaterExclusionBoxParameter.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.Entity.WaterExclusionBoxParameter", base.GetFieldProperties(), -1818517810, -951594638);
            
			
			
			return fieldProperties;
        }

		
    }
}