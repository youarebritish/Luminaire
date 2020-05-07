using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class FadeTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int fadeType_;
		public UnityEngine.Color color_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FadeTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.FadeTrackItem", 0, Black.System.TimeLine.TrackItem.FadeTrackItem.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.FadeTrackItem", base.GetFieldProperties(), -1860969093, -5766227);
            
			fieldProperties.AddProperty(new Property("fadeType_", 3130622268, "Black.System.TimeLine.TrackItem.FadeTrackItem.FadeType", 88, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("color_", 3572781317, "Luminous.RenderInterface.Color", 96, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}