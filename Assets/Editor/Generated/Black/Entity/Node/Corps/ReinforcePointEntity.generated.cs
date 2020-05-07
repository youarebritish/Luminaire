using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node.Corps
{
    public partial class ReinforcePointEntity : Black.Entity.Node.Corps.ReinforceAppearGroupEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint jointId_;
		public string reinforceLabel_;
		public uint reinforcePointLabel_;
		public bool isDebugDraw_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ReinforcePointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.Corps.ReinforcePointEntity", 0, Black.Entity.Node.Corps.ReinforcePointEntity.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.Corps.ReinforcePointEntity", base.GetFieldProperties(), 135583237, 1046699419);
            return fieldProperties;
        }

		
    }
}