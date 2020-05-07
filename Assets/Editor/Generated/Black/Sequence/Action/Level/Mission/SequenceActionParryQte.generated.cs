using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Mission
{
    public partial class SequenceActionParryQte : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin guardEnd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin parryInteractStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin interactEnd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin interactDecide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin counterInteractStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public uint attackId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionParryQte();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Mission.SequenceActionParryQte", 0, Black.Sequence.Action.Level.Mission.SequenceActionParryQte.ObjectType, null, properties, 0, 1040);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Mission.SequenceActionParryQte", base.GetFieldProperties(), -949193908, -244145929);
            
			
			
			return fieldProperties;
        }

		
    }
}