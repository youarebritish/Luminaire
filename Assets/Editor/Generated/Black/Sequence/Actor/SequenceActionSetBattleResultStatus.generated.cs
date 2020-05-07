using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionSetBattleResultStatus : Black.Sequence.Action.Level.SequenceActionSetBattleAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin bool_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool result_flag_;
		public bool message_flag_;
		public bool recover_flag_;
		public bool job_command_gauge_initialize_flag_;
		public bool encount_gauge_draw_flag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBattleResultStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionSetBattleResultStatus", 0, Black.Sequence.Actor.SequenceActionSetBattleResultStatus.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionSetBattleResultStatus", base.GetFieldProperties(), 1274819826, -445592371);
            
			
			
			return fieldProperties;
        }

		
    }
}