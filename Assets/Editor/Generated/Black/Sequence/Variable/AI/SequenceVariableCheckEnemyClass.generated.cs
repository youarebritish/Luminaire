using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.AI
{
    public partial class SequenceVariableCheckEnemyClass : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public int enemyClass_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isGreaterThanPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isLessThanPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isEqualPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableCheckEnemyClass();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.AI.SequenceVariableCheckEnemyClass", 0, Black.Sequence.Variable.AI.SequenceVariableCheckEnemyClass.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.AI.SequenceVariableCheckEnemyClass", base.GetFieldProperties(), -1974816668, 1226830256);
            return fieldProperties;
        }

		
    }
}