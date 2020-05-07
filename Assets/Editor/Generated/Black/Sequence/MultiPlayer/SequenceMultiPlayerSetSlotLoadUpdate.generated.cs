using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerSetSlotLoadUpdate : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inLoad_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inUnload_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inTargetId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outWaiting_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFailure_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outLoadComplete_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outUnloadComplete_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerSetSlotLoadUpdate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerSetSlotLoadUpdate", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerSetSlotLoadUpdate.ObjectType, null, properties, 0, 872);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerSetSlotLoadUpdate", base.GetFieldProperties(), -2082335581, 688816161);
            
			
			
			return fieldProperties;
        }

		
    }
}