using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class LmVFXTrackItemActor : Black.System.TimeLine.TrackItem.LmVFXTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint vlinkId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmVFXTrackItemActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.LmVFXTrackItemActor", 0, Black.System.TimeLine.TrackItem.LmVFXTrackItemActor.ObjectType, null, properties, 0, 152);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.LmVFXTrackItemActor", base.GetFieldProperties(), 1744334617, -1504432410);
            
			
			
			return fieldProperties;
        }

		
    }
}