using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Props.ComponentData
{
    public partial class SearchLightComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 lightOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SearchLightComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Props.ComponentData.SearchLightComponentData", 0, Black.Actor.Component.Props.ComponentData.SearchLightComponentData.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Props.ComponentData.SearchLightComponentData", base.GetFieldProperties(), -1458279179, -1012852168);
            return fieldProperties;
        }

		
    }
}