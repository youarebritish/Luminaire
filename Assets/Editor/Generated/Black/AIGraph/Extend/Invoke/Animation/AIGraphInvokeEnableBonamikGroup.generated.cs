using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Animation
{
    public partial class AIGraphInvokeEnableBonamikGroup : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int groupTag_;
		public bool enable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeEnableBonamikGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeEnableBonamikGroup", 0, Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeEnableBonamikGroup.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeEnableBonamikGroup", base.GetFieldProperties(), 1681547666, 1230161761);
            return fieldProperties;
        }

		
    }
}