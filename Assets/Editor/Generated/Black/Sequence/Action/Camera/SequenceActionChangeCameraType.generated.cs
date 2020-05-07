using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionChangeCameraType : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cameraOutPin_;
		public int cameraType_;
		public float blendTime_;
		public int blendCurveType_;
		public int vehicleType_;
		public int logicTypeOfVehicleTP_;
		public int cameraOffsetSide_;
		public bool isStopCurrentCameraViewBlend_;
		public bool isCallResetParameter_;
		public bool isNeedResetRotationYaw_;
		public bool isNeedResetRotationTilt_;
		public bool isReuseSameType_;
		public bool isDeleteWithoutOther_;
		public SQEX.Ebony.Framework.TimeControl.AnchorPointList anchorPointList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin9_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin8_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin1_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChangeCameraType();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionChangeCameraType", 0, Black.Sequence.Action.Camera.SequenceActionChangeCameraType.ObjectType, null, properties, 0, 1416);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionChangeCameraType", base.GetFieldProperties(), -309015044, 1048497286);
            
			
			
			return fieldProperties;
        }

		
    }
}