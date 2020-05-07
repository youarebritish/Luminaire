using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Physics
{
    public partial class SequenceActionActorForceResetBodyDriver : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public bool isRecoverHP_;
		public int recoverHPRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorForceResetBodyDriver();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Physics.SequenceActionActorForceResetBodyDriver", 0, Black.Sequence.Action.Actor.Physics.SequenceActionActorForceResetBodyDriver.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Physics.SequenceActionActorForceResetBodyDriver", base.GetFieldProperties(), 387846521, -192638386);
            return fieldProperties;
        }

		
    }
}