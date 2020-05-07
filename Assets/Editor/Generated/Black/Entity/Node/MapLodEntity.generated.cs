using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class MapLodEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isPackageLoad_;
		public IList<Black.Entity.Data.Area.MapLodItem> mapLodLowItemList_;
		public IList<Black.Entity.Data.Area.MapLodItem> mapLodHighItemList_;
		public float unloadMargin_;
		public UnityEngine.Vector4 scaling_;
		public int triggerType_;
		public string groupName_;
		public UnityEngine.Color color_;
		public int priority_;
		public bool isLowPackageLoad_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MapLodEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.MapLodEntity", 0, Black.Entity.Node.MapLodEntity.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.MapLodEntity", base.GetFieldProperties(), -1286050958, -897659782);
            return fieldProperties;
        }

		
    }
}