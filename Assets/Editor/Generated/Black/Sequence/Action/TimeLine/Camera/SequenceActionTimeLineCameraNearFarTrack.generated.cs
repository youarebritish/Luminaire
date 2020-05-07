using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraNearFarTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float nearValue_;
		public float farValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraNearFarTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraNearFarTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraNearFarTrack.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraNearFarTrack", base.GetFieldProperties(), 152329263, 1473779521);
            return fieldProperties;
        }

		
    }
}