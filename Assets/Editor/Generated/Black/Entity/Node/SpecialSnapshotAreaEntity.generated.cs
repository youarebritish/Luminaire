using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class SpecialSnapshotAreaEntity : Black.Entity.Node.TriggerEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int targetBuddy_;
		public uint saveLabel_;
		public int colorType_;
		public uint colorCorrectionID_;
		public uint questPhotoID_;
		public bool isMarked_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SpecialSnapshotAreaEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.SpecialSnapshotAreaEntity", 0, Black.Entity.Node.SpecialSnapshotAreaEntity.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.SpecialSnapshotAreaEntity", base.GetFieldProperties(), -509382138, -964367156);
            
			
			
			return fieldProperties;
        }

		
    }
}