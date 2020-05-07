using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Entity
{
    public partial class EntityGroup : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.Framework.Entity.Entity> entities_;
		public bool hasTransform_;
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 rotation_;
		public float scaling_;
		public bool canManipulate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new EntityGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Entity.EntityGroup", 0, SQEX.Ebony.Framework.Entity.EntityGroup.ObjectType, null, properties, 1, 208);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Entity.EntityGroup", base.GetFieldProperties(), -19257582, -76626717);
            return fieldProperties;
        }

		
    }
}