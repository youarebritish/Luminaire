using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraCCFTrack : Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraCCFTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isSeamless_;
		public bool isOverrideEnvironment4Event_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraCCFTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraCCFTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraCCFTrack.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraCCFTrack", base.GetFieldProperties(), 504860602, -1580395156);
            return fieldProperties;
        }

		
    }
}