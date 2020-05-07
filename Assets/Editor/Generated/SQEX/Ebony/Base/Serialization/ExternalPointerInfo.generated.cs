using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Base.Serialization
{
    public partial class ExternalPointerInfo : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public short protocol_;
		public object pointerAddress_;
		public object paramsBuffer_;
		public IList<string> keys_;
		public bool isIntrusive_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ExternalPointerInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Base.Serialization.ExternalPointerInfo", 0, SQEX.Ebony.Base.Serialization.ExternalPointerInfo.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Base.Serialization.ExternalPointerInfo", base.GetFieldProperties(), -1426701892, -61620564);
            
			
			
			return fieldProperties;
        }

		
    }
}