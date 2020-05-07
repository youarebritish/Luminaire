using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Chocobo
{
    public partial class SaveChocoboStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public sbyte name_;
		public int flag_;
		public Black.Save.Multiplay.SaveChocoboDataStruct multiChocoboData_;
		public bool effectedEntitlement_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveChocoboStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Chocobo.SaveChocoboStruct", 0, Black.Save.Chocobo.SaveChocoboStruct.ObjectType, null, properties, 0, 1748);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.Chocobo.SaveChocoboStruct", null, 423255878, 1837290904);
            
			
			
			return fieldProperties;
        }

		
    }
}