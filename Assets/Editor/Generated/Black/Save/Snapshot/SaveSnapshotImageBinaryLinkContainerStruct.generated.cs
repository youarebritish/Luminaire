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
            
			
			
			fieldProperties.AddProperty(new Property("links_", 3136390307, "Luminous.Std.DynamicArray< Black.Save.Snapshot.SaveSnapshotImageBinaryLinkStruct >", 0, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("shotCount_", 667128289, "uint32_t", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("folderId_", 224759861, "uint64_t", 24, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}