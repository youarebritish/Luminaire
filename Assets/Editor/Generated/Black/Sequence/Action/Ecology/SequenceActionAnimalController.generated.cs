using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Ecology
{
    public partial class SequenceActionAnimalController : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int characterType_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin idel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin walk_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin jump_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin water_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin die_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fly_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin inDistance_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outDistance_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdIdel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdWalk_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdJump_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdWater_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdDie_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdFly_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdInDistance_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdOutDistance_;
		public float upperLength_;
		public float downLength_;
		public float deepWater_;
		public int target_;
		public float distance_;
		public int dieTime_;
		public string idel_aniPath_;
		public string idel_aniPath01_;
		public float idel_rate_;
		public float idel_completionTimer_;
		public string walk_aniPath_;
		public float walk_rate_;
		public string jump_aniPath_;
		public float jump_rate_;
		public string water_aniPath_;
		public string water_aniPath01_;
		public float water_rate_;
		public string die_aniPath_;
		public float die_rate_;
		public string fly_aniPath_;
		public string fly_st_aniPath_;
		public string fly_ed_aniPath_;
		public float fly_rate_;
		public uint motionId00_;
		public uint motionId01_;
		public int initState_;
		public bool isUseInteraction_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAnimalController();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Ecology.SequenceActionAnimalController", 0, Black.Sequence.Action.Ecology.SequenceActionAnimalController.ObjectType, null, properties, 0, 5632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Ecology.SequenceActionAnimalController", base.GetFieldProperties(), -1613542778, 558385276);
            return fieldProperties;
        }

		
    }
}