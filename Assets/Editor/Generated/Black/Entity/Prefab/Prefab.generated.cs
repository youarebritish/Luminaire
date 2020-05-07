using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Prefab
{
    public partial class Prefab : SQEX.Ebony.Framework.Entity.Prefab.Prefab
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePathForDrop_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Prefab();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Prefab.Prefab", 0, Black.Entity.Prefab.Prefab.ObjectType, null, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Entity.Prefab.Prefab", base.GetFieldProperties(), -898387587, -1994132092);
            
			
			
			return fieldProperties;
        }

		
    }
}