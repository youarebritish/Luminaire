using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Action
{
    public partial class SequenceActionTimeLineEventTrack : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin callBackOutputPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineEventTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineEventTrack", 0, SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineEventTrack.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineEventTrack", base.GetFieldProperties(), 389046668, -1271625879);
            return fieldProperties;
        }

		
    }
}