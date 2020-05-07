using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorGetNearTheActorOfPlayer : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin playerActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin nearActorPin_;
		public int characterTypeId_;
		public uint characterRaceId_;
		public float checkRadius_;
		public float checkHeight_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetNearTheActorOfPlayer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorGetNearTheActorOfPlayer", 0, Black.Sequence.Actor.SequenceActionActorGetNearTheActorOfPlayer.ObjectType, null, properties, 0, 776);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorGetNearTheActorOfPlayer", base.GetFieldProperties(), -788679776, -804763149);
            return fieldProperties;
        }

		
    }
}