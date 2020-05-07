using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class LmVFXEventTrackItem : Black.System.TimeLine.TrackItem.ResourceTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint vlinkId_;
		public int actionType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmVFXEventTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.LmVFXEventTrackItem", 0, Black.System.TimeLine.TrackItem.LmVFXEventTrackItem.ObjectType, null, properties, 0, 144);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.LmVFXEventTrackItem", base.GetFieldProperties(), -1779384391, -1243088799);
            return fieldProperties;
        }

		
    }
}