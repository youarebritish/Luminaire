using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class CharaEntryIDResourceFileList : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string id_;
		public string searchParamTable_;
		public string ebexPathKey_;
		public string idKey_;
		public bool isAutoLoad_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharaEntryIDResourceFileList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharaEntryIDResourceFileList", 0, Black.Entity.Data.CharaEntryIDResourceFileList.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharaEntryIDResourceFileList", base.GetFieldProperties(), 1191484260, -1315451441);
            return fieldProperties;
        }

		
    }
}