using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl.TimeLine
{
    public partial class CameraTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.CurveTrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 pog_;
		public UnityEngine.Vector4 pov_;
		public float roll_;
		public int rollDirection_;
		public int interpMode_;
		public bool isUseCurrentCameraPosition_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.TimeLine.CameraTrackItem", 0, SQEX.Ebony.Framework.TimeControl.TimeLine.CameraTrackItem.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.TimeLine.CameraTrackItem", base.GetFieldProperties(), -1547832897, 1130687551);
            return fieldProperties;
        }

		
    }
}