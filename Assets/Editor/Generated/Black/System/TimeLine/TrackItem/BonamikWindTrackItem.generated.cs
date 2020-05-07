using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class BonamikWindTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint bnmwndId_;
		public float windMultiplier_;
		public float speedMultiplier_;
		public int windKind_;
		public int areaType_;
		public bool globalAddition_;
		public float radius_;
		public UnityEngine.Vector4 boxSize_;
		public bool isAttach_;
		public uint elementId_;
		public UnityEngine.Vector4 offset_;
		public UnityEngine.Vector4 rotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikWindTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.BonamikWindTrackItem", 0, Black.System.TimeLine.TrackItem.BonamikWindTrackItem.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.BonamikWindTrackItem", base.GetFieldProperties(), -1405187234, -528592524);
            return fieldProperties;
        }

		
    }
}