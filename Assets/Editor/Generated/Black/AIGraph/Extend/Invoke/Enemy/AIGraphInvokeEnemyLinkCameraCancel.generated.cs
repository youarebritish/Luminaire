using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Enemy
{
    public partial class AIGraphInvokeEnemyLinkCameraCancel : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeEnemyLinkCameraCancel();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeEnemyLinkCameraCancel", 0, Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeEnemyLinkCameraCancel.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeEnemyLinkCameraCancel", base.GetFieldProperties(), 2055310165, 1968283604);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}