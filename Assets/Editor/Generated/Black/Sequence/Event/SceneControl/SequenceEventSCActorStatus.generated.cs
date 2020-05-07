using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.SceneControl
{
    public partial class SequenceEventSCActorStatus : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin allEnemyDied_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin gameStarted_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin teamNameDestroyed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin teamTypeDestroyed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin sceneNoDestroyed_;
		public int specificSceneNo_;
		public string specificTeamName_;
		public string specificTeamType_;
		public uint specificTeamNameId_;
		public uint specificTeamTypeId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventSCActorStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SceneControl.SequenceEventSCActorStatus", 0, Black.Sequence.Event.SceneControl.SequenceEventSCActorStatus.ObjectType, null, properties, 0, 704);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SceneControl.SequenceEventSCActorStatus", base.GetFieldProperties(), 329517466, -1624087371);
            return fieldProperties;
        }

		
    }
}