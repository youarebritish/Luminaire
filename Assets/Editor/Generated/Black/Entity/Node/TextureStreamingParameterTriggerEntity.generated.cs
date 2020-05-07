using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class TextureStreamingParameterTriggerEntity : Black.Entity.Node.TriggerEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int parameterType_;
		public long setValueInt_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TextureStreamingParameterTriggerEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.TextureStreamingParameterTriggerEntity", 0, Black.Entity.Node.TextureStreamingParameterTriggerEntity.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.TextureStreamingParameterTriggerEntity", base.GetFieldProperties(), 1397865198, -348859942);
            return fieldProperties;
        }

		
    }
}