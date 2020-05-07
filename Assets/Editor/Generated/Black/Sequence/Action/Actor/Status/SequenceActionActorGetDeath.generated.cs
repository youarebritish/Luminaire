using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Status
{
    public partial class SequenceActionActorGetDeath : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin death_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin allDeath_;
		public bool usePlayerSaveBankNumber_;
		public int playerSaveBankNumber_;
		public float deathCheckTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetDeath();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Status.SequenceActionActorGetDeath", 0, Black.Sequence.Action.Actor.Status.SequenceActionActorGetDeath.ObjectType, null, properties, 0, 800);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Status.SequenceActionActorGetDeath", base.GetFieldProperties(), -1225962162, -1128391154);
            return fieldProperties;
        }

		
    }
}