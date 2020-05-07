using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Map
{
    public partial class NavigationOffMeshMultiLinkPointAttr : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 start_;
		public UnityEngine.Vector4 end_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NavigationOffMeshMultiLinkPointAttr();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Map.NavigationOffMeshMultiLinkPointAttr", 0, Black.Entity.Map.NavigationOffMeshMultiLinkPointAttr.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.Entity.Map.NavigationOffMeshMultiLinkPointAttr", base.GetFieldProperties(), 182335450, 1841283140);
            
			
			
			return fieldProperties;
        }

		
    }
}