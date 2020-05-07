using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Ifrit
{
    public partial class AIGraphInvokeIfritInvisible : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool invisible;
		public float fadeTime;
		public bool linkageCharaCollision;
		public bool linkageBGCollision;
		public bool linkagePhysicsStaticBody;
		public bool linkageGravity;
		public bool linkageTarget;
		public bool linkageVFX;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeIfritInvisible();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Ifrit.AIGraphInvokeIfritInvisible", 0, Black.AIGraph.Extend.Invoke.Ifrit.AIGraphInvokeIfritInvisible.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Ifrit.AIGraphInvokeIfritInvisible", base.GetFieldProperties(), -505476122, 1501487113);
            return fieldProperties;
        }

		
    }
}