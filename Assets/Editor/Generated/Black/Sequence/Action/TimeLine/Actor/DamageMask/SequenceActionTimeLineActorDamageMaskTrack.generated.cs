using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.DamageMask
{
    public partial class SequenceActionTimeLineActorDamageMaskTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int type_;
		public float contiuousTime_;
		public float fadeoutTime_;
		public float radius_;
		public float power_;
		public float concentration_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin damageSpherePosPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorDamageMaskTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.DamageMask.SequenceActionTimeLineActorDamageMaskTrack", 0, Black.Sequence.Action.TimeLine.Actor.DamageMask.SequenceActionTimeLineActorDamageMaskTrack.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.DamageMask.SequenceActionTimeLineActorDamageMaskTrack", base.GetFieldProperties(), -1246048972, -136049654);
            
			
			
			return fieldProperties;
        }

		
    }
}