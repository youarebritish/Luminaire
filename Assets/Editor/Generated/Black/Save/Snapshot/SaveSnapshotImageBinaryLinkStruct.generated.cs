using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Snapshot
{
    public partial class SaveSnapshotImageBinaryLinkStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int id_;
		public IList<uint> referenceSources_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveSnapshotImageBinaryLinkStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Snapshot.SaveSnapshotImageBinaryLinkStruct", 0, Black.Save.Snapshot.SaveSnapshotImageBinaryLinkStruct.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Save.Snapshot.SaveSnapshotImageBinaryLinkStruct", null, 1492917409, 776405512);
            return fieldProperties;
        }

		
    }
}