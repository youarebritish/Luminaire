using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModeBase : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outStop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succeeded_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishByDamage_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishByEncount_;
		public bool bEndByDamage_;
		public bool bEndByEncountGauge_;
		public bool bCancelByBattle_;
		public bool bReturnNormalModeWhenFinish_;
		public bool bForceExec_;
		public bool bWaitAction_;
		public bool bEnableNormalPosture_;
		public bool bHideForReset_;
		public bool bHideReturnNormal_;
		public bool bHideEndDanage_;
		public bool bHideNormalPosture_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModeBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase.ObjectType, null, properties, 0, 1224);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase", base.GetFieldProperties(), 345625330, 1186690777);
            return fieldProperties;
        }

		
    }
}