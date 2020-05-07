using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Reinforcement
{
    public partial class SequenceActionRandomNiflTeam : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin generate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin end_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin memory_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aircraft_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin count_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin teamActors_;
		public float autoDeleteDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionRandomNiflTeam();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Reinforcement.SequenceActionRandomNiflTeam", 0, Black.Sequence.Action.Level.Reinforcement.SequenceActionRandomNiflTeam.ObjectType, null, properties, 0, 1368);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Reinforcement.SequenceActionRandomNiflTeam", base.GetFieldProperties(), 1545058674, -1205583391);
            
			
			
			return fieldProperties;
        }

		
    }
}