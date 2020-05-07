using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Entity
{
    public partial class TransformEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 rotation_;
		public uint entitySearchLabelId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TransformEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Entity.TransformEntity", 0, SQEX.Ebony.Framework.Entity.TransformEntity.ObjectType, null, properties, 1, 224);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Entity.TransformEntity", base.GetFieldProperties(), 835998973, -9836021);
            return fieldProperties;
        }

		
    }
}