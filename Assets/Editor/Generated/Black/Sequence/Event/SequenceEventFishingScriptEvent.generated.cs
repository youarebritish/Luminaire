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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("first_fishing_", 2708624825, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cast_started_", 511102069, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cast_prepare_finished_", 1189869950, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cast_failed_", 2887210835, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cast_evening_", 2740113778, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cast_few_line_hp_", 693956068, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 760, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lure_splash_down_", 274553281, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 856, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("line_break_", 3220532008, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 952, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("jump_qte_failure_and_keep_lure_", 274904831, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1048, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bite_qte_decided_", 1881165800, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1144, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bite_qte_success_", 3898862357, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1240, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bite_qte_big_fish_success_", 2828085513, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1336, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bite_qte_failure_", 3051582626, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1432, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("jump_qte_success_", 3986399087, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1528, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("jump_qte_big_fish_success_", 1687505719, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1624, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("battle_started_", 4212456286, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1720, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("battle_few_line_hp_", 2225543375, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1816, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_small_fish_", 2698873583, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1912, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_normal_fish_", 980766115, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2008, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_big_fish_", 538149378, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2104, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_very_big_fish_", 705273229, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2200, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_small_fish_ui_", 3845033646, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2296, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_normal_fish_ui_", 3124128906, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2392, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_big_fish_ui_", 328992433, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2488, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_very_big_fish_ui_", 4111911204, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2584, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("onLineTensionUp_", 1756078582, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2680, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("onTackleMenuOpened_", 1624803013, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2776, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}