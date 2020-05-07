using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Area
{
    public partial class HyperLodItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.Data.Area.MapLodItem> hyperLowItemList_;
		public IList<Black.Entity.Data.Area.MapLodItem> lodItemList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new HyperLodItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Area.HyperLodItem", 0, Black.Entity.Data.Area.HyperLodItem.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Area.HyperLodItem", base.GetFieldProperties(), 1121485182, 605620577);
            
			
			
			fieldProperties.AddProperty(new Property("hyperLowItemList_", 2017489063, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Area.MapLodItem* >", 8, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("lodItemList_", 340035472, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Area.MapLodItem* >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}