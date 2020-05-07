using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node.NiflBase
{
    public partial class NiflBaseNotifyCautionInfoEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float radius_;
		public int cautionInfoLevel_;
		public bool isDefaultEnable_;
		public float enableTimer_;
		public bool isDebugDraw_;
		public float minArrivalDistance_;
		public float maxArrivalDistance_;
		public float waitTimeOnArrival_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NiflBaseNotifyCautionInfoEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.NiflBase.NiflBaseNotifyCautionInfoEntity", 0, Black.Entity.Node.NiflBase.NiflBaseNotifyCautionInfoEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.NiflBase.NiflBaseNotifyCautionInfoEntity", base.GetFieldProperties(), 1197222885, -962120352);
            return fieldProperties;
        }

		
    }
}