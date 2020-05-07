using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetBattleAreaElementStatus : Black.Sequence.Action.Level.SequenceActionSetBattleAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin none_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin change_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fire_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fira_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin firaga_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzard_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzara_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzaga_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thunder_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thundara_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thundaga_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fireDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin firaDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin firagaDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzardDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzaraDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzagaDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thunderDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thundaraDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thundagaDown_;
		public bool updateStatusFlag_;
		public bool changeActivate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetBattleAreaElementStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetBattleAreaElementStatus", 0, Black.Sequence.Action.Level.SequenceActionGetBattleAreaElementStatus.ObjectType, null, properties, 0, 2536);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetBattleAreaElementStatus", base.GetFieldProperties(), 730524110, 1980199585);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stop_", 3454812878, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleAreaPin_", 1653102442, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 456, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("none_", 3807988940, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 552, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("change_", 1328150214, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 648, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fire_", 492074226, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 744, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fira_", 1566533390, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 840, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("firaga_", 486002990, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 936, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blizzard_", 2438350856, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1032, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blizzara_", 3511279829, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1128, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blizzaga_", 2792222386, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1224, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("thunder_", 1728365642, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1320, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("thundara_", 4291541561, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1416, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("thundaga_", 1357136462, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1512, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fireDown_", 549269250, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1608, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("firaDown_", 1419414718, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1704, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("firagaDown_", 2281457566, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1800, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blizzardDown_", 1669514052, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1896, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blizzaraDown_", 2838751889, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1992, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blizzagaDown_", 1272750018, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2088, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("thunderDown_", 2824828218, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("thundaraDown_", 3709217109, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("thundagaDown_", 3177156094, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("updateStatusFlag_", 3717561245, "bool", 2472, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("changeActivate_", 624234277, "bool", 2473, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}