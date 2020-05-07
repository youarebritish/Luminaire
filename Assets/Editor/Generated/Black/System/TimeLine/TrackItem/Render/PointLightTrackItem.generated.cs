using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Render
{
    public partial class PointLightTrackItem : Black.System.TimeLine.TrackItem.Render.LightTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PointLightTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Render.PointLightTrackItem", 0, Black.System.TimeLine.TrackItem.Render.PointLightTrackItem.ObjectType, null, properties, 0, 256);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Render.PointLightTrackItem", base.GetFieldProperties(), -786838244, 1380068004);
            return fieldProperties;
        }

		
    }
}