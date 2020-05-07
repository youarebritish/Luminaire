using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineActorTrackBase : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorTrackBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase", base.GetFieldProperties(), -1347628637, 955779662);
            return fieldProperties;
        }

		
    }
}