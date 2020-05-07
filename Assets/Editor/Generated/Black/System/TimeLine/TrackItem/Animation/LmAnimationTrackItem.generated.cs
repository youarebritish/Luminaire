using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Animation
{
    public partial class LmAnimationTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public float totalBaseFrame_;
		public float speed_;
		public bool isLoop_;
		public float startFrame_;
		public float endFrame_;
		public bool isMirrored_;
		public int matchTrigger_;
		public int rootRotationType_;
		public int rootTranslationType_;
		public bool freezeSource_;
		public bool freezeTarget_;
		public bool noAnimFacingRecompute_;
		public bool noAnimOriginRecompute_;
		public bool lockAnimFacing_;
		public bool lockAnimOrigin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmAnimationTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Animation.LmAnimationTrackItem", 0, Black.System.TimeLine.TrackItem.Animation.LmAnimationTrackItem.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Animation.LmAnimationTrackItem", base.GetFieldProperties(), -622285299, 1163326657);
            
			
			
			return fieldProperties;
        }

		
    }
}