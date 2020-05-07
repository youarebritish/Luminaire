using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Enemy
{
    public partial class AIGraphInvokeEnemyBodyAttackNotification : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool bAttackStartOrFinish_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeEnemyBodyAttackNotification();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeEnemyBodyAttackNotification", 0, Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeEnemyBodyAttackNotification.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeEnemyBodyAttackNotification", base.GetFieldProperties(), 1266971849, -1462689074);
            return fieldProperties;
        }

		
    }
}