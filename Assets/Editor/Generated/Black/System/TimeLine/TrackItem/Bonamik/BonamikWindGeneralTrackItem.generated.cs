using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Bonamik
{
    public partial class BonamikWindGeneralTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int windType_;
		public uint bnmwndId_;
		public UnityEngine.Vector4 windForce_;
		public UnityEngine.Vector4 randomRange_;
		public float randomTime_;
		public float blastStrength_;
		public float blastRange_;
		public float blastPeakInRange_;
		public float blastSpeed_;
		public bool blastIsLoop_;
		public int blastLoop_;
		public float windMultiplier_;
		public float speedMultiplier_;
		public int windKind_;
		public int areaType_;
		public bool globalAddition_;
		public float radius_;
		public UnityEngine.Vector4 boxSize_;
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 rotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikWindGeneralTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Bonamik.BonamikWindGeneralTrackItem", 0, Black.System.TimeLine.TrackItem.Bonamik.BonamikWindGeneralTrackItem.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Bonamik.BonamikWindGeneralTrackItem", base.GetFieldProperties(), 1756632349, -349247785);
            return fieldProperties;
        }

		
    }
}