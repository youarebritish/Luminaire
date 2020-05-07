using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class BlendTrackItemBaseNoResource : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float blendRate_;
		public float startInterpTime_;
		public float endInterpTime_;
		public SQEX.Ebony.Framework.TimeControl.CurveList curveList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BlendTrackItemBaseNoResource();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.BlendTrackItemBaseNoResource", 0, Black.System.TimeLine.TrackItem.BlendTrackItemBaseNoResource.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.BlendTrackItemBaseNoResource", base.GetFieldProperties(), -2140247100, 428329883);
            return fieldProperties;
        }

		
    }
}