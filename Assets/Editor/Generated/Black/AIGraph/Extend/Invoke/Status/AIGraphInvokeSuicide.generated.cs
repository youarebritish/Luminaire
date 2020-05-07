using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Status
{
    public partial class AIGraphInvokeSuicide : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool canGetExp;
		public bool changeHPZero;
		public bool isPlayVFX;
		public bool isPlaySE;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSuicide();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Status.AIGraphInvokeSuicide", 0, Black.AIGraph.Extend.Invoke.Status.AIGraphInvokeSuicide.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Status.AIGraphInvokeSuicide", base.GetFieldProperties(), 1184732927, -509484312);
            
			
			
			return fieldProperties;
        }

		
    }
}