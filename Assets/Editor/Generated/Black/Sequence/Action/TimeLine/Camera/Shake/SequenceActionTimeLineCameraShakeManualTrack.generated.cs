using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera.Shake
{
    public partial class SequenceActionTimeLineCameraShakeManualTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sourceActorPin_;
		public bool isUsePogShakeOffset_;
		public UnityEngine.Vector4 shakeOffset_;
		public UnityEngine.Vector4 pogShakeOffset_;
		public float rollZ_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraShakeManualTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.Shake.SequenceActionTimeLineCameraShakeManualTrack", 0, Black.Sequence.Action.TimeLine.Camera.Shake.SequenceActionTimeLineCameraShakeManualTrack.ObjectType, null, properties, 0, 592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.Shake.SequenceActionTimeLineCameraShakeManualTrack", base.GetFieldProperties(), 476216824, 1066869126);
            return fieldProperties;
        }

		
    }
}