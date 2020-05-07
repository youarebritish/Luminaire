using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class ActorMovementNewTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 rotation_;
		public UnityEngine.Vector4 scaling_;
		public bool isUseCurrentActorPosition_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorMovementNewTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.ActorMovementNewTrackItem", 0, Black.System.TimeLine.TrackItem.ActorMovementNewTrackItem.ObjectType, null, properties, 0, 160);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.ActorMovementNewTrackItem", base.GetFieldProperties(), 648796226, -13755118);
            return fieldProperties;
        }

		
    }
}