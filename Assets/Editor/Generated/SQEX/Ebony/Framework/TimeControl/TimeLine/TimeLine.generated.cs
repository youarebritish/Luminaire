using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl.TimeLine
{
    public partial class TimeLine : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float workAreaLeft_;
		public float workAreaRight_;
		public IList<SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue> subTimeLineList_;
		public IList<SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue> mainTimeLineList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TimeLine();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.TimeLine.TimeLine", 0, SQEX.Ebony.Framework.TimeControl.TimeLine.TimeLine.ObjectType, null, properties, 0, 120);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.TimeLine.TimeLine", base.GetFieldProperties(), 1862539080, 1461767129);
            
			
			
			return fieldProperties;
        }

		
    }
}