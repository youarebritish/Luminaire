using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineCameraTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackInterpMovementBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool pogFlag_;
		public bool povFlag_;
		public bool rollFlag_;
		public Black.Camera.Struct.CameraControlTurn controlTurn_;
		public int useTypePogX_;
		public int useTypePogY_;
		public int useTypePogZ_;
		public int useTypePovX_;
		public int useTypePovY_;
		public int useTypePovZ_;
		public SQEX.Ebony.Framework.TimeControl.TimeLine.CameraTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack", base.GetFieldProperties(), -1128376734, 1007610312);
            
			fieldProperties.AddProperty(new Property("pogFlag_", 2150968024, "bool", 416, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("povFlag_", 3063830905, "bool", 417, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rollFlag_", 3475138109, "bool", 418, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("controlTurn_", 764311870, "Black.Camera.Struct.CameraControlTurn", 424, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypePogX_", 2727825411, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack.UseType", 484, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypePogY_", 3801740122, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack.UseType", 488, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypePogZ_", 3801195669, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack.UseType", 492, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypePovX_", 2165447464, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack.UseType", 496, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypePovY_", 1091532753, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack.UseType", 500, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypePovZ_", 1092077206, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack.UseType", 504, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterTrackItem_", 1305972098, "SQEX.Ebony.Framework.TimeControl.TimeLine.CameraTrackItem", 512, 224, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}