using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.System
{
    public partial class SequenceActionTimeLineActorSlowTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int taskTimeRateLevel_;
		public float timeRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorSlowTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.System.SequenceActionTimeLineActorSlowTrack", 0, Black.Sequence.Action.TimeLine.Actor.System.SequenceActionTimeLineActorSlowTrack.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.System.SequenceActionTimeLineActorSlowTrack", base.GetFieldProperties(), -250377019, -1154883901);
            
			fieldProperties.AddProperty(new Property("taskTimeRateLevel_", 3739561040, "Black.Actor.Component.ActorUpdateComponent.ActorUpdateTimeRateLevel", 336, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeRate_", 1909836107, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}