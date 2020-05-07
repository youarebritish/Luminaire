using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Menu
{
    public partial class SwfLabelAccessoryArrayItem : Black.Entity.Data.Menu.SwfArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint Label;
		public SQEX.Ebony.Framework.Entity.Entity Sound;
		public SQEX.Ebony.Framework.Entity.Entity Vfx;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SwfLabelAccessoryArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Menu.SwfLabelAccessoryArrayItem", 0, Black.Entity.Data.Menu.SwfLabelAccessoryArrayItem.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Menu.SwfLabelAccessoryArrayItem", base.GetFieldProperties(), 83842092, 2015568544);
            
			
			
			fieldProperties.AddProperty(new Property("Label", 2664231581, "SQEX.Ebony.Std.Fixid", 8, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Sound", 3016399412, "SQEX.Ebony.Framework.Entity.Entity", 16, 8, 1, Property.PrimitiveType.Pointer, 0, (char)0));
			fieldProperties.AddProperty(new Property("Vfx", 3972225919, "SQEX.Ebony.Framework.Entity.Entity", 24, 8, 1, Property.PrimitiveType.Pointer, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}