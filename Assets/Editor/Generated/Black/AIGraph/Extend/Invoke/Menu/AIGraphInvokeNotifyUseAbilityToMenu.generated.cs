using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Menu
{
    public partial class AIGraphInvokeNotifyUseAbilityToMenu : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeNotifyUseAbilityToMenu();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Menu.AIGraphInvokeNotifyUseAbilityToMenu", 0, Black.AIGraph.Extend.Invoke.Menu.AIGraphInvokeNotifyUseAbilityToMenu.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Menu.AIGraphInvokeNotifyUseAbilityToMenu", base.GetFieldProperties(), -1243342567, -1526166220);
            
			
			
			return fieldProperties;
        }

		
    }
}