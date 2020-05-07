using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Map
{
    public partial class NavigationOffMeshLink : Black.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isBidirectional_;
		public int linkUser_;
		public uint archetype_;
		public int linkType_;
		public bool isDebugDraw_;
		public bool isDisabled_;
		public uint message_;
		public uint oppositeMessage_;
		public uint enableID_;
		public bool hasTimeScale_;
		public float speedScale_;
		public int blackUniqueKeyFixUp_;
		public bool isArrivalSpeedSet_;
		public float arrivalSpeed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NavigationOffMeshLink();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Map.NavigationOffMeshLink", 0, Black.Entity.Map.NavigationOffMeshLink.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Map.NavigationOffMeshLink", base.GetFieldProperties(), -1541157720, 762140961);
            
			
			
			return fieldProperties;
        }

		
    }
}