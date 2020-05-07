using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl.TimeLine
{
    public partial class Track : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_;
		public int trackType_;
		public int groupType_;
		public int trackDetailType_;
		public int trackItemType_;
		public bool isEnable_;
		public string activatePin_;
		public IList<SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem> trackItemList_;
		public IList<SQEX.Ebony.Framework.Sequence.SequenceActivatableNode> nodes_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Track();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.TimeLine.Track", 0, SQEX.Ebony.Framework.TimeControl.TimeLine.Track.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.TimeLine.Track", base.GetFieldProperties(), -632846832, -830786190);
            return fieldProperties;
        }

		
    }
}