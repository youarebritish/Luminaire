using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class ActorChangeSceneTrackItem : Black.System.TimeLine.TrackItem.ResourceTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int actorScene_;
		public int priority_;
		public bool changePositionAutomatically_;
		public float changeInterpolation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorChangeSceneTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.ActorChangeSceneTrackItem", 0, Black.System.TimeLine.TrackItem.ActorChangeSceneTrackItem.ObjectType, null, properties, 0, 152);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.ActorChangeSceneTrackItem", base.GetFieldProperties(), 2098773279, 1241393951);
            return fieldProperties;
        }

		
    }
}