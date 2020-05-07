using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Menu
{
    public partial class SwfPlayerTextFieldConfigArrayItem : Black.Entity.Data.Menu.SwfArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint TextField;
		public int FontType;
		public int VerticalAlignType;
		public uint MovieClip;
		public bool IsEnableSoftWrap;
		public bool IsEnableTruncate;
		public uint MessageFixId_;
		public bool IsSetString_;
		public string MessageString_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SwfPlayerTextFieldConfigArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Menu.SwfPlayerTextFieldConfigArrayItem", 0, Black.Entity.Data.Menu.SwfPlayerTextFieldConfigArrayItem.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Menu.SwfPlayerTextFieldConfigArrayItem", base.GetFieldProperties(), -588298855, -2120345529);
            return fieldProperties;
        }

		
    }
}