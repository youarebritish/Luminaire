using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraCharRelativeTrack : Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraCCFTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin relativeActorPin_;
		public int relativeActorScene_;
		public bool isOverrideEnvironment4Event_;
		public int charaRelativeIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraCharRelativeTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraCharRelativeTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraCharRelativeTrack.ObjectType, null, properties, 0, 864);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraCharRelativeTrack", base.GetFieldProperties(), 1364111205, 36928509);
            
			
			
			return fieldProperties;
        }

		
    }
}