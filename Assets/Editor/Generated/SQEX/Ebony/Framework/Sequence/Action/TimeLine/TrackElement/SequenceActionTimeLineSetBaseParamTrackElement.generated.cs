using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Action.TimeLine.TrackElement
{
    public partial class SequenceActionTimeLineSetBaseParamTrackElement : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineSetBaseParamTrackElement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Action.TimeLine.TrackElement.SequenceActionTimeLineSetBaseParamTrackElement", 0, SQEX.Ebony.Framework.Sequence.Action.TimeLine.TrackElement.SequenceActionTimeLineSetBaseParamTrackElement.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Action.TimeLine.TrackElement.SequenceActionTimeLineSetBaseParamTrackElement", base.GetFieldProperties(), 1715023943, 1171376220);
            
			
			
			return fieldProperties;
        }

		
    }
}