using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Colosseum
{
    public partial class SequenceActionColosseumSetting : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin payBackLookAtPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin payBackEyePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupFocusLookAtD_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupFocusLookAtC_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupFocusLookAtB_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupFocusLookAtA_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupFocusEyePosD_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupFocusEyePosC_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupFocusEyePosB_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupFocusEyePosA_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin InformationTriggerPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin colosseumIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin daysNumberPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin seriesNameIdPin_;
		public uint colosseumId_;
		public int medalExchangeGilRate_;
		public float buffDurationMaximum_;
		public float tacticalPointUpRate_;
		public bool enableCamera_;
		public bool isGetSerieseName_;
		public float beforeBattleCameraHeight_;
		public float beforeBattleCameraMoveRate_;
		public float beforeBattleCameraRadius_;
		public float frameCountBetGilFromMenu_;
		public UnityEngine.Vector4 betGilEyePosition_;
		public UnityEngine.Vector4 betGilLookAtPosition_;
		public UnityEngine.Vector4 battleCameraBase_;
		public float battleCameraEyeHeight_;
		public float battleCameraRadius_;
		public float battleCameraVelocity_;
		public float battleCameraMaxRate_;
		public float battleCameraMinRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionColosseumSetting();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumSetting", 0, Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumSetting.ObjectType, null, properties, 0, 1728);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumSetting", base.GetFieldProperties(), 492070213, -1972100393);
            return fieldProperties;
        }

		
    }
}