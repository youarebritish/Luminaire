using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionBattleEventActorPause : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int actorListMode_;
		public bool isControlPCActorSlow_;
		public bool isAlsoFade_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin on_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reserve_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin off_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enableBattleEventPauseOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin anyBattleEventPausingOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin excludeActors_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionBattleEventActorPause();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionBattleEventActorPause", 0, Black.Sequence.Action.Actor.SequenceActionBattleEventActorPause.ObjectType, null, properties, 0, 840);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionBattleEventActorPause", base.GetFieldProperties(), -1348531756, 1068896548);
            
			
			
			return fieldProperties;
        }

		
    }
}