using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class CharaEntryIDResource2 : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string id_;
		public string searchParamTable_;
		public string ebexPathKey_;
		public string idKey_;
		public string searchParamTable2_;
		public string ebexPathKey2_;
		public string idKey2_;
		public bool isAutoLoad_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharaEntryIDResource2();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharaEntryIDResource2", 0, Black.Entity.Data.CharaEntryIDResource2.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharaEntryIDResource2", base.GetFieldProperties(), -824945525, -1160790945);
            
			
			
			return fieldProperties;
        }

		
    }
}