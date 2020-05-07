using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Snapshot
{
    public partial class SaveSnapshotImageBinaryLinkContainerStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Save.Snapshot.SaveSnapshotImageBinaryLinkStruct> links_;
		public int shotCount_;
		public long folderId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveSnapshotImageBinaryLinkContainerStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Snapshot.SaveSnapshotImageBinaryLinkContainerStruct", 0, Black.Save.Snapshot.SaveSnapshotImageBinaryLinkContainerStruct.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Save.Snapshot.SaveSnapshotImageBinaryLinkContainerStruct", null, -1450283648, -1718522279);
            
			
			
			return fieldProperties;
        }

		
    }
}