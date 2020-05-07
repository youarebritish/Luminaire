using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorAttackParameterDamage : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ownerPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin attackParamIdPin_;
		public uint attackParamFixId_;
		public bool useSummonAttack_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAttackParameterDamage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorAttackParameterDamage", 0, Black.Sequence.Action.Actor.SequenceActionActorAttackParameterDamage.ObjectType, null, properties, 0, 640);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorAttackParameterDamage", base.GetFieldProperties(), -1050028802, -1570367193);
            return fieldProperties;
        }

		
    }
}