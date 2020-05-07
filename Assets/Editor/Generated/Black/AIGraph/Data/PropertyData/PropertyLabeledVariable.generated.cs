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
            
			
			
			return fieldProperties;
        }

		
    }
}