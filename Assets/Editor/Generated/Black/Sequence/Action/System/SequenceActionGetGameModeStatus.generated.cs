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
            return fieldProperties;
        }

		
    }
}