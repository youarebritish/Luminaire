using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionGetAroundActor : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin findPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin foundEachPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin foundAllPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin positionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorListPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin lastActorPin_;
		public int targetType_;
		public float radius_;
		public bool isOnlyVisible_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetAroundActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionGetAroundActor", 0, Black.Sequence.Action.Actor.SequenceActionGetAroundActor.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionGetAroundActor", base.GetFieldProperties(), 575774117, 1996490933);
            
			
			
			return fieldProperties;
        }

		
    }
}