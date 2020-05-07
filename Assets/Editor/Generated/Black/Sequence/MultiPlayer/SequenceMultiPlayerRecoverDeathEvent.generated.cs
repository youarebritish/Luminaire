using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerRecoverDeathEvent : Black.Sequence.MultiPlayer.SequenceMultiPlayerSyncEventBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerRecoverDeathEvent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerRecoverDeathEvent", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerRecoverDeathEvent.ObjectType, null, properties, 0, 296);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerRecoverDeathEvent", base.GetFieldProperties(), -1239290802, 1560571255);
            return fieldProperties;
        }

		
    }
}