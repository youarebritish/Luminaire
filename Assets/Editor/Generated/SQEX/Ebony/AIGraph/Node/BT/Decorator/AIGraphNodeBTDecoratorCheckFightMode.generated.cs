using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Decorator
{
    public partial class AIGraphNodeBTDecoratorCheckFightMode : SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isDefend_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTDecoratorCheckFightMode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorCheckFightMode", 0, SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorCheckFightMode.ObjectType, null, properties, 0, 232);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorCheckFightMode", base.GetFieldProperties(), 1505826406, 216406340);
            return fieldProperties;
        }

		
    }
}