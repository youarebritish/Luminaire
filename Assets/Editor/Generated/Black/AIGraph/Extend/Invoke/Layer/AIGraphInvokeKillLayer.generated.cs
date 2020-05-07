using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Layer
{
    public partial class AIGraphInvokeKillLayer : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint animLayer;
		public bool isWaitAnimFinish;
		public uint animMsg;
		public float deleteBlendTime;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeKillLayer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Layer.AIGraphInvokeKillLayer", 0, Black.AIGraph.Extend.Invoke.Layer.AIGraphInvokeKillLayer.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Layer.AIGraphInvokeKillLayer", base.GetFieldProperties(), 684639665, -940964855);
            return fieldProperties;
        }

		
    }
}