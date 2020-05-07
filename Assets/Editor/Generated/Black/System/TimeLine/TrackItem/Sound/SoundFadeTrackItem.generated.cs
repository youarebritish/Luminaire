using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Sound
{
    public partial class SoundFadeTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float volume_;
		public SQEX.Ebony.Framework.TimeControl.CurveList curveList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SoundFadeTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Sound.SoundFadeTrackItem", 0, Black.System.TimeLine.TrackItem.Sound.SoundFadeTrackItem.ObjectType, null, properties, 0, 120);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Sound.SoundFadeTrackItem", base.GetFieldProperties(), 697063061, -961462805);
            return fieldProperties;
        }

		
    }
}