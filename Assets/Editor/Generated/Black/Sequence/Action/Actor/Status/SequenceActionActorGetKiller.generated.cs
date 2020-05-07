using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Status
{
    public partial class SequenceActionActorGetKiller : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outKill_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outNoct_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outGladio_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPrompto_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outIgnis_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetKiller();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Status.SequenceActionActorGetKiller", 0, Black.Sequence.Action.Actor.Status.SequenceActionActorGetKiller.ObjectType, null, properties, 0, 960);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Status.SequenceActionActorGetKiller", base.GetFieldProperties(), -582613007, 293840995);
            
			
			
			return fieldProperties;
        }

		
    }
}