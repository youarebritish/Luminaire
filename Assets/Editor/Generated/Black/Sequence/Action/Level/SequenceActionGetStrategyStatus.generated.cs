using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetStrategyStatus : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSuggest_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outExecute_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSuccess_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFail_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outCooperation_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outCancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outStop_;
		public uint strategyId_;
		public bool updateStatusFlag_;
		public bool changeActivate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetStrategyStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetStrategyStatus", 0, Black.Sequence.Action.Level.SequenceActionGetStrategyStatus.ObjectType, null, properties, 0, 1152);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetStrategyStatus", base.GetFieldProperties(), 181551030, -830801083);
            return fieldProperties;
        }

		
    }
}