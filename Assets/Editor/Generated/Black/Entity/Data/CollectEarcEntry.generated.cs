using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class CollectEarcEntry : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isAutoLoad_;
		public bool isEarcExternal_;
		public bool isEventScriptVoiceAll_;
		public bool isVoiceAll_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CollectEarcEntry();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CollectEarcEntry", 0, Black.Entity.Data.CollectEarcEntry.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CollectEarcEntry", base.GetFieldProperties(), -1932515064, -2142229580);
            
			
			
			return fieldProperties;
        }

		
    }
}