using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence
{
    public partial class SequenceActionPlayCinepressoCamera : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin seamlessPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin yawAnglePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pitchAnglePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fovLevelPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shotSizePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin subjectSubPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin subjectMainPin_;
		public int shotType_;
		public int shotSize_;
		public int fovLevel_;
		public int pitchAngle_;
		public int yawAngle_;
		public int offsetPan_;
		public int offsetTilt_;
		public int offsetRoll_;
		public int subjectSide_;
		public bool seamless_;
		public bool enableFollowPan_;
		public bool enableFollowTrack_;
		public bool enableAnimation_;
		public int animPan_;
		public int animTilt_;
		public int animAroundH_;
		public int animAroundV_;
		public int animTrack_;
		public int animBoom_;
		public int animDolly_;
		public int animZoom_;
		public float animationLength_;
		public int easeStart_;
		public int easeEnd_;
		public Black.Camera.Struct.CameraControlTurn controlTurn_;
		public bool isCheckCollision_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayCinepressoCamera();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.SequenceActionPlayCinepressoCamera", 0, Black.Sequence.SequenceActionPlayCinepressoCamera.ObjectType, null, properties, 0, 1440);
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

            fieldProperties = new PropertyContainer("Black.Sequence.SequenceActionPlayCinepressoCamera", base.GetFieldProperties(), 1872084990, -1145470894);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopPin_", 2226130577, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("started_", 3450564819, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finished_", 3052293812, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessPin_", 662957750, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("yawAnglePin_", 697321383, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pitchAnglePin_", 418432812, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovLevelPin_", 1661087026, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shotSizePin_", 2733053660, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("subjectSubPin_", 3940685423, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("subjectMainPin_", 1919874750, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shotType_", 1405366790, "Black.Sequence.SequenceActionPlayCinepressoCamera.ShotType", 1272, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("shotSize_", 418186825, "int", 1276, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovLevel_", 4049465927, "int", 1280, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("pitchAngle_", 794634457, "int", 1284, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("yawAngle_", 669496412, "int", 1288, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetPan_", 102367970, "int", 1292, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetTilt_", 2198189546, "int", 1296, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetRoll_", 746120302, "int", 1300, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("subjectSide_", 3682445297, "Black.Sequence.SequenceActionPlayCinepressoCamera.SubjectSide", 1304, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamless_", 4115715931, "bool", 1308, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableFollowPan_", 1065834207, "bool", 1309, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableFollowTrack_", 1257731423, "bool", 1310, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableAnimation_", 1952700089, "bool", 1311, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("animPan_", 229453736, "int", 1312, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("animTilt_", 3470739368, "int", 1316, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("animAroundH_", 667272164, "int", 1320, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("animAroundV_", 672200854, "int", 1324, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("animTrack_", 513468280, "int", 1328, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("animBoom_", 4126486228, "int", 1332, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("animDolly_", 934471901, "int", 1336, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("animZoom_", 3252955516, "int", 1340, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("animationLength_", 1623701030, "float", 1344, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("easeStart_", 2181488286, "int", 1348, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("easeEnd_", 3528480265, "int", 1352, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("controlTurn_", 764311870, "Black.Camera.Struct.CameraControlTurn", 1360, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCheckCollision_", 1357258370, "bool", 1416, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}