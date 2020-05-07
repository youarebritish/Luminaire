using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class SwfDefEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string filePath_;
		public int swfType_;
		public int directionType_;
		public float defaultRatio_;
		public float speedRatio_;
		public bool hasPixelInfo_;
		public int lengthPixel_;
		public int offsetPixel_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SwfDefEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.SwfDefEntity", 0, Black.Entity.Menu.SwfDefEntity.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.SwfDefEntity", base.GetFieldProperties(), 781947166, -274688800);
            return fieldProperties;
        }

		
    }
}