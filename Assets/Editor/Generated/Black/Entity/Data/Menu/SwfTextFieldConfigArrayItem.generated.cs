using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Menu
{
    public partial class SwfTextFieldConfigArrayItem : Black.Entity.Data.Menu.SwfArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint TextField;
		public int FontType;
		public int VerticalAlignType;
		public uint MovieClip;
		public bool IsEnableSoftWrap;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SwfTextFieldConfigArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem", 0, Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem", base.GetFieldProperties(), -1403186291, -94117148);
            
			
			
			return fieldProperties;
        }

		
    }
}