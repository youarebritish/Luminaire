using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Snapshot
{
    public partial class SaveSnapshotImageBinaryStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public object binary_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveSnapshotImageBinaryStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Snapshot.SaveSnapshotImageBinaryStruct", 0, Black.Save.Snapshot.SaveSnapshotImageBinaryStruct.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Save.Snapshot.SaveSnapshotImageBinaryStruct", null, -1374712103, -1529955191);
            
			
			
			return fieldProperties;
        }

		
    }
}