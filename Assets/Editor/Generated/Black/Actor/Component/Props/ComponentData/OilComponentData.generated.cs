using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Props.ComponentData
{
    public partial class OilComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float eraseTime_;
		public float eraseDistance_;
		public float oilRadius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OilComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Props.ComponentData.OilComponentData", 0, Black.Actor.Component.Props.ComponentData.OilComponentData.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Props.ComponentData.OilComponentData", base.GetFieldProperties(), -1842449721, 410629496);
            return fieldProperties;
        }

		
    }
}