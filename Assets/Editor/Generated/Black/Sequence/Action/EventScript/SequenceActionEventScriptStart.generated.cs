using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.EventScript
{
    public partial class SequenceActionEventScriptStart : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin executorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetCharacterPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succeededFinish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancelledFinish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin forceSceneIdValueInputPin_;
		public uint sceneId_;
		public uint scriptGroup_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin varSceneGroup_;
		public bool isAutoLoadVoice_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEventScriptStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.EventScript.SequenceActionEventScriptStart", 0, Black.Sequence.Action.EventScript.SequenceActionEventScriptStart.ObjectType, null, properties, 0, 1216);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.EventScript.SequenceActionEventScriptStart", base.GetFieldProperties(), 615094401, 996909273);
            
			
			
			return fieldProperties;
        }

		
    }
}