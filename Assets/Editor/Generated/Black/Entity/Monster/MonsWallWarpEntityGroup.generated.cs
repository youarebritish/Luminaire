using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Monster
{
    public partial class MonsWallWarpEntityGroup : SQEX.Ebony.Framework.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint wallWarpSetID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MonsWallWarpEntityGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Monster.MonsWallWarpEntityGroup", 0, Black.Entity.Monster.MonsWallWarpEntityGroup.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("Black.Entity.Monster.MonsWallWarpEntityGroup", base.GetFieldProperties(), 1433611499, -1296477873);
            return fieldProperties;
        }

		
    }
}