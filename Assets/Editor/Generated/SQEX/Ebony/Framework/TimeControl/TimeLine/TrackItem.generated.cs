using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl.TimeLine
{
    public partial class TrackItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_;
		public float startTime_;
		public float duration_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem", 0, SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem.ObjectType, null, properties, 0, 88);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem", base.GetFieldProperties(), 1349529639, -2107058763);
            return fieldProperties;
        }

		
    }
}