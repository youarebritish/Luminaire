using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Sound
{
    public partial class SoundOptionTrackItemGeneral : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.TimeControl.CurveList curveList_;
		public bool bValidCategoryCurve_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SoundOptionTrackItemGeneral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Sound.SoundOptionTrackItemGeneral", 0, Black.System.TimeLine.TrackItem.Sound.SoundOptionTrackItemGeneral.ObjectType, null, properties, 0, 120);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Sound.SoundOptionTrackItemGeneral", base.GetFieldProperties(), -538300647, -364823559);
            return fieldProperties;
        }

		
    }
}