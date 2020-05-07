using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class LmVFXTrackItem : Black.System.TimeLine.TrackItem.LmVFXTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 rotation_;
		public UnityEngine.Vector4 scaling_;
		public string vlinkPath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmVFXTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.LmVFXTrackItem", 0, Black.System.TimeLine.TrackItem.LmVFXTrackItem.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.LmVFXTrackItem", base.GetFieldProperties(), 468898260, -992625350);
            return fieldProperties;
        }

		
    }
}