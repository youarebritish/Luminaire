using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.AI
{
    public partial class RoleDefineDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_;
		public uint charaEntryId1_;
		public uint charaEntryId2_;
		public uint charaEntryId3_;
		public bool bAnyChar_;
		public bool bPriorityNear_;
		public bool bCandidateLeader_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RoleDefineDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.AI.RoleDefineDataEntity", 0, Black.Entity.Data.AI.RoleDefineDataEntity.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.AI.RoleDefineDataEntity", base.GetFieldProperties(), -1563992405, -542564075);
            return fieldProperties;
        }

		
    }
}