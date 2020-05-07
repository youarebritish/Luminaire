using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.Material
{
    public partial class SequenceActionTimeLineActorMaterialFloatTrack : Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialTrackCommon
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorMaterialFloatTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialFloatTrack", 0, Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialFloatTrack.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialFloatTrack", base.GetFieldProperties(), -244702696, 565251097);
            return fieldProperties;
        }

		
    }
}