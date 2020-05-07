using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Action
{
    public partial class SequenceActionTimeLineMultiEventTrack : SQEX.Ebony.Framework.Sequence.Tray.SequenceTrayBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineMultiEventTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineMultiEventTrack", 0, SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineMultiEventTrack.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineMultiEventTrack", base.GetFieldProperties(), 1561806423, 861273724);
            
			
			
			return fieldProperties;
        }

		
    }
}