using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Vfx
{
    public partial class VLeafEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float baseScaling_;
		public bool enabled_;
		public string vleafPath_;
		public uint leafId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VLeafEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Vfx.VLeafEntity", 0, Black.Entity.Vfx.VLeafEntity.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.Entity.Vfx.VLeafEntity", base.GetFieldProperties(), 712700505, 151073385);
            return fieldProperties;
        }

		
    }
}