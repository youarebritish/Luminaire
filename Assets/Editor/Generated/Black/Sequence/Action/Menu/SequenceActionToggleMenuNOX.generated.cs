using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionToggleMenuNOX : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinShow_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinHide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinPause_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinResume_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinConfig_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinAddTime_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinSetBonus_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin pinOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin pinOnClosed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelAddTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelPinCurrentTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelPinBonusTime_;
		public int menuType_;
		public int countdownTime_;
		public float stopTime_;
		public float currentTime_;
		public float addTime_;
		public float bonusTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionToggleMenuNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionToggleMenuNOX", 0, Black.Sequence.Action.Menu.SequenceActionToggleMenuNOX.ObjectType, null, properties, 0, 1392);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionToggleMenuNOX", base.GetFieldProperties(), -1626555324, 471423118);
            
			fieldProperties.AddProperty(new Property("pinShow_", 3937235990, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinHide_", 949596465, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinPause_", 1541889843, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinResume_", 3773294248, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinConfig_", 3452352023, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinAddTime_", 1028610515, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinSetBonus_", 3994408388, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinOut_", 3329024485, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinOnClosed_", 2637522406, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelAddTime_", 2535321766, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelPinCurrentTime_", 3938438173, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelPinBonusTime_", 2984958575, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("menuType_", 969717087, "Black.Sequence.Action.Menu.NoxMenuType", 1304, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("countdownTime_", 2125693714, "unsigned int", 1308, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopTime_", 621907553, "float", 1312, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("currentTime_", 3151480428, "float", 1316, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("addTime_", 436626334, "float", 1320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bonusTime_", 594230222, "float", 1324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}