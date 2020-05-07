using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Ecology
{
    public partial class SequenceActionEcologyGetActorInfo : Black.Sequence.Action.Ecology.SequenceActionEcologyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin createdList_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin firstTeamAllCreated_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueEnableCreateActorsNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueAliveActorsNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueExistActorsNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin firstStaticActorsNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueActorList_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueTeam_;
		public bool isFinished_;
		public bool isNotCreateActorList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEcologyGetActorInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Ecology.SequenceActionEcologyGetActorInfo", 0, Black.Sequence.Action.Ecology.SequenceActionEcologyGetActorInfo.ObjectType, null, properties, 0, 1640);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Ecology.SequenceActionEcologyGetActorInfo", base.GetFieldProperties(), -23242846, -474285916);
            return fieldProperties;
        }

		
    }
}