using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class CollectVoiceEarcEntry : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string id_;
		public string searchParamTable_;
		public string ebexPathKey_;
		public string idKey_;
		public bool isAutoLoad_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CollectVoiceEarcEntry();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CollectVoiceEarcEntry", 0, Black.Entity.Data.CollectVoiceEarcEntry.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CollectVoiceEarcEntry", base.GetFieldProperties(), -1488683193, 2114445571);
            return fieldProperties;
        }

		
    }
}