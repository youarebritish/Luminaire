using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.AI
{
    public partial class TacticsDefineDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_;
		public string role1_;
		public int num1_;
		public string role2_;
		public int num2_;
		public string role3_;
		public int num3_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TacticsDefineDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.AI.TacticsDefineDataEntity", 0, Black.Entity.Data.AI.TacticsDefineDataEntity.ObjectType, null, properties, 0, 168);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.AI.TacticsDefineDataEntity", base.GetFieldProperties(), -795094482, -305559889);
            
			
			
			return fieldProperties;
        }

		
    }
}