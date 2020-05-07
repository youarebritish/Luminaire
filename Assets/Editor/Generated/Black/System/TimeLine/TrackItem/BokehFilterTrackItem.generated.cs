using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class BokehFilterTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float foculLength_;
		public float fNumber_;
		public float focalPlane_;
		public float focalPlaneRadius_;
		public float maxCoCSizeNear_;
		public float maxCoCSizeFar_;
		public float initialEnergyScale_;
		public UnityEngine.Vector4 switchOver_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BokehFilterTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.BokehFilterTrackItem", 0, Black.System.TimeLine.TrackItem.BokehFilterTrackItem.ObjectType, null, properties, 0, 144);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.BokehFilterTrackItem", base.GetFieldProperties(), 1069025879, -616207110);
            
			
			
			return fieldProperties;
        }

		
    }
}