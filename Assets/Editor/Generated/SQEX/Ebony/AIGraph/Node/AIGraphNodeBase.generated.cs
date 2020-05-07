using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node
{
    public partial class AIGraphNodeBase : SQEX.Ebony.AIGraph.AIGraphRunnableBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase> invokeListOnActivate_;
		public IList<SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase> invokeListOnDeactivate_;
		public IList<SQEX.Ebony.AIGraph.Data.ConditionData> conditions_;
		public string displayName_;
		public string displayNameJP_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.AIGraphNodeBase", 0, SQEX.Ebony.AIGraph.Node.AIGraphNodeBase.ObjectType, null, properties, 0, 160);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.AIGraphNodeBase", base.GetFieldProperties(), 1887313510, 414318621);
            
			
			
			return fieldProperties;
        }

		
    }
}