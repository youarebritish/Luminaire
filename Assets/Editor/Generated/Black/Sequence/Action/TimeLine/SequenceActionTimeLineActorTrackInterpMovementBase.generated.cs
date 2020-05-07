using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineActorTrackInterpMovementBase : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackInterpBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int moveFrameType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorTrackInterpMovementBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackInterpMovementBase", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackInterpMovementBase.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackInterpMovementBase", base.GetFieldProperties(), 170353897, -1788086799);
            
			fieldProperties.AddProperty(new Property("moveFrameType", 1889103065, "Black.System.TimeLine.TimeLineManager.MoveFrameType", 352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}