using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Nifl.ComponentData
{
    public partial class WireArmComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float wireMoveSpeed_;
		public float wireHomingAngle_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WireArmComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Nifl.ComponentData.WireArmComponentData", 0, Black.Actor.Component.Nifl.ComponentData.WireArmComponentData.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Nifl.ComponentData.WireArmComponentData", base.GetFieldProperties(), 783898617, 968478896);
            return fieldProperties;
        }

		
    }
}