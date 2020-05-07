using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAIMoveBase : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin timeOutPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moveSpeedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin arrivalMoveSpeedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin oeprateActor_;
		public float timeOut_;
		public float moveSpeed_;
		public float arrivalMoveSpeed_;
		public bool paramEachUpdate_;
		public int aiMoveControlMode_;
		public int aiMoveMode_;
		public bool noUseNavMesh_;
		public bool ignoreYDir_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIMoveBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAIMoveBase", 0, Black.Sequence.Actor.AI.SequenceActionAIMoveBase.ObjectType, null, properties, 0, 896);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAIMoveBase", base.GetFieldProperties(), -2103281379, 1630822966);
            return fieldProperties;
        }

		
    }
}