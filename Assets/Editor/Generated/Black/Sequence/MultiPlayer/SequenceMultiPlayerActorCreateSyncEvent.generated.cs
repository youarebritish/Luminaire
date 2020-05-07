using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerActorCreateSyncEvent : Black.Sequence.MultiPlayer.SequenceMultiPlayerSyncEventBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueUniqueId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueAreaId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueGroupId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueUniqueId_;
		public uint uniqueFilterId_;
		public bool ignoreSamePeerId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerActorCreateSyncEvent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerActorCreateSyncEvent", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerActorCreateSyncEvent.ObjectType, null, properties, 0, 776);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerActorCreateSyncEvent", base.GetFieldProperties(), -63061391, 1307896552);
            
			
			
			return fieldProperties;
        }

		
    }
}