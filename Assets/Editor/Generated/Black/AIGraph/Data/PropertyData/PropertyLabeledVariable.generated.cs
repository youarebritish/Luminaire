using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Data.PropertyData
{
    public partial class PropertyLabeledVariable : SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string label_;
		public uint labelId_;
		public int valueType_;
		public int scope_;
		public bool isCreateWhenNotFound_;
		public bool useTimer_;
		public Black.System.Labeled.LabeledVariableManager.TimerType timerType_;
		public float stopTimerValue_;
		public bool bBindAnimationBlackBoard_;
		public uint animationBlackBoardId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PropertyLabeledVariable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Data.PropertyData.PropertyLabeledVariable", 0, Black.AIGraph.Data.PropertyData.PropertyLabeledVariable.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Data.PropertyData.PropertyLabeledVariable", base.GetFieldProperties(), 1442468422, 1049825635);
            
			fieldProperties.AddIndirectlyProperty(new Property("propertyId_", 487541182, "int", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("indexOfLinkedProperty_", 4182715867, "int", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("label_", 3520738310, "Ebony.Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelId_", 3191214933, "SQEX.Ebony.Std.Fixid", 40, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueType_", 1693725455, "SQEX.Ebony.Framework.Sequence.SequenceValue.ValueType", 44, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("scope_", 295543900, "Black.System.Labeled.LabeledVariableManager.LabeledScope", 48, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCreateWhenNotFound_", 1149358935, "bool", 52, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTimer_", 599243182, "bool", 53, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("timerType_", 1026330487, "Black.System.Labeled.LabeledVariableManager.TimerType", 56, 4, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopTimerValue_", 1198246908, "float", 60, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bBindAnimationBlackBoard_", 530520710, "bool", 64, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("animationBlackBoardId_", 633310322, "SQEX.Ebony.Std.Fixid", 68, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}