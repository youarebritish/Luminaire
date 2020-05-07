using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientSmartLocationTemplate : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint archeType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientSmartLocationTemplate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientSmartLocationTemplate", 0, Black.AI.Ambient.AmbientSmartLocationTemplate.ObjectType, null, properties, 0, 216);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientSmartLocationTemplate", base.GetFieldProperties(), 1528184899, 527442079);
            return fieldProperties;
        }

		
    }
}