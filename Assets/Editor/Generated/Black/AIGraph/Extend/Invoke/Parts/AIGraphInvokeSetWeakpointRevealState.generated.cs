using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Parts
{
    public partial class AIGraphInvokeSetWeakpointRevealState : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint partsId;
		public bool isWeakpointReveal;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetWeakpointRevealState();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Parts.AIGraphInvokeSetWeakpointRevealState", 0, Black.AIGraph.Extend.Invoke.Parts.AIGraphInvokeSetWeakpointRevealState.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Parts.AIGraphInvokeSetWeakpointRevealState", base.GetFieldProperties(), 511491536, -988440372);
            
			
			
			return fieldProperties;
        }

		
    }
}