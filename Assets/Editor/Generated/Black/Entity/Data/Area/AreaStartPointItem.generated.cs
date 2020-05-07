using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Area
{
    public partial class AreaStartPointItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 areaStartPosition_;
		public string memo_;
		public string labelName_;
		public int valueType_;
		public int labelValue_;
		public float labelValueFloat_;
		public bool labelValueBool_;
		public string labelValueString_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AreaStartPointItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Area.AreaStartPointItem", 0, Black.Entity.Data.Area.AreaStartPointItem.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Area.AreaStartPointItem", base.GetFieldProperties(), -420074028, -164583431);
            return fieldProperties;
        }

		
    }
}