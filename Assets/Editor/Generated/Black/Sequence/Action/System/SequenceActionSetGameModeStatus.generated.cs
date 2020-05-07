using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionSetGameModeStatus : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inNewGame_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inLoadGame_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inGameOver_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inCamp_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inRegistCar_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inMemoryQuest_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inDebugMenu_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inChapterSelect_;
		public bool isReset_;
		public bool isResetNotFlowBootNormal_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetGameModeStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionSetGameModeStatus", 0, Black.Sequence.Action.System.SequenceActionSetGameModeStatus.ObjectType, null, properties, 0, 1080);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionSetGameModeStatus", base.GetFieldProperties(), -664053467, 2115837605);
            
			
			
			return fieldProperties;
        }

		
    }
}