using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl.TimeLine
{
    public partial class SetBaseParamTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 rotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SetBaseParamTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.TimeLine.SetBaseParamTrackItem", 0, SQEX.Ebony.Framework.TimeControl.TimeLine.SetBaseParamTrackItem.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.TimeLine.SetBaseParamTrackItem", base.GetFieldProperties(), 1408240878, 983128427);
            return fieldProperties;
        }

		
    }
}