using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerSlotLoaderUpdate : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inActivate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inLoadFinish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inUnloadFinish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outLoadRequest_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outUnloadRequest_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outTargetId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outTargetUnloadId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outTargetIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerSlotLoaderUpdate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerSlotLoaderUpdate", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerSlotLoaderUpdate.ObjectType, null, properties, 0, 944);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerSlotLoaderUpdate", base.GetFieldProperties(), -1307891864, 708458707);
            
			
			
			return fieldProperties;
        }

		
    }
}