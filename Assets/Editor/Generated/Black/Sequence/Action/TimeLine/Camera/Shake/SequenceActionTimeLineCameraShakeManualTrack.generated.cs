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
            
			fieldProperties.AddProperty(new Property("cameraActorPin_", 1707765395, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 320, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceActorPin_", 3706314901, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 408, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUsePogShakeOffset_", 1937225824, "bool", 496, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shakeOffset_", 2638908511, "Luminous.Math.VectorA", 512, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddProperty(new Property("pogShakeOffset_", 371293983, "Luminous.Math.VectorA", 528, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddProperty(new Property("rollZ_", 3949656233, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}