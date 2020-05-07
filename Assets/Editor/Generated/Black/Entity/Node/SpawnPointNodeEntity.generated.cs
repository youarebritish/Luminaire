using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class SpawnPointNodeEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int capacity_;
		public bool enable_;
		public UnityEngine.Color color_;
		public float radius_;
		public uint battleAreaSeedPointFixid_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SpawnPointNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.SpawnPointNodeEntity", 0, Black.Entity.Node.SpawnPointNodeEntity.ObjectType, null, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.SpawnPointNodeEntity", base.GetFieldProperties(), -64380948, 1282674613);
            return fieldProperties;
        }

		
    }
}