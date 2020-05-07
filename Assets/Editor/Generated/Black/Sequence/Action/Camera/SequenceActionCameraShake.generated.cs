using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionCameraShake : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sourceActorPin_;
		public bool enableRandomShakeOffset_;
		public int shakeRandomFactorRangeMode_;
		public bool enableRandomRollZ_;
		public int rollZRandomFactorRangeMode_;
		public bool enableRandomUndampedDistance_;
		public int undampedDistanceRandomFactorRangeMode_;
		public bool enableRandomEndAttenuationDistance_;
		public int endAttenuationDistanceRandomFactorRangeMode_;
		public float activeTime_;
		public bool enableRandomShakeTimeWidth_;
		public Black.System.TimeLine.TrackItem.Camera.CameraShakeNodeTrackItem shakeParameter_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraShake();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionCameraShake", 0, Black.Sequence.Action.Camera.SequenceActionCameraShake.ObjectType, null, properties, 0, 1120);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionCameraShake", base.GetFieldProperties(), 217117542, -3787018);
            
			fieldProperties.AddProperty(new Property("enable_", 3925052483, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable_", 1760805492, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finished_", 3052293812, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraActorPin_", 1707765395, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 752, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceActorPin_", 3706314901, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 840, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomShakeOffset_", 2141515243, "bool", 928, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shakeRandomFactorRangeMode_", 3554902946, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 932, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomRollZ_", 3790358621, "bool", 936, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rollZRandomFactorRangeMode_", 2285221795, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 940, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomUndampedDistance_", 1957369555, "bool", 944, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("undampedDistanceRandomFactorRangeMode_", 3310127673, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 948, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomEndAttenuationDistance_", 3566532670, "bool", 952, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("endAttenuationDistanceRandomFactorRangeMode_", 109627262, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 956, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("activeTime_", 3298494899, "float", 960, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomShakeTimeWidth_", 3135282409, "bool", 964, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shakeParameter_", 1134684621, "Black.System.TimeLine.TrackItem.Camera.CameraShakeNodeTrackItem", 976, 144, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}