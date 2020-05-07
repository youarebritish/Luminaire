using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class VFXTrackItemActor : Black.System.TimeLine.TrackItem.VFXTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint joint_;
		public UnityEngine.Vector4 offset_;
		public UnityEngine.Vector4 rotation_;
		public bool localRotationFlag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VFXTrackItemActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.VFXTrackItemActor", 0, Black.System.TimeLine.TrackItem.VFXTrackItemActor.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.VFXTrackItemActor", base.GetFieldProperties(), 1895306180, 1687832900);
            
			
			
			return fieldProperties;
        }

		
    }
}