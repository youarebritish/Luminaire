using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class PointMoveNodeEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string aniPath_;
		public uint motionId_;
		public bool useRotateTrigger_;
		public bool enableMotionYscale_;
		public float scaledAnimPlaybackSpeed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PointMoveNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.PointMoveNodeEntity", 0, Black.Entity.Node.PointMoveNodeEntity.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.PointMoveNodeEntity", base.GetFieldProperties(), -1285261840, -1677668715);
            
			
			
			return fieldProperties;
        }

		
    }
}