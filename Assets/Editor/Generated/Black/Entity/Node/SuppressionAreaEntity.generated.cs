using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class SuppressionAreaEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enable_;
		public uint areaFixid_;
		public uint nameFixId_;
		public uint activeMessage_;
		public uint suppressedMessage_;
		public int status_;
		public bool determineStatus_;
		public int enemyToKill_;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> battleAreaIdList_;
		public UnityEngine.Vector4 scaling_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SuppressionAreaEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.SuppressionAreaEntity", 0, Black.Entity.Node.SuppressionAreaEntity.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.SuppressionAreaEntity", base.GetFieldProperties(), -621542782, -43807298);
            return fieldProperties;
        }

		
    }
}