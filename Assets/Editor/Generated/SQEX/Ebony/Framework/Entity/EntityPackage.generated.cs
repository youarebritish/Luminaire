using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Entity
{
    public partial class EntityPackage : SQEX.Ebony.Framework.Entity.EntityPackageReference
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Luminous.Core.Object.Object> loadedObjects_;
		public IList<string> loadedObjectNames_;
		public IList<string> loadedObjectPaths_;
		public int sequenceUpdateOrderPreset_;
		public short sequenceUpdateOrderDirect_;
		public IList<SQEX.Ebony.Framework.Entity.EntityPackageSharedRefItem> entityPackageSharedChildPathList_;
		public uint packageSearchLabelId_;
		public bool bUmbraBakeTarget_;
		public bool bForbidDuplicatedLoad_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new EntityPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Entity.EntityPackage", 0, SQEX.Ebony.Framework.Entity.EntityPackage.ObjectType, null, properties, 8, 592);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Entity.EntityPackage", base.GetFieldProperties(), -1610658500, -1708356512);
            
			
			
			return fieldProperties;
        }

		
    }
}