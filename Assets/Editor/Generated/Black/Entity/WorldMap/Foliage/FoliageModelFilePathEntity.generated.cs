using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap.Foliage
{
    public partial class FoliageModelFilePathEntity : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string foliageModelFilePath_;
		public string foliageHighModelFilePath_;
		public string foliageCollisionFilePath_;
		public string foliageHighCollisionFilePath_;
		public int foliageCategory_;
		public bool isBakable_;
		public bool shiftTarget_;
		public float shiftTargetOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FoliageModelFilePathEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity", 0, Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity.ObjectType, null, properties, 0, 88);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity", base.GetFieldProperties(), -1290797530, 1679866869);
            return fieldProperties;
        }

		
    }
}