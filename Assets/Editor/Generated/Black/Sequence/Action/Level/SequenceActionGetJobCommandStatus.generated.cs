using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetJobCommandStatus : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outExecute_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outContinue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outScriptFinish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outQTE_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFinish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOff_;
		public uint jobCommandId_;
		public bool updateStatusFlag_;
		public bool changeActivate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetJobCommandStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetJobCommandStatus", 0, Black.Sequence.Action.Level.SequenceActionGetJobCommandStatus.ObjectType, null, properties, 0, 1152);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetJobCommandStatus", base.GetFieldProperties(), -990035554, -1289988387);
            
			
			
			return fieldProperties;
        }

		
    }
}