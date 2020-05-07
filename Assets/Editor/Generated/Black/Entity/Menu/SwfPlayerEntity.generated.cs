using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class SwfPlayerEntity : Black.Entity.Menu.SwfEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string filePath_;
		public bool isAbsoluteOffset_;
		public bool isSetOffset_;
		public UnityEngine.Vector4 offset_;
		public bool isSetTextFieldConfig_;
		public IList<Black.Entity.Data.Menu.SwfPlayerTextFieldConfigArrayItem> textFieldConfigList_;
		public bool isClearAlphaMask_;
		public float clearAlphaMaskValue_;
		public bool isStopWhileGamePause_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SwfPlayerEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.SwfPlayerEntity", 0, Black.Entity.Menu.SwfPlayerEntity.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.SwfPlayerEntity", base.GetFieldProperties(), -1560917038, 183693272);
            return fieldProperties;
        }

		
    }
}