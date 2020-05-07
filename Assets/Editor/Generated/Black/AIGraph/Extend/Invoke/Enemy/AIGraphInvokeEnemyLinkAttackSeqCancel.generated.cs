using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Enemy
{
    public partial class AIGraphInvokeEnemyLinkAttackSeqCancel : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeEnemyLinkAttackSeqCancel();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeEnemyLinkAttackSeqCancel", 0, Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeEnemyLinkAttackSeqCancel.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeEnemyLinkAttackSeqCancel", base.GetFieldProperties(), 780335766, 526817526);
            
			
			
			return fieldProperties;
        }

		
    }
}