using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventFishingScriptEvent : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin first_fishing_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_prepare_finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_failed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_evening_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_few_line_hp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lure_splash_down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin line_break_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin jump_qte_failure_and_keep_lure_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin bite_qte_decided_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin bite_qte_success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin bite_qte_big_fish_success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin bite_qte_failure_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin jump_qte_success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin jump_qte_big_fish_success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin battle_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin battle_few_line_hp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_small_fish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_normal_fish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_big_fish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_very_big_fish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_small_fish_ui_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_normal_fish_ui_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_big_fish_ui_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_very_big_fish_ui_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin onLineTensionUp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin onTackleMenuOpened_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventFishingScriptEvent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventFishingScriptEvent", 0, Black.Sequence.Event.SequenceEventFishingScriptEvent.ObjectType, null, properties, 0, 2872);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventFishingScriptEvent", base.GetFieldProperties(), 1639559776, 1492443489);
            
			
			
			return fieldProperties;
        }

		
    }
}