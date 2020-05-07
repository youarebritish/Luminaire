using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Snapshot
{
    public partial class SaveSnapshotImageInfoStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int id_;
		public IList<uint> attributes_;
		public long time_;
		public uint photoLayerId_;
		public double[] worldPosition_;
		public sbyte importantType_;
		public sbyte phaseType_;
		public bool isMarked_;
		public uint photoJenre_;
		public uint targetIds_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveSnapshotImageInfoStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Snapshot.SaveSnapshotImageInfoStruct", 0, Black.Save.Snapshot.SaveSnapshotImageInfoStruct.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Save.Snapshot.SaveSnapshotImageInfoStruct", null, -299908639, -1229791341);
            return fieldProperties;
        }

		
    }
}