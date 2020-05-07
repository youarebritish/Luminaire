using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor
{
    public partial class SequenceActionTimeLineMotionTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool stopMorpheme_;
		public bool isRestartMorphemeWhenFinished_;
		public bool isResetTransOrigin_;
		public bool isUseCutSceneMotion_;
		public bool isWarpZeroFrame_;
		public bool isIgnoreBaseScale_;
		public bool isResetPhysics_;
		public string idleMotionSourcePath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineMotionTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineMotionTrack", 0, Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineMotionTrack.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineMotionTrack", base.GetFieldProperties(), -1910248416, 1201788451);
            
			fieldProperties.AddProperty(new Property("stopMorpheme_", 2642509163, "bool", 400, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRestartMorphemeWhenFinished_", 2075719798, "bool", 401, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetTransOrigin_", 13159593, "bool", 402, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseCutSceneMotion_", 3163354819, "bool", 403, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isWarpZeroFrame_", 2865453559, "bool", 404, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isIgnoreBaseScale_", 173090201, "bool", 405, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetPhysics_", 1526292362, "bool", 406, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("idleMotionSourcePath_", 464281836, "Ebony.Base.String", 408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}