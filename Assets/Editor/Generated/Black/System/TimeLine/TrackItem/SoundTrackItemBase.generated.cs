using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class SoundTrackItemBase : Black.System.TimeLine.TrackItem.ResourceTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float blendRate_;
		public float startInterpTime_;
		public float endInterpTime_;
		public SQEX.Ebony.Framework.TimeControl.CurveList curveList_;
		public float totalBaseFrame_;
		public bool isLoop_;
		public float speed_;
		public float startFrame_;
		public float endFrame_;
		public int voiceLevel_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SoundTrackItemBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.SoundTrackItemBase", 0, Black.System.TimeLine.TrackItem.SoundTrackItemBase.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.SoundTrackItemBase", base.GetFieldProperties(), -1339351542, 1107670020);
            
			
			
			return fieldProperties;
        }

		
    }
}