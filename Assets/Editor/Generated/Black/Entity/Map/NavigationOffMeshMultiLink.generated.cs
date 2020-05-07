using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Map
{
    public partial class NavigationOffMeshMultiLink : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.Map.NavigationOffMeshMultiLinkPointAttr> linkDatas_;
		public bool isBidirectional_;
		public int linkUser_;
		public uint archetype_;
		public int linkType_;
		public bool isDisabled_;
		public uint message_;
		public uint oppositeMessage_;
		public bool hasTimeScale_;
		public float speedScale_;
		public int blackUniqueKeyFixUp_;
		public int pointsPerSegment_;
		public bool enableDebugDrawing_;
		public bool isArrivalSpeedSet_;
		public float arrivalSpeed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NavigationOffMeshMultiLink();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Map.NavigationOffMeshMultiLink", 0, Black.Entity.Map.NavigationOffMeshMultiLink.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Entity.Map.NavigationOffMeshMultiLink", base.GetFieldProperties(), 816126815, -2023226518);
            
			
			
			return fieldProperties;
        }

		
    }
}