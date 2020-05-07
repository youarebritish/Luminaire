using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class SoundTrackItemGeneral : Black.System.TimeLine.TrackItem.SoundTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public int soundID_;
		public uint soundFixID_;
		public int soundType_;
		public string filePath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SoundTrackItemGeneral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.SoundTrackItemGeneral", 0, Black.System.TimeLine.TrackItem.SoundTrackItemGeneral.ObjectType, null, properties, 0, 256);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.SoundTrackItemGeneral", base.GetFieldProperties(), 1260290109, -1927864554);
            return fieldProperties;
        }

		
    }
}