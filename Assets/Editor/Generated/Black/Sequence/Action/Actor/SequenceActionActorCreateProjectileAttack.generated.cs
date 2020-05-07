using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorCreateProjectileAttack : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ownerActorIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin launchActorIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetActorIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spawnPointIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin createAttackActorOPin_;
		public uint attackParamId_;
		public int spawnPointType_;
		public float spawnRadius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorCreateProjectileAttack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorCreateProjectileAttack", 0, Black.Sequence.Action.Actor.SequenceActionActorCreateProjectileAttack.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorCreateProjectileAttack", base.GetFieldProperties(), 1784284252, -1935292064);
            
			
			
			return fieldProperties;
        }

		
    }
}