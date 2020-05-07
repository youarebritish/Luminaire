using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Trial
{
    public partial class AIGraphInvokeNotifyToMeta : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int noticeType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeNotifyToMeta();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Trial.AIGraphInvokeNotifyToMeta", 0, Black.AIGraph.Extend.Invoke.Trial.AIGraphInvokeNotifyToMeta.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Trial.AIGraphInvokeNotifyToMeta", base.GetFieldProperties(), 789665391, 925394343);
            
			fieldProperties.AddProperty(new Property("noticeType", 3145351289, "Black.AIGraph.Extend.Invoke.Trial.AIGraphInvokeNotifyToMeta.NOTICE_TYPE", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}