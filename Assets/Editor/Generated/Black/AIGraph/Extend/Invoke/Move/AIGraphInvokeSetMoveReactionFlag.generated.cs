using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Move
{
    public partial class AIGraphInvokeSetMoveReactionFlag : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int setReactionFlagType_;
		public bool isReactionEnable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetMoveReactionFlag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Move.AIGraphInvokeSetMoveReactionFlag", 0, Black.AIGraph.Extend.Invoke.Move.AIGraphInvokeSetMoveReactionFlag.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Move.AIGraphInvokeSetMoveReactionFlag", base.GetFieldProperties(), -486348449, -146791689);
            return fieldProperties;
        }

		
    }
}