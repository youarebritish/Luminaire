using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Sound
{
    public partial class VoiceTrackItem : Black.System.TimeLine.TrackItem.SoundTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public uint voiceLabel_;
		public bool messageFlag_;
		public int voiceLevel_;
		public bool lipSyncEnabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VoiceTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Sound.VoiceTrackItem", 0, Black.System.TimeLine.TrackItem.Sound.VoiceTrackItem.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Sound.VoiceTrackItem", base.GetFieldProperties(), -1708141408, 943829535);
            
			
			
			return fieldProperties;
        }

		
    }
}