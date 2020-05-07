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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("payBackLookAtPin_", 3567321872, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("payBackEyePin_", 401726251, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupFocusLookAtD_Pin_", 3436604683, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupFocusLookAtC_Pin_", 4233106204, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 632, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupFocusLookAtB_Pin_", 57463169, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 720, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupFocusLookAtA_Pin_", 1150411258, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 808, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupFocusEyePosD_Pin_", 2159335780, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupFocusEyePosC_Pin_", 1607715475, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupFocusEyePosB_Pin_", 355085262, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1072, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupFocusEyePosA_Pin_", 2825219605, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1160, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("InformationTriggerPin_", 567597919, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1248, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("colosseumIdPin_", 3827619556, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1336, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("daysNumberPin_", 1330072051, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1424, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("seriesNameIdPin_", 1762366878, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1512, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("colosseumId_", 3035363617, "SQEX.Ebony.Std.Fixid", 1600, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("medalExchangeGilRate_", 3785000414, "int32_t", 1604, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("buffDurationMaximum_", 2901202639, "float", 1608, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tacticalPointUpRate_", 4294483126, "float", 1612, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableCamera_", 1274111398, "bool", 1616, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isGetSerieseName_", 361600383, "bool", 1617, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("beforeBattleCameraHeight_", 470646041, "float", 1620, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("beforeBattleCameraMoveRate_", 1462185173, "float", 1624, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("beforeBattleCameraRadius_", 1830703546, "float", 1628, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frameCountBetGilFromMenu_", 682985660, "float", 1632, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("betGilEyePosition_", 3816328579, "Luminous.Math.VectorA", 1648, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("betGilLookAtPosition_", 3770218854, "Luminous.Math.VectorA", 1664, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleCameraBase_", 915332902, "Luminous.Math.VectorA", 1680, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleCameraEyeHeight_", 1433260959, "float", 1696, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleCameraRadius_", 2297246211, "float", 1700, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleCameraVelocity_", 4112420252, "float", 1704, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleCameraMaxRate_", 2655723953, "float", 1708, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleCameraMinRate_", 1684040987, "float", 1712, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}