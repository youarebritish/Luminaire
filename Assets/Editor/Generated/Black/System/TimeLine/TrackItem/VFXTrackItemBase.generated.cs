using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class VFXTrackItemBase : Black.System.TimeLine.TrackItem.ResourceTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public uint leafId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VFXTrackItemBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.VFXTrackItemBase", 0, Black.System.TimeLine.TrackItem.VFXTrackItemBase.ObjectType, null, properties, 0, 160);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.VFXTrackItemBase", base.GetFieldProperties(), 563820447, 1545010098);
            return fieldProperties;
        }

		
    }
}