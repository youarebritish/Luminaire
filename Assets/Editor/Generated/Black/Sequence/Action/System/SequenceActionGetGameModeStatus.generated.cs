using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionGetGameModeStatus : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outNewGame_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outLoadGame_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outGameOver_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outCamp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outBooDebugMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outBooNormal_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outRegistCar_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outMemoryQuest_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueOutMemoryQuest_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outBooRun_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outRetryPoint_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin debugMenuFixid_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outChapterSelect_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin selectedChapter_;
		public bool isUseRunEditor_;
		public bool isUseRetryPoint_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetGameModeStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionGetGameModeStatus", 0, Black.Sequence.Action.System.SequenceActionGetGameModeStatus.ObjectType, null, properties, 0, 1744);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionGetGameModeStatus", base.GetFieldProperties(), 2034673882, 574476562);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outNewGame_", 4187873054, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outLoadGame_", 2370643910, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outGameOver_", 359685920, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outCamp_", 341474759, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outBooDebugMenu_", 1393963696, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outBooNormal_", 3835426119, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outRegistCar_", 1917641510, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outMemoryQuest_", 2076928463, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1040, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueOutMemoryQuest_", 751051114, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1136, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outBooRun_", 4111655135, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1224, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outRetryPoint_", 2737995512, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1320, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("debugMenuFixid_", 2913665704, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1416, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outChapterSelect_", 3240430493, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1504, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectedChapter_", 1487883514, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1600, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseRunEditor_", 2650151089, "bool", 1688, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseRetryPoint_", 3301411405, "bool", 1689, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}