using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Menu
{
    public partial class AIGraphInvokeNotifyParryMarkerToMenu : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enable_;
		public uint attackParamId_;
		public int targetSlotType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeNotifyParryMarkerToMenu();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Menu.AIGraphInvokeNotifyParryMarkerToMenu", 0, Black.AIGraph.Extend.Invoke.Menu.AIGraphInvokeNotifyParryMarkerToMenu.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Menu.AIGraphInvokeNotifyParryMarkerToMenu", base.GetFieldProperties(), 1112391870, -807911555);
            
			
			
			return fieldProperties;
        }

		
    }
}