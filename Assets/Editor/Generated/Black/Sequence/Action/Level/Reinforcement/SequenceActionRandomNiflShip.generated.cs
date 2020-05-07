using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Reinforcement
{
    public partial class SequenceActionRandomNiflShip : Black.Sequence.Action.Level.Reinforcement.SequenceActionPopNiflShip
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin memory_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shouldResetTeam_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin forceStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin forceTeamArrangement_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin forceTeamIdx_;
		public int farWaitTime_;
		public int nearWaitTime_;
		public float farDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionRandomNiflShip();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Reinforcement.SequenceActionRandomNiflShip", 0, Black.Sequence.Action.Level.Reinforcement.SequenceActionRandomNiflShip.ObjectType, null, properties, 0, 3456);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Reinforcement.SequenceActionRandomNiflShip", base.GetFieldProperties(), -1952085699, 1117718072);
            
			
			
			return fieldProperties;
        }

		
    }
}