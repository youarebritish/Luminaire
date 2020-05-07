using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerOwnershipNotify : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inSet_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inRelease_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inAcquireOwnership_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inReleaseOwnership_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOtherAcquired_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOtherReleased_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSucceed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFailed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueActor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerOwnershipNotify();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerOwnershipNotify", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerOwnershipNotify.ObjectType, null, properties, 0, 1072);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerOwnershipNotify", base.GetFieldProperties(), -1576234659, 1225801774);
            return fieldProperties;
        }

		
    }
}