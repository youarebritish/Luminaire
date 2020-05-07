using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraShakeTrackNormalCurve : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enableRandomShakeOffset_;
		public int shakeRandomFactorRangeMode_;
		public bool enableRandomRollZ_;
		public int rollZRandomFactorRangeMode_;
		public bool enableRandomUndampedDistance_;
		public int undampedDistanceRandomFactorRangeMode_;
		public bool enableRandomEndAttenuationDistance_;
		public int endAttenuationDistanceRandomFactorRangeMode_;
		public bool enableRandomShakeTimeWidth_;
		public bool enableRandomOffsetRollScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sourceActorPin_;
		public Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraShakeTrackNormalCurve();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraShakeTrackNormalCurve", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraShakeTrackNormalCurve.ObjectType, null, properties, 0, 736);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraShakeTrackNormalCurve", base.GetFieldProperties(), -371611817, -1786498253);
            
			fieldProperties.AddProperty(new Property("enableRandomShakeOffset_", 2141515243, "bool", 320, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shakeRandomFactorRangeMode_", 3554902946, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 324, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomRollZ_", 3790358621, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rollZRandomFactorRangeMode_", 2285221795, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 332, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomUndampedDistance_", 1957369555, "bool", 336, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("undampedDistanceRandomFactorRangeMode_", 3310127673, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 340, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomEndAttenuationDistance_", 3566532670, "bool", 344, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("endAttenuationDistanceRandomFactorRangeMode_", 109627262, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 348, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomShakeTimeWidth_", 3135282409, "bool", 352, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomOffsetRollScale_", 3407492966, "bool", 353, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraActorPin_", 1707765395, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceActorPin_", 3706314901, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterTrackItem_", 1305972098, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem", 544, 144, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}