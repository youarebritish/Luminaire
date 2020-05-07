using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class RailMovePointNodeEntityGroup : SQEX.Ebony.Framework.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint motionId_;
		public float railPathWidth_;
		public bool drawInverseCurve_;
		public UnityEngine.Vector4 tcb_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RailMovePointNodeEntityGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.RailMovePointNodeEntityGroup", 0, Black.Entity.Node.RailMovePointNodeEntityGroup.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.RailMovePointNodeEntityGroup", base.GetFieldProperties(), 1510819898, 198280633);
            return fieldProperties;
        }

		
    }
}