using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Vfx
{
    public partial class LmEnvironmentVFXEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.Vfx.LmEnvironmentVFXElement> foliages_= new List<Black.Entity.Vfx.LmEnvironmentVFXElement>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmEnvironmentVFXEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Vfx.LmEnvironmentVFXEntity", 0, Black.Entity.Vfx.LmEnvironmentVFXEntity.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.Entity.Vfx.LmEnvironmentVFXEntity", base.GetFieldProperties(), -1969202926, -963177189);
            
			
			
			fieldProperties.AddProperty(new Property("foliages_", 2396713178, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Vfx.LmEnvironmentVFXElement* >", 64, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}