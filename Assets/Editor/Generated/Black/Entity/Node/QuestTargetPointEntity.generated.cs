using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class QuestTargetPointEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint destinationEntryId_;
		public int markerOffsetPixel_;
		public uint groupNumberId_;
		public int markerType_;
		public float radius_;
		public uint questId_;
		public uint questEntryId_;
		public uint mapId_;
		public string memo_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new QuestTargetPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.QuestTargetPointEntity", 0, Black.Entity.Node.QuestTargetPointEntity.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.QuestTargetPointEntity", base.GetFieldProperties(), -1696469695, 1476568926);
            
			
			
			return fieldProperties;
        }

		
    }
}