using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Utility
{
    public partial class SerializableStringArrayItem : SQEX.Ebony.Framework.Utility.ArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string Value= string.Empty;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SerializableStringArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Utility.SerializableStringArrayItem", 0, SQEX.Ebony.Framework.Utility.SerializableStringArrayItem.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Utility.SerializableStringArrayItem", base.GetFieldProperties(), 1375311518, 820944579);
            
			
			
			fieldProperties.AddProperty(new Property("Value", 3511155050, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SerializableStringArrayItem();
        }
		
    }
}